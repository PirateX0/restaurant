using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class CategoryInfoBLL
    {
        public int add(CategoryInfo model)
        {
            return new CategoryInfoDAL().add(model);
        }

        public int delete(int id)
        {
            return new CategoryInfoDAL().delete(id);
        }

        public CategoryInfo get(int id)
        {
            return new CategoryInfoDAL().get(id);
        }

        public IEnumerable<CategoryInfo> getAll()
        {
            return new CategoryInfoDAL().getAll();
        }

        public List<CategoryInfo> GetAllCategoryInfoByDelFlag(int delFlag)
        {
            return new CategoryInfoDAL().GetAllCategoryInfoByDelFlag(delFlag);
        }

        public int SoftDeleteCategoryInfoByCId(int cId)
        {
            return new CategoryInfoDAL().SoftDeleteCategoryInfoByCId(cId);
        }

        public CategoryInfo toModel(DataRow dr)
        {
            return new CategoryInfoDAL().toModel(dr);
        }

        public int update(CategoryInfo model)
        {
            return new CategoryInfoDAL().update(model);
        }
    }
}