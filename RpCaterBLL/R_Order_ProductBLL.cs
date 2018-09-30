using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class R_Order_ProductBLL
    {
        public int add(R_Order_Product model)
        {
            return new R_Order_ProductDAL().add(model);
        }

        public int delete(int id)
        {
            return new R_Order_ProductDAL().delete(id);
        }

        public R_Order_Product get(int id)
        {
            return new R_Order_ProductDAL().get(id);
        }

        public IEnumerable<R_Order_Product> getAll()
        {
            return new R_Order_ProductDAL().getAll();
        }

        public DataTable GetProductCountAndSumPriceByOrderId(int orderId)
        {
            return new R_Order_ProductDAL().GetProductCountAndSumPriceByOrderId(orderId);
        }

        public DataTable GetROrderProductByOrderId(int orderId)
        {
            return new R_Order_ProductDAL().GetROrderProductByOrderId(orderId);
        }

        /// <summary>
        /// 点菜
        /// </summary>
        /// <param name="rop">待插入的rop对象，不包含ropId</param>
        /// <returns></returns>
        public bool OrderFood(R_Order_Product rop)
        {
            return new R_Order_ProductDAL().OrderFood(rop);
        }

        public bool SoftDeleteByROrderProductId(int ropId)
        {
            return new R_Order_ProductDAL().SoftDeleteByROrderProductId(ropId);
        }

        public R_Order_Product toModel(DataRow dr)
        {
            return new R_Order_ProductDAL().toModel(dr);
        }

        public int update(R_Order_Product model)
        {
            return new R_Order_ProductDAL().update(model);
        }

        public bool UpdateROPDelFlagByOrderId(int orderId)
        {
            return new R_Order_ProductDAL().UpdateROPDelFlagByOrderId(orderId) > 0;
        }
    }
}