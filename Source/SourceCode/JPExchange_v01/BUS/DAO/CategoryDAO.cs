using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAO
{
    public class CategoryDAO
    {
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> ret = new List<CategoryDTO>();
            CategoryDTO a = new CategoryDTO();
            a.Id = "1";
            a.Name = "Category 1";
            ret.Add(a);
            a = new CategoryDTO();
            a.Id = "2";
            a.Name = "Category 2";
            ret.Add(a);

            return ret;
        }

        public CategoryDTO GetChildCategory(String Id)
        {
            CategoryDTO a = new CategoryDTO();
            a.Id = "1";
            a.Name = "Category 1";
            return a;
        }


    }
}
