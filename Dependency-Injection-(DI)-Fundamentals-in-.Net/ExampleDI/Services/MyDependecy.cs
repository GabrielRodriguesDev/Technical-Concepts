using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleDI.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ExampleDI.Services
{
    public class MyDependecy : IMyDependecy
    {
        private readonly ILogger<MyDependecy> _logger;

        public MyDependecy(ILogger<MyDependecy> logger)
        {
            this._logger = logger;
        }
        public void WriteMessage(string message)
        {
            this._logger.LogInformation($"MyDependency.WriteMessage Message: {message}");
        }
    }
}
