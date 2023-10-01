using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FolderCleaningService
{
    internal class FolderClearningService : BackgroundService
    {
        private readonly ILogger<FolderClearningService> _logger;
        private readonly IConfiguration _configurations;

        public FolderClearningService(ILogger<FolderClearningService> logger, IConfiguration configurations)
        {
            _logger = logger;
            _configurations = configurations;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var folderPath = _configurations.GetValue<string>("FolderPath");
                    var clearningInterval = _configurations.GetValue<int>("CleaningIntervalSeconds");

                    ArgumentNullException.ThrowIfNull(nameof(folderPath));

                    _logger.LogInformation("Clearning process started");

                    var directory = new DirectoryInfo(folderPath);


                    foreach (var file in directory.GetFiles())
                    {
                        file.Delete();
                    }

                    foreach (var folder in directory.GetDirectories())
                    {
                        folder.Delete(true);
                    }

                    _logger.LogInformation("Clearning process ended");

                    await Task.Delay(TimeSpan.FromSeconds(clearningInterval));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                Environment.Exit(1);
            }
        }
    }
}
