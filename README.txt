{
    "took": 76,
    "timed_out": false,
    "_shards": {
        "total": 1,
        "successful": 1,
        "skipped": 0,
        "failed": 0
    },
    "hits": {
        "total": {
            "value": 58,
            "relation": "eq"
        },
        "max_score": 1.0,
        "hits": [
            {
                "_index": "user-logs-2024.12.26",
                "_id": "4iIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.2651540+04:00",
                    "level": "Information",
                    "messageTemplate": "Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).",
                    "message": "Route matched with \"{action = \\\"LogAction\\\", controller = \\\"Log\\\"}\". Executing controller action with signature \"System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.IActionResult] LogAction(logigoig.LogEntry)\" on controller \"logigoig.Controllers.LogController\" (\"logigoig\").",
                    "fields": {
                        "RouteData": "{action = \"LogAction\", controller = \"Log\"}",
                        "MethodInfo": "System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.IActionResult] LogAction(logigoig.LogEntry)",
                        "Controller": "logigoig.Controllers.LogController",
                        "AssemblyName": "logigoig",
                        "EventId": {
                            "Id": 102,
                            "Name": "ControllerActionExecuting"
                        },
                        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker",
                        "ActionId": "0ec65c01-c841-442b-8fad-fa4dc1706eb9",
                        "ActionName": "logigoig.Controllers.LogController.LogAction (logigoig)",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "4yIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.2927720+04:00",
                    "level": "Information",
                    "messageTemplate": "Логирование действия: {Action} пользователем {UserId}",
                    "message": "Логирование действия: \"LOGIN\" пользователем \"12345\"",
                    "fields": {
                        "Action": "LOGIN",
                        "UserId": "12345",
                        "ActionId": "0ec65c01-c841-442b-8fad-fa4dc1706eb9",
                        "ActionName": "logigoig.Controllers.LogController.LogAction (logigoig)",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "5CIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.8052377+04:00",
                    "level": "Information",
                    "messageTemplate": "Executing {ObjectResultType}, writing value of type '{Type}'.",
                    "message": "Executing \"OkObjectResult\", writing value of type '\"System.String\"'.",
                    "fields": {
                        "ObjectResultType": "OkObjectResult",
                        "Type": "System.String",
                        "EventId": {
                            "Id": 1,
                            "Name": "ObjectResultExecuting"
                        },
                        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor",
                        "ActionId": "0ec65c01-c841-442b-8fad-fa4dc1706eb9",
                        "ActionName": "logigoig.Controllers.LogController.LogAction (logigoig)",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "5SIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.8105265+04:00",
                    "level": "Information",
                    "messageTemplate": "Executed action {ActionName} in {ElapsedMilliseconds}ms",
                    "message": "Executed action \"logigoig.Controllers.LogController.LogAction (logigoig)\" in 541.8282ms",
                    "fields": {
                        "ActionName": "logigoig.Controllers.LogController.LogAction (logigoig)",
                        "ElapsedMilliseconds": 541.8282,
                        "EventId": {
                            "Id": 105,
                            "Name": "ActionExecuted"
                        },
                        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "5iIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.8115884+04:00",
                    "level": "Information",
                    "messageTemplate": "Executed endpoint '{EndpointName}'",
                    "message": "Executed endpoint '\"logigoig.Controllers.LogController.LogAction (logigoig)\"'",
                    "fields": {
                        "EndpointName": "logigoig.Controllers.LogController.LogAction (logigoig)",
                        "EventId": {
                            "Id": 1,
                            "Name": "ExecutedEndpoint"
                        },
                        "SourceContext": "Microsoft.AspNetCore.Routing.EndpointMiddleware",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "5yIdA5QBP8beIWVyawXD",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:17:25.8127900+04:00",
                    "level": "Information",
                    "messageTemplate": "Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms",
                    "message": "Request finished \"HTTP/1.1\" \"POST\" \"https\"://\"localhost:7261\"\"\"\"/api/log/log\"\"\" - 200 null \"text/plain; charset=utf-8\" 583.4747ms",
                    "fields": {
                        "ElapsedMilliseconds": 583.4747,
                        "StatusCode": 200,
                        "ContentType": "text/plain; charset=utf-8",
                        "ContentLength": null,
                        "Protocol": "HTTP/1.1",
                        "Method": "POST",
                        "Scheme": "https",
                        "Host": "localhost:7261",
                        "PathBase": "",
                        "Path": "/api/log/log",
                        "QueryString": "",
                        "EventId": {
                            "Id": 2
                        },
                        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
                        "RequestId": "0HN95LS71EVSM:00000001",
                        "RequestPath": "/api/log/log",
                        "ConnectionId": "0HN95LS71EVSM"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "uyISA5QBP8beIWVy0wWx",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:05:50.5336702+04:00",
                    "level": "Information",
                    "messageTemplate": "Now listening on: {address}",
                    "message": "Now listening on: \"https://localhost:7261\"",
                    "fields": {
                        "address": "https://localhost:7261",
                        "EventId": {
                            "Id": 14,
                            "Name": "ListeningOnAddress"
                        },
                        "SourceContext": "Microsoft.Hosting.Lifetime"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "vCISA5QBP8beIWVy0wWy",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:05:50.5448346+04:00",
                    "level": "Information",
                    "messageTemplate": "Now listening on: {address}",
                    "message": "Now listening on: \"http://localhost:5288\"",
                    "fields": {
                        "address": "http://localhost:5288",
                        "EventId": {
                            "Id": 14,
                            "Name": "ListeningOnAddress"
                        },
                        "SourceContext": "Microsoft.Hosting.Lifetime"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "vSISA5QBP8beIWVy0wWy",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:05:50.5892209+04:00",
                    "level": "Information",
                    "messageTemplate": "Application started. Press Ctrl+C to shut down.",
                    "message": "Application started. Press Ctrl+C to shut down.",
                    "fields": {
                        "SourceContext": "Microsoft.Hosting.Lifetime"
                    }
                }
            },
            {
                "_index": "user-logs-2024.12.26",
                "_id": "viISA5QBP8beIWVy0wWy",
                "_score": 1.0,
                "_source": {
                    "@timestamp": "2024-12-26T17:05:50.5901620+04:00",
                    "level": "Information",
                    "messageTemplate": "Hosting environment: {EnvName}",
                    "message": "Hosting environment: \"Development\"",
                    "fields": {
                        "EnvName": "Development",
                        "SourceContext": "Microsoft.Hosting.Lifetime"
                    }
                }
            }
        ]
    }
}