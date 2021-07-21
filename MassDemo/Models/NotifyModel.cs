using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassDemo.Models
{
    public class NotifyModel
    {
        public string UserId { get; set; }
        public string Message { get; set; }
    }

    public class NotifyResult
    {
        public DateTime TimeCreated { get; set; }
        public bool Success { get; set; }
    }
}
