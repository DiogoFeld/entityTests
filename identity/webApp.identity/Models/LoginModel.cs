using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.identity.Models
{
    public class LoginModel
    {
        public string userName { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }




    }
}
