using System;

namespace Extensibility
{
    class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            // Some Code Here
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
