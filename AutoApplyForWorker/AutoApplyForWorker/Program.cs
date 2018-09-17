using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using CaptchaRecogition;
using System.Drawing;
using CsQuery;
using Mono.Web;

namespace AutoApplyForWorker
{
    class Program
    {
        static string applicant = "wuyanmei808";

        static void Main(string[] args)
        {
            var worker = new Worker {
                ID = "0",
                CookieContainer = new CookieContainer(),
                Token = "",
                Username = applicant
            };
            if (worker.Login())
            {
                worker.Apply();
            }
        }
        
    }
}
