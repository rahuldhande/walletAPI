using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WalletAPI.Models
{
    public class SuccessResponse
    {
        public string Message { get; set; }
        public string InnerException { get; set; }
    }
}