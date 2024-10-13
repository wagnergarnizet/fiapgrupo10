using Microsoft.Extensions.Logging;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Logging
{
    public class CustomLoggerProviderConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public int EventId { get; set; } = 0;
    }
}