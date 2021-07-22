using MassDemo.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MassDemo.Common.MessageBus;

namespace MassDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Message { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost([FromServices]IMediator mediator)
        {
            mediator.Publish(new NotifyModel { UserId = "codehaks", Message = "Welcome to channel!" });
            return RedirectToPage("Final");
        }
    }
}
