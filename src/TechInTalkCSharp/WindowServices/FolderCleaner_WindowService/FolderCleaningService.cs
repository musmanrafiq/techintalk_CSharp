using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FolderCleaner_WindowService
{
    public sealed class FolderCleaningService : BackgroundService
    {
        private readonly ILogger<FolderCleaningService> _logger;
        private readonly IConfiguration _configuration;

        public FolderCleaningService(
            ILogger<FolderCleaningService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var folderPath = _configuration.GetValue<string>("FolderPath");
                    ArgumentException.ThrowIfNullOrEmpty(folderPath, nameof(folderPath));
                    _logger.LogWarning($"Warning {DateTime.Now}");
                    _logger.LogDebug($"Debug {DateTime.Now}");
                    _logger.LogTrace($"Trace {DateTime.Now}");
                    _logger.LogCritical($"Critical {DateTime.Now}");
                    _logger.LogError($"Error {DateTime.Now}");


                    _logger.LogInformation($"Deletion started at {DateTime.Now}");


                    DirectoryInfo di = new DirectoryInfo(folderPath);

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }

                    _logger.LogInformation($"Deletion ended at {DateTime.Now}");

                    await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

                }
            }
            catch (TaskCanceledException)
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Message}", ex.Message);
                Environment.Exit(1);
            }
        }
    }
}