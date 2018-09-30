using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class R_Order_DeskBLL
    {
        public int add(R_Order_Desk model)
        {
            return new R_Order_DeskDAL().add(model);
        }

        public int delete(int id)
        {
            return new R_Order_DeskDAL().delete(id);
        }

        public R_Order_Desk get(int id)
        {
            return new R_Order_DeskDAL().get(id);
        }

        public int GetAliveOrderIdByDeskId(int deskId)
        {
            return new R_Order_DeskDAL().GetAliveOrderIdByDeskId(deskId);
        }

        public IEnumerable<R_Order_Desk> getAll()
        {
            return new R_Order_DeskDAL().getAll();
        }

        public R_Order_Desk toModel(DataRow dr)
        {
            return new R_Order_DeskDAL().toModel(dr);
        }

        public int update(R_Order_Desk model)
        {
            return new R_Order_DeskDAL().update(model);
        }
    }
}