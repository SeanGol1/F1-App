using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_App.Models
{
    public class UserPoints
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Points { get; set; }
        public string UserName { get; set; }
        public UserPoints()
        {

        }
    }
}
