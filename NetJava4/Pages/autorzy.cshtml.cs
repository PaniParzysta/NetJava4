﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetJava4.Pages
{
    public class autorzyModel : PageModel
    {
        private readonly ILogger<autorzyModel> _logger;

        public autorzyModel(ILogger<autorzyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}