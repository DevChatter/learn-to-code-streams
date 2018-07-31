using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _2018_07_28.Pages
{
    public class IndexModel : PageModel
    {
        public static int Count = 0;
        public int OtherCount = 0;
        public DateTime CurrentTime { get; set; }
        public string MyMessage { get; set; }

        public void OnGet()
        {
            // Runs when someone requests my page

            CurrentTime = DateTime.Now;

            MyMessage = "This is a message from me to you!";

            Count += 1;
            OtherCount += 1;
        }
    }
}
