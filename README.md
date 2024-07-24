# demo-net8-opentelemetry-datadog
Demonstrates how to send telemetry data to Datadog by using OTLP exporter

## How to run it

> [!NOTE]  
> _You must ask the api key (datadog agent) to devops before starting the tests, otherwise you'll not be able to send logs._

> [!IMPORTANT]  
> _When you get the api key, add it in the `docker-compose.yaml` file._

1. Run the `docker-compose up -d` command in order to setup the datadog agent
2. Run the api using the `http` profile
3. Send requests to the API using swagger
4. Open Datadog service (via okta tile), select the env `bf-demo` and navigate to the `demo-opentelemetry-bf-team` service
5. Check the metrics and tracing data!

## Commit history

> [!WARNING]  
> _The current version is sending logs to the console but not to Datadog. It's a pending fix._

| Commit hash | Link | Description |
| :--- | :--- | :--- |
| `70650ff20673ba830aee45dd807934c54d744cc4` | 🔗[Code](https://github.com/wex-maianatanael/demo-net8-opentelemetry-datadog/commit/70650ff20673ba830aee45dd807934c54d744cc4) | Adds otel collector. |

## External References

- Datadog Official doc 📚
  - [Getting Started with OpenTelemetry at Datadog](https://docs.datadoghq.com/getting_started/opentelemetry/)
  - [OpenTelemetry Collector and Datadog Exporter](https://docs.datadoghq.com/opentelemetry/collector_exporter/)
  - [Azure Container Apps - env vars](https://docs.datadoghq.com/serverless/azure_container_apps/#environment-variables)
  - [.NET Logs and Traces](https://docs.datadoghq.com/tracing/other_telemetry/connect_logs_and_traces/dotnet/?tab=serilog)
  - [Tracing Docker Applications](https://docs.datadoghq.com/containers/docker/apm/?tab=linux)
  - [Getting Started with the Agent](https://docs.datadoghq.com/getting_started/agent/#about-the-agent)

- OpenTemetry Official doc 🔭
  - [Getting Started OpenTelemetry + .NET](https://opentelemetry.io/docs/languages/net/)
  - [Collector configuration](https://opentelemetry.io/docs/collector/configuration/#basics)
  - [Logs](https://opentelemetry.io/docs/specs/otel/logs/)
  - [Metrics](https://opentelemetry.io/docs/specs/otel/metrics/)
  - [Traces](https://opentelemetry.io/docs/specs/otel/trace/)
 
- GitHub Repos :octocat:
  - [opentelemetry-collector-contrib](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main)
    - [Datadog exporter - collector](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/datadogexporter/examples/collector.yaml)
    - [Datadog exporter - otlp](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/datadogexporter/examples/otlp.yaml)
    - [Datadog exporter - logs](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/datadogexporter/examples/logs.yaml)
    - [Datadog exporter - traces/metrics](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/datadogexporter/examples/trace-metrics.yaml)
    - [Datadog exporter - examples](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/exporter/datadogexporter/examples)

- Microsoft Official doc 💻
  - [.NET observability with OpenTelemetry](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/observability-with-otel)

- Blog posts 📰
  - [Medium - Setting up an OpenTelemetry collector that exports to DataDog](https://medium.com/@gerardyin/setting-up-an-opentelemetry-collector-that-exports-to-datadog-cb5d5dceadb7)
  - [Nash Tech. - Working with Datadog + Opentelemetry in .Net Application (datadog docker agent)](https://blog.nashtechglobal.com/working-with-datadog-opentelemetry-in-net-application/)
