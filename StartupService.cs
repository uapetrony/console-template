﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace TemplateApp
{
    public class StartupService : IStartup
    {
        private readonly ILogger<StartupService> _logger;
        private readonly IConfiguration _config;

        public StartupService(ILogger<StartupService> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void Run()
        {
            _logger.LogInformation("Application started");

            Console.WriteLine("Press Ctrl + C to stop the application");

            while (true)
            {
            }
        }
    }
}
