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
                Log.Warning("������� ������ ������ �� �����������");
                return BadRequest("LogEntry cannot be null");
            }

            // �������� ������ ����������� ������
            Log.Information("����������� ��������: {Action} ������������� {UserId}, {Description}", logEntry.Action, logEntry.UserId, logEntry.Description);

            // ������� ������, ������� ����� ���������� � Elasticsearch � ������ ������� ������
            var logToIndex = new
            {
                logEntry.UserId,
                logEntry.Action,
                logEntry.Description,
                logEntry.Timestamp
            };

            // �������� ������ � Elasticsearch
            var response = await _elasticClient.IndexDocumentAsync(logToIndex);
            if (!response.IsValid)
            {
                Log.Error("������ ��� ������ ���� � Elasticsearch: {ErrorMessage}", response.OriginalException?.Message);
                return StatusCode(500, "Failed to save log entry");
            }

            return Ok("Log entry saved");
        }
    }
}