using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapWebAPI_COMMON.Entities
{
    public class Player
    {
        public int Id { get; set; }
       
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        
    }
}
