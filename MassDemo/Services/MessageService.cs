using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Services
{
    public interface IMessageService
    {
        Task SendSMSAsync(string message);
        Task SendEmailAsync(string message);
        Task SendNotificationAsync(string message);
    }

    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;

        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
        }

        public async Task SendSMSAsync(string message)
        {
            await Task.Delay(5000);
            _logger.LogInformation(message + " -> [SMS Sent]");
        }

        public async Task SendEmailAsync(string message)
        {
            await Task.Delay(5000);
            _logger.LogInformation(message + " -> [Email Sent]");
        }

        public async Task SendNotificationAsync(string message)
        {
            await Task.Delay(5000);
            _logger.LogInformation(message + " -> [Notification Sent]");
        }
    }
}
