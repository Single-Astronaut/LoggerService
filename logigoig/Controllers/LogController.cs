using Microsoft.AspNetCore.Mvc;
using Nest;
using Serilog;
using logigoig.Models;

namespace logigoig.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;

        public LogController(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        [HttpPost("log")]
        public async Task<IActionResult> LogAction([FromBody] LogEntry logEntry)
        {
            if (logEntry == null)
            {
                Log.Warning("Получен пустой запрос на логирование");
                return BadRequest("LogEntry cannot be null");
            }

            // Логируем только необходимые данные
            Log.Information("Логирование действия: {Action} пользователем {UserId}, {Description}", logEntry.Action, logEntry.UserId, logEntry.Description);

            // Создаем объект, который будем отправлять в Elasticsearch с только нужными полями
            var logToIndex = new
            {
                logEntry.UserId,
                logEntry.Action,
                logEntry.Description,
                logEntry.Timestamp
            };

            // Отправка данных в Elasticsearch
            var response = await _elasticClient.IndexDocumentAsync(logToIndex);
            if (!response.IsValid)
            {
                Log.Error("Ошибка при записи лога в Elasticsearch: {ErrorMessage}", response.OriginalException?.Message);
                return StatusCode(500, "Failed to save log entry");
            }

            return Ok("Log entry saved");
        }
    }
}