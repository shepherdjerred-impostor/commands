using System.Threading.Tasks;
using Impostor.Api.Plugins;
using Microsoft.Extensions.Logging;

namespace Commands.ShepherdJerred
{
    [ImpostorPlugin(
        "com.shepherdjerred",
        "Commands",
        "Jerred Shepherd",
        "1.0.0")]
    // ReSharper disable once UnusedType.Global
    public class Main : PluginBase
    {
        private readonly ILogger<Main> _logger;

        public Main(ILogger<Main> logger)
        {
            _logger = logger;
        }

        public override ValueTask EnableAsync()
        {
            _logger.LogInformation("Example is being enabled.");
            return default;
        }

        public override ValueTask DisableAsync()
        {
            _logger.LogInformation("Example is being disabled.");
            return default;
        }
    }
}
