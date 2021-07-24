using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Services
{
    public interface IMessageService
    {
        Task SendAsync(string message);
    }

    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;

        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
        }

        public async Task SendAsync(string message)
        {
            // Send SMS
            await Task.Delay(1000);
 
            _logger.LogInformation(message + " -> [sent]");
        }
    }
}
