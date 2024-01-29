using LogInEx.Models;
using LogInEx.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInEx.ViewModels
{
    internal class LoginViewModel: ViewModelBase
    {
        private string userName;
        public string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                OnPropertyChanged();
            }
        }

        private string massage;
        public string Massage
        {
            get { return this.massage; }
            set
            {
                this.massage = value;
                OnPropertyChanged();
            }  
        }

        private Color massageColor;
        public Color MassageColor
        {
            get { return this.massageColor; }
            set
            {
                this.massageColor = value;
                OnPropertyChanged();
            }
        }

        public Command GetIsExist { get; set; }
        public Command Cancel { get; set; }
        public LoginViewModel()
        {
            Cancel = new Command(GetCancel);
            GetIsExist= new Command(GetIsExist1);

        }
        private void GetIsExist1() 
        { 
            UserServices service = new UserServices();
            UserModels u1 = new UserModels()
            {
                UserName = this.UserName,
                Password = this.Password
            };

            bool u= service.IsExsist(u1);
            if (u == false)
            {
                Massage = "login failed!";
                MassageColor = Colors.Red;
            }
            else
            {
                Massage = " you are  in!!!";
                MassageColor = Colors.Green;
            }


        }
        private void GetCancel()
        {
            UserName = "";
            Password = "";
        }




    }
}
