using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebShopApplication.Models
{
    public class User
    {
        [Key]
        public string id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public string name { get; set; }

        public string avatar { get; set; }

        public DateTime birthday { get; set; }

        public string email { get; set; }

        public int status { get; set; }

        public string address { get; set; }
    }
}
