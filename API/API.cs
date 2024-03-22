using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace game_sliding_puzzle.API
{
    public class API
    {
        private const string API_SERVER = "https://calm-gold-codfish-sari.cyclic.app";
        //private const string API_SERVER = "localhost:3000";
        WebClient webClient = new WebClient();
        public string requestServer(string router, string stringParams)
        {
            try
            {
                string res = webClient.UploadString(API_SERVER + router, "POST", stringParams);
                return res;
            }catch(Exception err)
            {
                return null;
            }
        }
        public string urlEndcode(string str)
        {
            return HttpUtility.UrlEncode(str);
        }
        public bool downloadImage(string url, string path)
        {
            try
            {
                webClient.DownloadFile(new Uri(API_SERVER+url), path);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        public API() {
            webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        }
    }
}
