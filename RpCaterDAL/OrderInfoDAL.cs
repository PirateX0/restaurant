using RpCater.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class OrderInfoDAL
    {
        public int add(OrderInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into OrderInfo (SubTime,Remark,OrderState,OrderMemberId,DelFlag,SubBy,BeginTime,EndTime,OrderMoney,DisCount) output inserted.OrderId values(@SubTime,@Remark,@OrderState,@OrderMemberId,@DelFlag,@SubBy,@BeginTime,@EndTime,@OrderMoney,@DisCount)"
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("Remark", (model.Remark == null) ? o : model.Remark)
            , new SqlParameter("OrderState", (model.OrderState == null) ? o : model.OrderState)
            , new SqlParameter("OrderMemberId", (model.OrderMemberId == null) ? o : model.OrderMemberId)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            , new SqlParameter("BeginTime", (model.BeginTime == null) ? o : model.BeginTime)
            , new SqlParameter("EndTime", (model.EndTime == null) ? o : model.EndTime)
            , new SqlParameter("OrderMoney", (model.OrderMoney == null) ? o : model.OrderMoney)
            , new SqlParameter("DisCount", (model.DisCount == null) ? o : model.DisCount)
            ));
        }

        public int add(SqlConnection con, SqlTransaction tran, OrderInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(con, tran,
           "insert into OrderInfo (SubTime,Remark,OrderState,OrderMemberId,DelFlag,SubBy,BeginTime,EndTime,OrderMoney,DisCount) output inserted.OrderId values(@SubTime,@Remark,@OrderState,@OrderMemberId,@DelFlag,@SubBy,@BeginTime,@EndTime,@OrderMoney,@DisCount)"
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("Remark", (model.Remark == null) ? o : model.Remark)
            , new SqlParameter("OrderState", (model.OrderState == null) ? o : model.OrderState)
            , new SqlParameter("OrderMemberId", (model.OrderMemberId == null) ? o : model.OrderMemberId)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            , new SqlParameter("BeginTime", (model.BeginTime == null) ? o : model.BeginTime)
            , new SqlParameter("EndTime", (model.EndTime == null) ? o : model.EndTime)
            , new SqlParameter("OrderMoney", (model.OrderMoney == null) ? o : model.OrderMoney)
            , new SqlParameter("DisCount", (model.DisCount == null) ? o : model.DisCount)
            ));
        }

        /// <summary>
        /// 开单的三件事情
        /// </summary>
        /// <param name="insertOrder">插入的order，注意该order对象没有id</param>
        /// <param name="desk">state:0--->空闲；1--->就餐</param>
        /// <returns>返回orderId</returns>
        public int AddOrderAddOrder_DeskUpdateDesk(OrderInfo insertOrder, DeskInfo desk)
        {
            using (SqlConnection con =
                new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    //修改deskinfo的state为1
                    new DeskInfoDAL().UpdateDeskInfoStateByDeskIdAndState(con, tx, (int)desk.DeskId, 1);
                    //插入新的order，并将得到的id传给下面的R_Order_Desk
                    int orderId = add(con, tx, insertOrder);
                    //插入order_desk
                    R_Order_Desk od = new R_Order_Desk();
                    od.OrderId = orderId;
                    od.DeskId = desk.DeskId;
                    new R_Order_DeskDAL().add(con, tx, od);

                    tx.Commit();
                    return orderId;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        public int delete(int id)
        {
            string sqlText = @"delete from OrderInfo  where OrderId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public OrderInfo get(int id)
        {
            string sqlText = @"select * from OrderInfo where OrderId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                OrderInfo model = new OrderInfo();
                DataRow dr = dt.Rows[0];
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
                model.OrderState = dr.IsNull("OrderState") ? null : (Int32?)dr["OrderState"];
                model.OrderMemberId = dr.IsNull("OrderMemberId") ? null : (Int32?)dr["OrderMemberId"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                model.BeginTime = dr.IsNull("BeginTime") ? null : (System.DateTime?)dr["BeginTime"];
                model.EndTime = dr.IsNull("EndTime") ? null : (System.DateTime?)dr["EndTime"];
                model.OrderMoney = dr.IsNull("OrderMoney") ? null : (System.Double?)dr["OrderMoney"];
                model.DisCount = dr.IsNull("DisCount") ? null : (System.Double?)dr["DisCount"];
                return model;
            }
        }

        public IEnumerable<OrderInfo> getAll()
        {
            string sqlText = @"select * from OrderInfo";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<OrderInfo> models = new List<OrderInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                OrderInfo model = new OrderInfo();
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
                model.OrderState = dr.IsNull("OrderState") ? null : (Int32?)dr["OrderState"];
                model.OrderMemberId = dr.IsNull("OrderMemberId") ? null : (Int32?)dr["OrderMemberId"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                model.BeginTime = dr.IsNull("BeginTime") ? null : (System.DateTime?)dr["BeginTime"];
                model.EndTime = dr.IsNull("EndTime") ? null : (System.DateTime?)dr["EndTime"];
                model.OrderMoney = dr.IsNull("OrderMoney") ? null : (System.Double?)dr["OrderMoney"];
                model.DisCount = dr.IsNull("DisCount") ? null : (System.Double?)dr["DisCount"];
                models.Add(model);
            }
            return models;
        }

        public OrderInfo toModel(DataRow dr)
        {
            OrderInfo model = new OrderInfo();
            model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
            model.OrderState = dr.IsNull("OrderState") ? null : (Int32?)dr["OrderState"];
            model.OrderMemberId = dr.IsNull("OrderMemberId") ? null : (Int32?)dr["OrderMemberId"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            model.BeginTime = dr.IsNull("BeginTime") ? null : (System.DateTime?)dr["BeginTime"];
            model.EndTime = dr.IsNull("EndTime") ? null : (System.DateTime?)dr["EndTime"];
            model.OrderMoney = dr.IsNull("OrderMoney") ? null : (System.Double?)dr["OrderMoney"];
            model.DisCount = dr.IsNull("DisCount") ? null : (System.Double?)dr["DisCount"];
            return model;
        }

        public int update(OrderInfo model)
        {
            object o = DBNull.Value;
            string sqlText = @"update OrderInfo set SubTime=@SubTime,Remark=@Remark,OrderState=@OrderState,OrderMemberId=@OrderMemberId,DelFlag=@DelFlag,SubBy=@SubBy,BeginTime=@BeginTime,EndTime=@EndTime,OrderMoney=@OrderMoney,DisCount=@DisCount where OrderId =@OrderId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("Remark", (model.Remark == null) ? o : model.Remark)
             , new SqlParameter("OrderState", (model.OrderState == null) ? o : model.OrderState)
             , new SqlParameter("OrderMemberId", (model.OrderMemberId == null) ? o : model.OrderMemberId)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
             , new SqlParameter("BeginTime", (model.BeginTime == null) ? o : model.BeginTime)
             , new SqlParameter("EndTime", (model.EndTime == null) ? o : model.EndTime)
             , new SqlParameter("OrderMoney", (model.OrderMoney == null) ? o : model.OrderMoney)
             , new SqlParameter("DisCount", (model.DisCount == null) ? o : model.DisCount)
            );
        }

        public bool UpdateOrderMoney(int orderId, double orderMoney)
        {
            string sql = "update OrderInfo set OrderMoney=" + orderMoney + " where OrderId =" + orderId;
            return sqlHelper.executeNonQuery(sql) > 0 ? true : false;
        }
    }
}