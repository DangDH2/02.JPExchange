using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class UserDTO
    {
        public String UserId { get; set; }
        public String FullName { get; set; }
        public String Avatar {get; set;}
        public String Email {get; set;}
        public String Phone {get; set;}
        public String Facebook {get; set;}
        
        public UserDTO(){
        }
        
    }
}
