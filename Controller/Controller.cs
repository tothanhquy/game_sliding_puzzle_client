using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Package = game_sliding_puzzle.API;

namespace game_sliding_puzzle.Controller
{
    public class Controller
    {
        public bool getCookie(ref string userName, ref string accessToken)
        {
            try
            {
                var path = Path.GetDirectoryName(Application.ExecutablePath)+ "\\Cookie.txt";
                string text = File.ReadAllText(path);
                var arr = text.Split(' ');
                userName = arr[0];
                accessToken = arr[1];
                return true;
            }catch(Exception err)
            {
                return false;
            }
        }
        public bool setCookie(string userName, string accessToken)
        {
            try
            {
                var path = Path.GetDirectoryName(Application.ExecutablePath) + "\\Cookie.txt";
                File.WriteAllText(path, userName + " " + accessToken);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        
        public int[] convertJArrayToArray(string arr)
        {
            arr = arr.Replace("[", string.Empty);
            arr = arr.Replace("]", string.Empty);
            string[] split = arr.Split(',');
            int[] res = new int[split.Length];
            for(int i = 0; i < res.Length; i++)
            {
                MessageBox.Show(split[i]);
                res[i] = int.Parse(split[i]);
            }
            return res;
        }
        public Controller()
        {

        }
    }
}
