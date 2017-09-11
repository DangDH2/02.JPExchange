using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class CategoryDTO
    {
        public String Id { get; set; }
        public String Name { get; set; }

        public List<CategoryDTO> ListChildCategory { get; set; }
    }
}
