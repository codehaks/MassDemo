using MassDemo.Models;
using MassDemo.Services;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Common
{
    public class NotificationConsumer : IConsumer<NotifyModel>
    {
        private readonly IMessageService _messageService;

        public NotificationConsumer(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Consume(ConsumeContext<NotifyModel> context)
        {
            await _messageService.SendAsync(context.Message);
            await context.RespondAsync<NotifyResult>(new NotifyResult
            {
             Success= true,
             TimeCreated=DateTime.Now
            });
        }
    }
}
