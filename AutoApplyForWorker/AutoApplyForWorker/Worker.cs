using CsQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoApplyForWorker
{
    class Worker : ApplyInterface
    {
        public CookieContainer CookieContainer { get;  set; }
        public string Username { get;  set; }
        public string ID { get;  set; }
        public string Token { get;  set; }
        private ImageCheck imageCheck = new ImageCheck();

        public void Apply()
        {
            imageCheck.Download(this);
            var uri = "http://210.76.66.109:7006/gdweb/ajaxAdapter.do";
            using (var client = new HttpClient(new HttpClientHandler { CookieContainer = this.CookieContainer }))
            {
                client.DefaultRequestHeaders.Add("Token", this.Token);
                client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

                var imageCode = imageCheck.GetCode(this);
                //var imagecheck = "kkkk";
                var content = new FormUrlEncodedContent(new[] {
                #region
   //                 parameters: % 5B % 7B % 22serviceId % 22 % 3A % 22btxxService % 22 % 2C % 22method % 22 % 3A % 22submitBtxx % 22 % 2C % 22parameters % 22 % 3A % 7B % 22AAC003 % 22 % 3A % 22 % E9 % 82 % AC % E8 % 89 % B3 % E5 % AA % 9A % 22 % 2C % 22AAC147 % 22 % 3A % 2244182619840820176X % 22 % 2C % 22BCC905 % 22 % 3A % 22440100 % 22 % 2C % 22BCC902 % 22 % 3A % 2295588 % 22 % 2C % 22BCC903 % 22 % 3A % 226222033602001353232 % 22 % 2C % 22BOE531 % 22 % 3A % 2201 % 22 % 2C % 22AAC058 % 22 % 3A % 2201 % 22 % 2C % 22BOD215 % 22 % 3A % 22440106 % 22 % 2C % 22AAC012 % 22 % 3A % 2217 % 22 % 2C % 22_multiple % 22 % 3A % 5B % 22 % 22 % 2C % 22 % 22 % 5D % 2C % 22BBD131 % 22 % 3A % 222018 % 22 % 2C % 22AAB080 % 22 % 3A % 222018 - 07 - 08 % 22 % 2C % 22BCC864NAME % 22 % 3A % 22 % E5 % B9 % BF % E4 % B8 % 9C % E7 % 9C % 81 % E5 % B9 % BF % E5 % B7 % 9E % E5 % B8 % 82 % E5 % A4 % A9 % E6 % B2 % B3 % E5 % 8C % BA % 22 % 2C % 22BCC890 % 22 % 3A % 22 % 22 % 2C % 22BCC866 % 22 % 3A % 2201 % 22 % 2C % 22BHE034 % 22 % 3A % 2201 % 22 % 2C % 22BCC867NAME % 22 % 3A % 22 % E7 % 94 % B5 % E5 % AD % 90 % E5 % 95 % 86 % E5 % 8A % A1 % E5 % B8 % 88 % 22 % 2C % 22BHB322 % 22 % 3A % 22 % 22 % 2C % 22CCE029 % 22 % 3A % 223 % 22 % 2C % 22BHE271 % 22 % 3A % 22 % E5 % B9 % BF % E5 % B7 % 9E % E5 % B8 % 82 % E8 % 81 % 8C % E4 % B8 % 9A % E6 % 8A % 80 % E8 % 83 % BD % E9 % 89 % B4 % E5 % AE % 9A % E6 % 8C % 87 % E5 % AF % BC % E4 % B8 % AD % E5 % BF % 83 % 22 % 2C % 22BCC290 % 22 % 3A % 221719010000320189 % 22 % 2C % 22BCC868 % 22 % 3A % 222017 - 12 - 13 % 22 % 2C % 22BCC865 % 22 % 3A % 2201 % 22 % 2C % 22BCC901 % 22 % 3A % 22 % E5 % B9 % BF % E4 % B8 % 9C % E4 % B8 % AD % E9 % B9 % 8F % E8 % 81 % 8C % E4 % B8 % 9A % E5 % 9F % B9 % E8 % AE % AD % E5 % AD % A6 % E6 % A0 % A1 % 22 % 2C % 22BCC870 % 22 % 3A % 220 % 22 % 2C % 22BCA060 % 22 % 3A % 222800 % 22 % 2C % 22BCC229 % 22 % 3A % 220 % 22 % 2C % 22ZJ % 22 % 3A % 222800 % 22 % 2C % 22SYZBS % 22 % 3A % 221 % 22 % 2C % 22AAE013 % 22 % 3A % 22 % 22 % 2C % 22BCC864 % 22 % 3A % 22440106 % 22 % 2C % 22BCC867 % 22 % 3A % 22H499000100 % 22 % 2C % 22ZSBAE001 % 22 % 3A % 22 % 22 % 2C % 22BCEA6Z % 22 % 3A % 22 % 22 % 2C % 22BHB321 % 22 % 3A % 22 % 22 % 2C % 22AAC067 % 22 % 3A % 2213763364814 % 22 % 2C % 22BDCZ56 % 22 % 3A % 22 % 22 % 2C % 22BDCZ59 % 22 % 3A % 22 % 22 % 2C % 22BAE001 % 22 % 3A % 22null % 22 % 2C % 22BAE002 % 22 % 3A % 22744781 % 22 % 2C % 22BAE003 % 22 % 3A % 222018 - 07 - 08 % 22 % 2C % 22BAE004 % 22 % 3A % 22744781 % 22 % 2C % 22BAE005 % 22 % 3A % 222018 - 07 - 08 % 22 % 2C % 22BAE006 % 22 % 3A % 22null % 22 % 2C % 22BCC857 % 22 % 3A % 222860085 % 22 % 2C % 22BCC859 % 22 % 3A % 221823865 % 22 % 2C % 22LOGINIDJM % 22 % 3A % 22wuyanmei808 % 22 % 2C % 22BCC869 % 22 % 3A % 222800 % 22 % 2C % 22BCC871 % 22 % 3A % 220 % 22 % 2C % 22BCC856 % 22 % 3A % 22 % 22 % 2C % 22readOnly % 22 % 3A % 22 % 22 % 2C % 22GZ_XZQH % 22 % 3A % 22 % 22 % 2C % 22ACC560 % 22 % 3A % 22 % 22 % 2C % 22edit % 22 % 3A % 22true % 22 % 2C % 22isLackOfIndicators % 22 % 3A % 22false % 22 % 2C % 22vcode % 22 % 3A % 22KAND % 22 % 2C % 22_DIC_BCC905 % 22 % 3A % 22 % E5 % B9 % BF % E4 % B8 % 9C % E7 % 9C % 81 % E5 % B9 % BF % E5 % B7 % 9E % E5 % B8 % 82 % 22 % 2C % 22_DIC_BCC902 % 22 % 3A % 22 % E5 % B7 % A5 % E5 % 95 % 86 % E9 % 93 % B6 % E8 % A1 % 8C % 22 % 2C % 22_DIC_BCC866 % 22 % 3A % 22 % E5 % 9C % A8 % E8 % 81 % 8C % 22 % 2C % 22_DIC_BHE034 % 22 % 3A % 22 % E5 % 9B % BD % E5 % AE % B6 % E8 % 81 % 8C % E4 % B8 % 9A % E8 % B5 % 84 % E6 % A0 % BC % E8 % AF % 81 % E4 % B9 % A6 % 22 % 2C % 22_DIC_CCE029 % 22 % 3A % 22 % E9 % AB % 98 % E7 % BA % A7 % E5 % B7 % A5 % 2F % E4 % B8 % 89 % E7 % BA % A7 % 22 % 2C % 22_DIC_BCC865 % 22 % 3A % 22 % E5 % 8F % 82 % E5 % 8A % A0 % E5 % 9F % B9 % E8 % AE % AD % 22 % 2C % 22_DIC_BCC870 % 22 % 3A % 22 % E5 % 90 % A6 % 22 % 7D % 7D % 5D
   //shareArguments: % 7B % 7D
                    #endregion
                new KeyValuePair<string,string>("parameters","[{\"serviceId\":\"btxxService\",\"method\":\"submitBtxx\",\"parameters\":{\"AAC003\":\"邬艳媚\",\"AAC147\":\"44182619840820176X\",\"BCC905\":\"440100\",\"BCC902\":\"95588\",\"BCC903\":\"6222033602001353232\",\"BOE531\":\"01\",\"AAC058\":\"01\",\"BOD215\":\"440106\",\"AAC012\":\"17\",\"_multiple\":[\"\",\"\"],\"BBD131\":\"2018\",\"AAB080\":\"2018-07-08\",\"BCC864NAME\":\"广东省广州市天河区\",\"BCC890\":\"\",\"BCC866\":\"01\",\"BHE034\":\"01\",\"BCC867NAME\":\"电子商务师\",\"BHB322\":\"\",\"CCE029\":\"3\",\"BHE271\":\"广州市职业技能鉴定指导中心\",\"BCC290\":\"1719010000320189\",\"BCC868\":\"2017-12-13\",\"BCC865\":\"01\",\"BCC901\":\"广东中鹏职业培训学校\",\"BCC870\":\"0\",\"BCA060\":\"2800\",\"BCC229\":\"0\",\"ZJ\":\"2800\",\"SYZBS\":\"1\",\"AAE013\":\"\",\"BCC864\":\"440106\",\"BCC867\":\"H499000100\",\"ZSBAE001\":\"\",\"BCEA6Z\":\"\",\"BHB321\":\"\",\"AAC067\":\"13763364814\",\"BDCZ56\":\"\",\"BDCZ59\":\"\",\"BAE001\":\"null\",\"BAE002\":\"744781\",\"BAE003\":\"2018-07-08\",\"BAE004\":\"744781\",\"BAE005\":\"2018-07-08\",\"BAE006\":\"null\",\"BCC857\":\"2860085\",\"BCC859\":\"1823865\",\"LOGINIDJM\":\"wuyanmei808\",\"BCC869\":\"2800\",\"BCC871\":\"0\",\"BCC856\":\"\",\"readOnly\":\"\",\"GZ_XZQH\":\"\",\"ACC560\":\"\",\"edit\":\"true\",\"isLackOfIndicators\":\"false\",\"vcode\":"+"\""+imageCode+"\""+",\"_DIC_BCC905\":\"广东省广州市\",\"_DIC_BCC902\":\"工商银行\",\"_DIC_BCC866\":\"在职\",\"_DIC_BHE034\":\"国家职业资格证书\",\"_DIC_CCE029\":\"高级工/三级\",\"_DIC_BCC865\":\"参加培训\",\"_DIC_BCC870\":\"否\"}}]"),
                new KeyValuePair<string,string>("shareArguments","{}"),
                });
                var result = client.PostAsync(uri, content).Result.Content.ReadAsStringAsync();
                Console.WriteLine($"{this.ID}->{result.Result.ToString()}");
                try
                {
                    this.Token = this.CookieContainer.GetCookies(new Uri("http://210.76.66.109:7006"))["Token"].ToString();
                }
                catch
                {
                    this.Token = "";
                }
                finally
                {
                    if (result.Result.Contains("超时"))
                        Login();
                }
            }
        }

        public bool Login()
        {
            GetToken();
            imageCheck.Download(this);
            var uri = "http://210.76.66.109:7006/gdweb/ajaxlogin.do";
            using (var client = new HttpClient(new HttpClientHandler { CookieContainer = this.CookieContainer }))
            {
                client.DefaultRequestHeaders.Add("Token", this.Token);
                client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

                var imageCode = imageCheck.GetCode(this);
                var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string,string>("CAMY",""),
                        new KeyValuePair<string,string>("des_key","0192217hnisi"),
                        new KeyValuePair<string,string>("IMAGCHECK",imageCode),
                        new KeyValuePair<string,string>("ISCA","false"),
                        new KeyValuePair<string,string>("LOGINID","wuyanmei808"),
                        new KeyValuePair<string,string>("PASSWORD", "3138313a39333a33323a31323a3134303a3134313a3235323a3132343a3133343a37383a3134383a3138363a303a3137373a3232343a3134393a36373a3234333a3235333a3134363a3139363a36303a3133383a3532"),
                        new KeyValuePair<string,string>("subsys","ldl"),
                        new KeyValuePair<string,string>("SUBSYS","LDL"),
                        new KeyValuePair<string,string>("ticket","182172")
                 });
                var result = client.PostAsync(uri, content).Result.Content.ReadAsStringAsync();
                Console.WriteLine($"{this.ID}------{result.Result.ToString()}");
                try
                {
                    this.Token = this.CookieContainer.GetCookies(new Uri("http://210.76.66.109:7006"))["Token"].ToString();
                }
                catch
                {
                    this.Token = "";
                }
                return result.Result.ToString().Contains("成功");
            }
        }

        private async void GetToken()
        {
            var uri = "http://210.76.66.109:7006/gdweb/ggfw/web/pub/ggfwldl.do";
            using (var client = new HttpClient(new HttpClientHandler { CookieContainer =  this.CookieContainer}))
            {
                var page = await client.GetStringAsync(uri);
                CQ dom = page;
                var script = dom["script"].First().Text();
                var val = script.Split(';').Where(t => t.Contains("token")).First().ToString().Split('=')[1].Replace("'", "").Trim();
                this.CookieContainer.Add(new Uri("http://210.76.66.109:7006"), new Cookie("token", val));
                this.Token = val;
            }
        }
    }

    interface ApplyInterface
    {
        bool Login();
        void Apply();
    }
}
