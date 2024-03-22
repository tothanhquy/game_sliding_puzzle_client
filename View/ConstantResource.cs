using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sliding_puzzle.View
{
    public class ConstantResource
    {
        
        public class ForeColorStatus
        {
            public static System.Drawing.Color getColorFromStatus(string status)
            {
                if (status == "info")
                {
                    return INFO;
                }else if (status == "warning")
                {
                    return WARNING;
                }
                else if (status == "success")
                {
                    return SUCCESS;
                }
                else{
                    return ERROR;
                }
                
            }
            public static System.Drawing.Color INFO = System.Drawing.Color.MediumTurquoise;
            public static System.Drawing.Color WARNING = System.Drawing.Color.Coral;
            public static System.Drawing.Color ERROR = System.Drawing.Color.Red;
            public static System.Drawing.Color SUCCESS = System.Drawing.Color.Green;
        }
        public class LoginFormResponseString
        {
            public static string getStringFromResponse(string response)
            {
                if (response == "signin_success")
                {
                    return SIGNIN_SUCCESS;
                }
                else if (response == "empty")
                {
                    return WAITING;
                }
                else if (response == "waiting")
                {
                    return WAITING;
                }
                else if(response == "not_same_password")
                {
                    return NOT_SAME_COMFIRM_PASSWORD;
                }
                else if(response == "unvalid_string")
                {
                    return UNVALID_STRING;
                }
                else if(response == "system_error")
                {
                    return SYSTEM_ERROR;
                }
                else if(response == "same_account")
                {
                    return SAME_ACCOUNT;
                }
                else if(response == "signup_success")
                {
                    return SIGNUP_SUCCESS;
                }
                else if(response == "not_exist_account")
                {
                    return NOT_EXIST_ACCOUNT;
                }
                else if(response == "wrong_password")
                {
                    return WRONG_PASSWORD;
                }
                else
                {
                    return EMPTY;
                }

            }
            public static string EMPTY = "";
            public static string WAITING = "Chờ xíu ...";
            public static string NOT_SAME_COMFIRM_PASSWORD = "Mật khẩu không trùng!";
            public static string UNVALID_STRING = "Chuỗi không hợp lệ!";
            public static string SYSTEM_ERROR = "Lỗi hệ thống!";
            public static string SAME_ACCOUNT = "Tài khoản bị trùng!";
            public static string SIGNUP_SUCCESS = "Đăng ký thành công.";
            public static string NOT_EXIST_ACCOUNT = "Tài khoản không tồn tại.";
            public static string WRONG_PASSWORD = "Sai mật khẩu.";
            public static string SIGNIN_SUCCESS = "Đăng nhập thành công.";
            
        }
        public class ChangePasswordFormMessageString
        {
            public static string getStringFromResponse(string response)
            {
                if (response == "not_same_password")
                {
                    return NOT_SAME_COMFIRM_PASSWORD;
                }
                else if (response == "unvalid_string")
                {
                    return UNVALID_STRING;
                }
                else if (response == "system_error")
                {
                    return SYSTEM_ERROR;
                }
                else if (response == "change_success")
                {
                    return CHANGE_SUCCESS;
                }
                else if (response == "not_login")
                {
                    return NOT_LOGIN;
                }
                else if (response == "wrong_password")
                {
                    return WRONG_PASSWORD;
                }
                else if (response == "waiting")
                {
                    return WAITING;
                }
                else
                {
                    return EMPTY;
                }

            }
            public static string EMPTY = "";
            public static string NOT_SAME_COMFIRM_PASSWORD = "Lặp lại mật khẩu mới không trùng!";
            public static string UNVALID_STRING = "Chuỗi không hợp lệ!";
            public static string SYSTEM_ERROR = "Lỗi hệ thống!";
            public static string NOT_LOGIN = "Bạn đã bị đăng xuất.";
            public static string WRONG_PASSWORD = "Sai mật khẩu.";
            public static string CHANGE_SUCCESS = "Thay đổi thành công.";
            public static string WAITING = "Chờ xíu...";
        }
        public class MainFormChartItem
        {
            public string userName;
            public int timeSec;
            public MainFormChartItem()
            {
            }
            public MainFormChartItem(string userName, int timeSec)
            {
                this.userName = userName;
                this.timeSec = timeSec;
            }
            //public static string convertTimeSec(string timeSec)
            //{
            //    return timeSec;
            //}
            public static string convertTimeSec(int timeSec)
            {
                int min = timeSec / 60;
                int sec = timeSec % 60;
                int hour = min / 60;
                min = min % 60;
                string res = string.Format("{0:00}", sec);
                res = string.Format("{0:00}", min) + ":"+ res;
                if (hour != 0)
                {
                    res = hour +":" +res;
                }
                return res;
            }

        }
        public class PlayFormImageItem
        {
            public int id;
            public int index;
            public Image image;
        }
    
    }
}
