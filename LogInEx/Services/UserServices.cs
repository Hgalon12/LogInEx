using LogInEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInEx.Services
{
    internal class UserServices
    {
        public List <UserModels> Users { get; set; }
        public UserServices ()
        {
            this.Users = new List<UserModels>();
            fillList();
        }
        private void fillList()
        {
            Users.Add(new UserModels
            { 
                UserName = "AdarG",
                Password= "1702"

            }) ;
            Users.Add(new UserModels
            {
                UserName = "HadasG",
                Password = "2501"

            });
            Users.Add(new UserModels
            {
                UserName = "AmitB",
                Password = "1011"

            });

        }
        public bool IsExsist(UserModels user) 
        { 
            foreach (UserModels u in Users)
            {
                if(u.UserName == user.UserName  &&  u.Password==user.Password)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
