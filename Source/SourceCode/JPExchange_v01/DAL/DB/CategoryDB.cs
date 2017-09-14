
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public static class CategoryDB
    {
        public static List<CATEGORY> GetParent()
        {
            using (var context = new JPEEntities())
            {
                var dataset = context.CATEGORIES
                    .Where(x => x.ParentId == null)
                    .OrderBy(x => x.Index).ToList();

                return dataset;
            }

        }
        public static List<CATEGORY> GetChild(int Id)
        {
            using (var context = new JPEEntities())
            {
                var dataset = context.CATEGORIES
                    .Where(x => x.ParentId == Id)
                    .OrderBy(x => x.Index).ToList();

                return dataset;
            }

        }
        


        public static String Add(CATEGORY cat)
        {

            using (var context = new JPEEntities())
            {
                //using (var dbContextTransaction = context.Database.BeginTransaction())
                //{

                    try
                    {

                        context.CATEGORIES.Add(cat);

                        context.SaveChanges();

                        return "";
                        //dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                        //dbContextTransaction.Rollback();
                    }
                //}
            }

        }

        public static void Update(CATEGORY cat)
        {

            using (var context = new JPEEntities())
            {
                //using (var dbContextTransaction = context.Database.BeginTransaction())
                //{

                try
                {

                    context.SaveChanges();


                    //dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //dbContextTransaction.Rollback();
                }
                //}
            }

        }
    }
}
