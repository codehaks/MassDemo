using MassDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MassDemo.Common
{
    public class MessageBus
    {
        public class NotifyModel:INotification
        {
            public string UserId { get; set; }
            public string Message { get; set; }
        }

        public class MessageHandler : INotificationHandler<NotifyModel>
        {
            private readonly IMessageService _messageService;

            public MessageHandler(IMessageService messageService)
            {
                _messageService = messageService;
            }

            public async Task Handle(NotifyModel notification, CancellationToken cancellationToken)
            {
                await _messageService.SendAsync($" {notification.UserId} says '{notification.Message}' ");

            }
        }
    }
}
