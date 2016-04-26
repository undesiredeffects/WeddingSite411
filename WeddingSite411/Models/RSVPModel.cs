using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace WeddingSite411.Models
{
    public class RSVPModel
    {
        [Key]
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Attending { get; set; }
    }
}