using MassDemo.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Services
{
    public interface IMessageService
    {
        Task SendAsync(NotifyModel notify);
    }

    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;

        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
        }

        public async Task SendAsync(NotifyModel notify)
        {
            await Task.Delay(1000);
            //throw new InvalidOperationException("Not working!");
            _logger.LogInformation(notify.Message + " -> [sent]");
        }
    }
}
