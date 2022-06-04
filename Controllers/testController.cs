using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BanSach.Models;
using System.Text.RegularExpressions;
using System.Text;

namespace BanSach.Controllers
{
    public class testController : Controller
    {
        private readonly ILogger<testController> _logger;

        public testController(ILogger<testController> logger)
        {
            _logger = logger;
        }

        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(' ', '-').ToLower();
        }

    }
}