using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime StartRunTime { get; set; }
        public DateTime EndRunTime { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public double Distance { get; set; }
        public double Speed { get; set; }
        public Gender Gender { get; set; }
        public virtual List<User> FriendsList { get; set; }
        public virtual List<Group> GroupsList { get; set; }
        public virtual List<Measurement> MeasurementList { get; set; }
        public string PhoneNumber { get; set; }
    }
}