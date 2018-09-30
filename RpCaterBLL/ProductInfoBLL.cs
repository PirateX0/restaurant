using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class ProductInfoBLL
    {
        public int add(ProductInfo model)
        {
            return new ProductInfoDAL().add(model);
        }

        public int delete(int id)
        {
            return new ProductInfoDAL().delete(id);
        }

        public ProductInfo get(int id)
        {
            return new ProductInfoDAL().get(id);
        }

        public List<ProductInfo> GetAliveProductInfosByCid(int cId)
        {
            return new ProductInfoDAL().GetAliveProductInfosByCid(cId);
        }

        public IEnumerable<ProductInfo> getAll()
        {
            return new ProductInfoDAL().getAll();
        }

        public List<ProductInfo> GetAllProductInfoByDelFlag(int delFlag)
        {
            return new ProductInfoDAL().GetAllProductInfoByDelFlag(delFlag);
        }

        public int GetProductInfoCountByCid(int cId)
        {
            return new ProductInfoDAL().GetProductInfoCountByCid(cId);
        }

        public DataTable GetProductInfosByLikeProSpellOrProNum(string proSpellOrProNum)
        {
            return new ProductInfoDAL().GetProductInfosByLikeProSpellOrProNum(proSpellOrProNum);
        }

        public int SoftDeleteProductInfoByProId(int id)
        {
            return new ProductInfoDAL().SoftDeleteProductInfoByProId(id);
        }

        public ProductInfo toModel(DataRow dr)
        {
            return new ProductInfoDAL().toModel(dr);
        }

        public int update(ProductInfo model)
        {
            return new ProductInfoDAL().update(model);
        }
    }
}