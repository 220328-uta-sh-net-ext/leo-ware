using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IUser
    {
        public string List<UserProfile>(); 

        public void UserProfile();

        //private void UserProfile(List<UserProfile> Users)


        public void AddUser();

        //public void SearchAllUsers(string ID, string UserName);


        public void SearchAllUsers();
      
        //UserProfile GetUsers();

    }

}
