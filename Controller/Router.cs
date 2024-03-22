using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sliding_puzzle.Controller
{
    public class DataForPlayForm
    {
        public int level;
        public bool continuePreviousGame;
        public DataForPlayForm(int level,bool continuePreviousGame) {
            this.level = level;
            this.continuePreviousGame = continuePreviousGame;
        }
        public DataForPlayForm()
        {
        }
    }
    public class Router
    {
        //start controller
        private bool loginFormControllerFlag = false;

        private bool mainFormControllerFlag = true;

        private bool playFormControllerFlag = false;
        public DataForPlayForm dataForPlayForm;

        public bool LoginFormControllerFlag {
            set{
                resetAllForm();
                loginFormControllerFlag = value;
            } 
        }
        public bool MainFormControllerFlag
        {
            set{
                resetAllForm();
                mainFormControllerFlag = value;
            } 
        }
        public bool PlayFormControllerFlag
        {
            set
            {
                resetAllForm();
                playFormControllerFlag = value;
            }
        }

        private void resetAllForm()
        {
            loginFormControllerFlag = false;
            mainFormControllerFlag = false;
            playFormControllerFlag = false;

        }

        public Router()
        {

        }

        public bool loop()
        {
            if (loginFormControllerFlag)
            {
                var loginFormController = new LoginFormController(this);
                loginFormControllerFlag = false;
            }else if (mainFormControllerFlag)
            {
                var mainFormController = new MainFormController(this);
                mainFormControllerFlag = false;
            }
            else if (playFormControllerFlag)
            {
                var playFormController = new PlayFormController(this, dataForPlayForm);
                playFormControllerFlag = false;
            }
            else
            {
                //end program
                return false;
            }
            return true;
        }



    }
}
