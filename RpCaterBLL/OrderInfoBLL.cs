using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class OrderInfoBLL
    {
        public int add(OrderInfo model)
        {
            return new OrderInfoDAL().add(model);
        }

        /// <summary>
        /// 开单的三件事情
        /// </summary>
        /// <param name="insertOrder">插入的order，注意该order对象没有id</param>
        /// <param name="desk">state:0--->空闲；1--->就餐</param>
        /// <returns>返回orderId</returns>
        public int AddOrderAddOrder_DeskUpdateDesk(OrderInfo insertOrder, DeskInfo desk)
        {
            return new OrderInfoDAL().AddOrderAddOrder_DeskUpdateDesk(insertOrder, desk);
        }

        public int delete(int id)
        {
            return new OrderInfoDAL().delete(id);
        }

        public OrderInfo get(int id)
        {
            return new OrderInfoDAL().get(id);
        }

        public IEnumerable<OrderInfo> getAll()
        {
            return new OrderInfoDAL().getAll();
        }

        public OrderInfo toModel(DataRow dr)
        {
            return new OrderInfoDAL().toModel(dr);
        }

        public bool update(OrderInfo model)
        {
            return new OrderInfoDAL().update(model) > 0 ? true : false;
        }

        public bool UpdateOrderMoney(int orderId, double orderMoney)
        {
            return new OrderInfoDAL().UpdateOrderMoney(orderId, orderMoney);
        }
    }
}