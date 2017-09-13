using BUS.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Convert
{
    public static class CategoryConvert
    {
        public static CATEGORY FromDTOToDB(CategoryDTO dto)
        {
            return null;
        }
        public static List<CATEGORY> FromDTOToDB(List<CategoryDTO> lsDTO)
        {
            return null;
        }
        public static CategoryDTO FromDBToDTO(CATEGORY db)
        {
            CategoryDTO dto = new CategoryDTO();
            dto.Id = db.CategoryId.ToString();
            dto.Name = db.Name;
            dto.Index = (db.Index==null?(byte)0:(byte)db.Index);
            return dto;
        }
        public static List<CategoryDTO> FromDBToDTO(List<CATEGORY> lsDb)
        {
            List<CategoryDTO> ret = new List<CategoryDTO>();
            foreach (CATEGORY c in lsDb)
            {
                ret.Add(FromDBToDTO(c));
            }
            return ret;
        }


    }
}
