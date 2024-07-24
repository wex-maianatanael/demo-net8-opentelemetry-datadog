using System.Diagnostics;

namespace Demo.Api
{
    public class DiagnosticsConfig
    {
        public const string ServiceName = "opentelemetry-demo";
        public static ActivitySource ActivitySource = new(ServiceName);
    }
}
