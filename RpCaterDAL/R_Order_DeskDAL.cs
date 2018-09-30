using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class R_Order_DeskDAL
    {
        public int add(R_Order_Desk model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into R_Order_Desk (OrderId,DeskId) output inserted.RID values(@OrderId,@DeskId)"
            , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
            , new SqlParameter("DeskId", (model.DeskId == null) ? o : model.DeskId)
            ));
        }

        public int add(SqlConnection con, SqlTransaction tran, R_Order_Desk model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(con, tran,
           "insert into R_Order_Desk (OrderId,DeskId) output inserted.RID values(@OrderId,@DeskId)"
            , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
            , new SqlParameter("DeskId", (model.DeskId == null) ? o : model.DeskId)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from R_Order_Desk  where RID =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public R_Order_Desk get(int id)
        {
            string sqlText = @"select * from R_Order_Desk where RID = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                R_Order_Desk model = new R_Order_Desk();
                DataRow dr = dt.Rows[0];
                model.RID = dr.IsNull("RID") ? null : (Int32?)dr["RID"];
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.DeskId = dr.IsNull("DeskId") ? null : (Int32?)dr["DeskId"];
                return model;
            }
        }

        public int GetAliveOrderIdByDeskId(int deskId)
        {
            string sql = @"select r.OrderId from R_Order_Desk r
                         left join OrderInfo o
                         on o.OrderId=r.OrderId
                         where o.OrderState=1 and o.DelFlag=0 and r.DeskId=" + deskId;
            return (int)sqlHelper.executeScalar(sql);
        }

        public IEnumerable<R_Order_Desk> getAll()
        {
            string sqlText = @"select * from R_Order_Desk";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<R_Order_Desk> models = new List<R_Order_Desk>();
            foreach (DataRow dr in dt.Rows)
            {
                R_Order_Desk model = new R_Order_Desk();
                model.RID = dr.IsNull("RID") ? null : (Int32?)dr["RID"];
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.DeskId = dr.IsNull("DeskId") ? null : (Int32?)dr["DeskId"];
                models.Add(model);
            }
            return models;
        }

        public R_Order_Desk toModel(DataRow dr)
        {
            R_Order_Desk model = new R_Order_Desk();
            model.RID = dr.IsNull("RID") ? null : (Int32?)dr["RID"];
            model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
            model.DeskId = dr.IsNull("DeskId") ? null : (Int32?)dr["DeskId"];
            return model;
        }

        public int update(R_Order_Desk model)
        {
            object o = DBNull.Value;
            string sqlText = @"update R_Order_Desk set OrderId=@OrderId,DeskId=@DeskId where RID =@RID ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("RID", (model.RID == null) ? o : model.RID)
             , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
             , new SqlParameter("DeskId", (model.DeskId == null) ? o : model.DeskId)
            );
        }
    }
}