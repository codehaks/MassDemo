using MassDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Message { get; set; }
        private readonly IMessageService _messageService;

        public IndexModel(ILogger<IndexModel> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public async Task<IActionResult> OnPost()
        {
            await _messageService.SendSMSAsync(Message);
            await _messageService.SendEmailAsync(Message);
            await _messageService.SendNotificationAsync(Message);

            return RedirectToPage("Final");
        }
    }
}
