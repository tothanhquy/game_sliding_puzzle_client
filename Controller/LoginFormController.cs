using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_sliding_puzzle.View;
//using Database = game_sliding_puzzle.Model;
//dotnet add package BCrypt.Net-Next
using BCrypt.Net;
using System.Windows.Forms;
using API = game_sliding_puzzle.API;
using Newtonsoft.Json;

namespace game_sliding_puzzle.Controller
{
    public class LoginFormController:Controller
    {
        private LoginFormView view;
        private Router router;

        public LoginFormController(Router router) :base()
        {
            this.router = router;
            //check remember
            //if (checkRemember() == true)
            //{
            //    router.MainFormControllerFlag = true;
            //    return;
            //}

            view = new LoginFormView(this);
            view.ShowDialog();
        }



        private void setSignUpNotification(string status, string noti)
        {
            view.SignUpErrorNotificationStatus = status;
            view.SignUpErrorNotificationText = noti;
        }

        public void signUp()
        {
            try
            {
                setSignUpNotification("info","waiting");

                API.API api = new API.API();

                string userName = view.SignUpTextBoxUserText;
                string pass = view.SignUpTextBoxPasswordText;
                string comfirmPass = view.SignUpTextBoxComfirmPasswordText;

                if (pass != comfirmPass)
                {
                    setSignUpNotification("info", "wrong_password");
                    return;
                }

                string stringParams = "user=" + api.urlEndcode(userName) + "&pass=" + api.urlEndcode(pass);
                string resServerString = api.requestServer("/account/signup", stringParams);
                
                dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                if (resServer.code == -1)
                {
                    //error
                    if (resServer.error == "unvalid_value")
                    {
                        setSignUpNotification("warning", "unvalid_string");
                        return;
                    }
                    else if (resServer.error == "error")
                    {
                        setSignUpNotification("error", "system_error");
                        return;
                    }
                    else if (resServer.error == "same_account")
                    {
                        setSignUpNotification("info", "same_account");
                        return;
                    }
                    else if (resServer.error == "wrong_password")
                    {
                        setSignUpNotification("warning", "wrong_password");
                        return;
                    }
                    else
                    {
                        setSignUpNotification("error", "system_error");
                        return;
                    }
                }
                else
                {
                    //success
                    setSignUpNotification("success", "signup_success");
                    //reset field
                    view.SignUpTextBoxUserText = "";
                    view.SignUpTextBoxPasswordText = "";
                    view.SignUpTextBoxComfirmPasswordText = "";
                }

            }
            catch (Exception err)
            {
                setSignUpNotification("error","system_error");
            }

        }

        private void setSignInNotification(string status, string noti)
        {
            view.SignInErrorNotificationStatus = status;
            view.SignInErrorNotificationText = noti;
        }
        public void signIn()
        {
            try
            {
                setSignInNotification("info","waiting");
                API.API api = new API.API();

                string userName = view.SignInTextBoxUserText;
                string pass = view.SignInTextBoxPasswordText;

                string stringParams = "user=" + api.urlEndcode(userName) + "&pass=" + api.urlEndcode(pass);
                string resServerString = api.requestServer("/account/login", stringParams);
                
                dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                if (resServer.code == -1)
                {
                    //error
                    if (resServer.error == "unvalid_value")
                    {
                        setSignInNotification("warning", "unvalid_string");
                        return;
                    }
                    else if (resServer.error == "error")
                    {
                        setSignInNotification("error", "system_error");
                        return;
                    }
                    else if (resServer.error == "not_exist_account")
                    {
                        setSignInNotification("warning", "not_exist_account");
                        return;
                    }
                    else if (resServer.error == "wrong_password")
                    {
                        setSignInNotification("warning", "wrong_password");
                        return;
                    }else
                    {
                        setSignInNotification("error", "system_error");
                        return;
                    }
                }
                else
                {
                    //success
                    setCookie(userName, "" + resServer.data.access_token);
                    setSignInNotification("success", "signin_success");
                    // open menu form
                    router.MainFormControllerFlag = true;
                    view.Close();
                }

            }
            catch(Exception err)
            {
                setSignInNotification("error","system_error");
            }
        }
    }
    
}
