using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_sliding_puzzle.API;
using Newtonsoft.Json;

namespace game_sliding_puzzle.Controller
{
    class ChangePasswordFormController:Controller
    {
        public ChangePasswordFormController():base() { }

        public string changePassword(string oldPassword, string newPassword, string comfirmNewPassword)
        {
            string resFunc = "error";
            try
            {
                try
                {
                    API.API api = new API.API();
                    string rememberUser = "";
                    string rememberAccessToken = "";
                    if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                    {
                        //not remember
                        resFunc = "not_login";
                    }
                    else
                    if (newPassword != comfirmNewPassword)
                    {
                        resFunc = "not_same_password";
                    }else
                    {
                        string stringParams =
                            "rememberUserName=" + api.urlEndcode(rememberUser) +
                            "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken) +
                            "&oldPassword=" + api.urlEndcode(oldPassword) +
                            "&newPassword=" + api.urlEndcode(newPassword);
                        string resServerString = api.requestServer("/account/change_password", stringParams);
                        dynamic resServer = JsonConvert.DeserializeObject(resServerString);
                        if (resServer.code == -1)
                        {
                            //error
                            if (resServer.error == "not_login")
                            {
                                resFunc = "not_login";
                            }
                            else if (resServer.error == "error")
                            {
                                resFunc = "error";
                            }
                            else if (resServer.error == "wrong_password")
                            {
                                resFunc = "wrong_password";
                            }
                            else if (resServer.error == "not_exist_account")
                            {
                                resFunc = "not_login";
                            }
                            else if (resServer.error == "unvalid_value")
                            {
                                resFunc = "unvalid_string";
                            }
                            else
                            {
                                resFunc = "error";
                            }
                        }
                        else
                        {
                            //success
                            resFunc = "change_success";
                        }
                    }
                }
                catch (Exception err)
                {
                    resFunc = "error";
                }
            }catch(Exception err)
            {
                resFunc = "error";
            }
            return resFunc;
        }
    }
}
