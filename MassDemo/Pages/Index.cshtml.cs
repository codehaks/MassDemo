using MassDemo.Models;
using MassDemo.Services;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MassDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRequestClient<NotifyModel> _client;

        [BindProperty]
        public string Message { get; set; }
        private readonly IMessageService _messageService;

        public IndexModel(ILogger<IndexModel> logger, IMessageService messageService, IRequestClient<NotifyModel> client)
        {
            _logger = logger;
            _messageService = messageService;
            _client = client;
        }

        public IActionResult OnPost()
        {
            _client.GetResponse<NotifyResult>(new NotifyModel { UserId = "codehaks", Message = "Welcome to our website!" });
            //_messageService.SendAsync(new Models.NotifyModel { UserId = "codehaks", Message = "Welcome to our website!" });
            return RedirectToPage("Final");
        }
    }
}
