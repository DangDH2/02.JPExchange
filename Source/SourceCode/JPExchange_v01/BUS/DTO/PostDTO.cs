using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class PostDTO
    {
        public String PostId { get; set; }
        public String PostName { get; set; }
        public String Description {get; set;}
        public String ImageHref {get; set;}
        public String Price {get; set;}
        public String SalePrice {get; set;}
        public UserDTO Owner { get; set;}
        public int Rating {get; set;}
        
        public PostDTO(){
        }
        
    }
}
