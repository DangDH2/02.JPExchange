using BUS.Convert;
using BUS.DTO;
using DAL;
using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAO
{
    public class CategoryDAO
    {
        public String AddCategory(CategoryDTO DTO)
        {
            return CategoryDB.Add(CategoryConvert.FromDTOToDB(DTO));
            
        }
        public void UpdateCategory(CategoryDTO DTO)
        {

        }
        public void DeleteCategory(int categoryId)
        {

        }
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> LsDTO = CategoryConvert.FromDBToDTO(CategoryDB.GetParent());
            foreach (CategoryDTO dto in LsDTO)
            {
                dto.ListChildCategory = GetChildCategory(int.Parse(dto.Id));
            }

            return LsDTO;
        }

        public List<CategoryDTO> GetChildCategory(int Id)
        {
            return CategoryConvert.FromDBToDTO(CategoryDB.GetChild(Id));
        }


    }
}
