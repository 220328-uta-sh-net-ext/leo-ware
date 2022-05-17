using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonModels
{
    public class Admin
    {
        public string AdminAccess { get; set; }
        public int AdminID { get; set; }
        
        [BindRequired]
        public string AdminName { get; set; }

        [DataType(DataType.Password)]
        [BindRequired]
        public string AdminPassword { get; set; }

        public Admin()
        {
            AdminAccess = "A";
            AdminID = 0;
            AdminName = "El Jefe";
            AdminPassword = "1234";
        }

        public string AdminToString()
        {
            return $"AdminID: {AdminID}\nAdminName: {AdminName}\nAdmin Password: {AdminPassword}";
        }
    }
}
