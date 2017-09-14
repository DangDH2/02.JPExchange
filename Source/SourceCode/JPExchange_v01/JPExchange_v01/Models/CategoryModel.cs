using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPExchange_v01.Models
{
    public class CategoryModel
    {

        public CategoryModel(List<CategoryDTO> list)
        {
            if (list == null)
            {
                list = new List<CategoryDTO>();
            }
            this.ListCategory = list;
        }
        public List<CategoryDTO> ListCategory { get; set; }

    }
}