using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMyShop.Models
{
    public class Customer
    {
        [Key]
        public int customer_ID { get; set; }

        public string nameCustomer { get; set; }

        public string phoneNumber { get; set; }

        public string address { get; set; }
        public string email { get; set; }
        public Customer() { }

    }
}
