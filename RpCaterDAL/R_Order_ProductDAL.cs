using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class R_Order_ProductDAL
    {
        public int add(R_Order_Product model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into R_Order_Product (OrderId,ProId,DelFlag,SubTime,UnitCount) output inserted.ROrderProId values(@OrderId,@ProId,@DelFlag,@SubTime,@UnitCount)"
            , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
            , new SqlParameter("ProId", (model.ProId == null) ? o : model.ProId)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("UnitCount", (model.UnitCount == null) ? o : model.UnitCount)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from R_Order_Product  where ROrderProId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public R_Order_Product get(int id)
        {
            string sqlText = @"select * from R_Order_Product where ROrderProId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                R_Order_Product model = new R_Order_Product();
                DataRow dr = dt.Rows[0];
                model.ROrderProId = dr.IsNull("ROrderProId") ? null : (Int32?)dr["ROrderProId"];
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.UnitCount = dr.IsNull("UnitCount") ? null : (Int32?)dr["UnitCount"];
                return model;
            }
        }

        public List<R_Order_Product> GetAliveROrderProductByOrderId(int orderId)
        {
            string sqlText = @"select * from R_Order_Product where DelFlag=0 and OrderID=" + orderId;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<R_Order_Product> models = new List<R_Order_Product>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }

        public IEnumerable<R_Order_Product> getAll()
        {
            string sqlText = @"select * from R_Order_Product";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<R_Order_Product> models = new List<R_Order_Product>();
            foreach (DataRow dr in dt.Rows)
            {
                R_Order_Product model = new R_Order_Product();
                model.ROrderProId = dr.IsNull("ROrderProId") ? null : (Int32?)dr["ROrderProId"];
                model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
                model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.UnitCount = dr.IsNull("UnitCount") ? null : (Int32?)dr["UnitCount"];
                models.Add(model);
            }
            return models;
        }

        public DataTable GetProductCountAndSumPriceByOrderId(int orderId)
        {
            string sql = @"select COUNT(*) ProductCount,SUM(ProPrice*UnitCount) SumPrice from R_Order_Product rop
                        left join ProductInfo p on rop.ProId=p.ProId
                        where rop.DelFlag=0 and OrderId=" + orderId;
            return sqlHelper.executeDataTable(sql);
        }

        /// <summary>
        /// 根据OrderId获得订餐的详细信息
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public DataTable GetROrderProductByOrderId(int orderId)
        {
            //delflag=0确保没有退菜或结账
            string sql = @"select rop.ROrderProId, ProName,ProPrice,UnitCount,ProUnit,  UnitCount*ProPrice ProSumPrice,CName,rop.Subtime
                        from R_Order_Product rop
                        left join ProductInfo p on rop.ProId=p.ProId
                        left join CategoryInfo c on c.CId=p.CId
                        where  rop.DelFlag=0  and rop.OrderId=" + orderId;
            return sqlHelper.executeDataTable(sql);
        }

        /// <summary>
        /// 点菜
        /// </summary>
        /// <param name="rop">待插入的rop对象，不包含ropId</param>
        /// <returns></returns>
        public bool OrderFood(R_Order_Product rop)
        {
            //先判断rop表中orderid对应的proid是否包含要插入的proid
            //如果包含，只更新unitcount
            List<R_Order_Product> Rops = GetAliveROrderProductByOrderId((int)rop.OrderId);
            foreach (R_Order_Product ropItem in Rops)
            {
                if (ropItem.ProId == rop.ProId)
                {
                    return UpdateUnitCountOfExistentProId(rop) > 0 ? true : false;
                }
            }
            //如果不包含，则插入
            return add(rop) > 0 ? true : false;
        }

        public bool SoftDeleteByROrderProductId(int ropId)
        {
            string sql = "update R_Order_Product set DelFlag=1 where ROrderProId=" + ropId;
            return sqlHelper.executeNonQuery(sql) > 0;
        }

        public R_Order_Product toModel(DataRow dr)
        {
            R_Order_Product model = new R_Order_Product();
            model.ROrderProId = dr.IsNull("ROrderProId") ? null : (Int32?)dr["ROrderProId"];
            model.OrderId = dr.IsNull("OrderId") ? null : (Int32?)dr["OrderId"];
            model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.UnitCount = dr.IsNull("UnitCount") ? null : (Int32?)dr["UnitCount"];
            return model;
        }

        public int update(R_Order_Product model)
        {
            object o = DBNull.Value;
            string sqlText = @"update R_Order_Product set OrderId=@OrderId,ProId=@ProId,DelFlag=@DelFlag,SubTime=@SubTime,UnitCount=@UnitCount where ROrderProId =@ROrderProId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("ROrderProId", (model.ROrderProId == null) ? o : model.ROrderProId)
             , new SqlParameter("OrderId", (model.OrderId == null) ? o : model.OrderId)
             , new SqlParameter("ProId", (model.ProId == null) ? o : model.ProId)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("UnitCount", (model.UnitCount == null) ? o : model.UnitCount)
            );
        }

        public int UpdateROPDelFlagByOrderId(int orderId)
        {
            string sql = "update R_Order_Product set DelFlag=1 where OrderId=" + orderId;
            return sqlHelper.executeNonQuery(sql);
        }

        public int UpdateUnitCountOfExistentProId(R_Order_Product rop)
        {
            string sql = string.Format(
                @"update R_Order_Product set UnitCount=UnitCount+{0}
                  where DelFlag=0 and OrderId={1} and ProId ={2}", rop.UnitCount, rop.OrderId, rop.ProId);
            return sqlHelper.executeNonQuery(sql);
        }
    }
}