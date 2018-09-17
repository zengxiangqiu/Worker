using CaptchaRecogition;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoApplyForWorker
{
    class ImageCheck
    {
        private int noiseThreshold = 1;
        private int minWidth = 8;
        private bool isFourChars = false;
        private int graytype = 2;

        public bool Download(Worker worker)
        {
            var uri = "http://210.76.66.109:7006/gdweb/ImageCheck.jpg";
            var httpHandler = new HttpClientHandler { CookieContainer = worker.CookieContainer };
            using (var client = new HttpClient(httpHandler))
            {
                if (!Directory.Exists(worker.Username))
                    Directory.CreateDirectory(worker.Username);
                var filename = worker.Username + "\\ImageCheck" + worker.ID + ".jpg";
                //cookieContainer.Add(new Uri(uri), new Cookie("token", "532143538"));
                //Token: 2003070722
                ReadAsFileAsync(client.GetAsync(uri).Result.Content, filename, true).Wait();
                return File.Exists(filename);
            }
        }

        public string GetCode(Worker worker)
        {
            Image img2 = Image.FromFile(worker.Username + "\\ImageCheck" + worker.ID + ".jpg");
            string sb = ImageProcess.GetYZMCode(img2, worker.Username + "\\zimo.txt", noiseThreshold, 20, 30, graytype, isFourChars, minWidth);
            img2.Dispose();
            if (sb.Length > 4)
                return sb.Substring(0, 4);
            else
                return sb;
        }

        public static Task ReadAsFileAsync(HttpContent content, string filename, bool overwrite)
        {
            if (!overwrite && File.Exists(filename))
            {
                throw new InvalidOperationException(string.Format("File {0} already exists.", filename));
            }
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
                return content.CopyToAsync(fileStream).ContinueWith(
                    (copyTask) =>
                    {
                        fileStream.Close();
                    });
            }
            catch
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                    string pathname = Path.GetFullPath(filename);
                }
                Console.WriteLine("Exception in ReadAsFileAsync");
                throw;
            }
        }
    }
}
