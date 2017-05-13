using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Group
    {
        public int ID { get; set; }
        public Location StartLocation { get; set; }
        public DateTime StartRunTime { get; set; }
        public DateTime EndRunTime { get; set; }
        public double Distance { get; set; }
        public double Speed { get; set; }
        public virtual List<User> FriendsList { get; set; }
    }
}