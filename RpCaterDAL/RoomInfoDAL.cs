using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class RoomInfoDAL
    {
        public int add(RoomInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into RoomInfo (RoomName,RoomType,RoomMinMoney,RoomMaxNum,IsDefault,DelFlag,SubTime,SubBy) output inserted.RoomId values(@RoomName,@RoomType,@RoomMinMoney,@RoomMaxNum,@IsDefault,@DelFlag,@SubTime,@SubBy)"
            , new SqlParameter("RoomName", (model.RoomName == null) ? o : model.RoomName)
            , new SqlParameter("RoomType", (model.RoomType == null) ? o : model.RoomType)
            , new SqlParameter("RoomMinMoney", (model.RoomMinMoney == null) ? o : model.RoomMinMoney)
            , new SqlParameter("RoomMaxNum", (model.RoomMaxNum == null) ? o : model.RoomMaxNum)
            , new SqlParameter("IsDefault", (model.IsDefault == null) ? o : model.IsDefault)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from RoomInfo  where RoomId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public RoomInfo get(int id)
        {
            string sqlText = @"select * from RoomInfo where RoomId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                RoomInfo model = new RoomInfo();
                DataRow dr = dt.Rows[0];
                model.RoomId = dr.IsNull("RoomId") ? null : (Int32?)dr["RoomId"];
                model.RoomName = dr.IsNull("RoomName") ? null : (string)dr["RoomName"];
                model.RoomType = dr.IsNull("RoomType") ? null : (Int32?)dr["RoomType"];
                model.RoomMinMoney = dr.IsNull("RoomMinMoney") ? null : (System.Double?)dr["RoomMinMoney"];
                model.RoomMaxNum = dr.IsNull("RoomMaxNum") ? null : (Int32?)dr["RoomMaxNum"];
                model.IsDefault = dr.IsNull("IsDefault") ? null : (string)dr["IsDefault"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                return model;
            }
        }

        public IEnumerable<RoomInfo> getAll()
        {
            string sqlText = @"select * from RoomInfo";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<RoomInfo> models = new List<RoomInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                RoomInfo model = new RoomInfo();
                model.RoomId = dr.IsNull("RoomId") ? null : (Int32?)dr["RoomId"];
                model.RoomName = dr.IsNull("RoomName") ? null : (string)dr["RoomName"];
                model.RoomType = dr.IsNull("RoomType") ? null : (Int32?)dr["RoomType"];
                model.RoomMinMoney = dr.IsNull("RoomMinMoney") ? null : (System.Double?)dr["RoomMinMoney"];
                model.RoomMaxNum = dr.IsNull("RoomMaxNum") ? null : (Int32?)dr["RoomMaxNum"];
                model.IsDefault = dr.IsNull("IsDefault") ? null : (string)dr["IsDefault"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                models.Add(model);
            }
            return models;
        }

        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            string sql = "select * from RoomInfo where DelFlag=" + delFlag;
            DataTable dt = sqlHelper.executeDataTable(sql);
            List<RoomInfo> models = new List<RoomInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }

        public int SoftDelete(int id)
        {
            string sql = "update RoomInfo set DelFlag=1 where RoomId=" + id;
            return sqlHelper.executeNonQuery(sql);
        }

        public RoomInfo toModel(DataRow dr)
        {
            RoomInfo model = new RoomInfo();
            model.RoomId = dr.IsNull("RoomId") ? null : (Int32?)dr["RoomId"];
            model.RoomName = dr.IsNull("RoomName") ? null : (string)dr["RoomName"];
            model.RoomType = dr.IsNull("RoomType") ? null : (Int32?)dr["RoomType"];
            model.RoomMinMoney = dr.IsNull("RoomMinMoney") ? null : (System.Double?)dr["RoomMinMoney"];
            model.RoomMaxNum = dr.IsNull("RoomMaxNum") ? null : (Int32?)dr["RoomMaxNum"];
            model.IsDefault = dr.IsNull("IsDefault") ? null : (string)dr["IsDefault"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            return model;
        }

        public int update(RoomInfo model)
        {
            object o = DBNull.Value;
            string sqlText = @"update RoomInfo set RoomName=@RoomName,RoomType=@RoomType,RoomMinMoney=@RoomMinMoney,RoomMaxNum=@RoomMaxNum,IsDefault=@IsDefault,DelFlag=@DelFlag,SubTime=@SubTime,SubBy=@SubBy where RoomId =@RoomId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("RoomId", (model.RoomId == null) ? o : model.RoomId)
             , new SqlParameter("RoomName", (model.RoomName == null) ? o : model.RoomName)
             , new SqlParameter("RoomType", (model.RoomType == null) ? o : model.RoomType)
             , new SqlParameter("RoomMinMoney", (model.RoomMinMoney == null) ? o : model.RoomMinMoney)
             , new SqlParameter("RoomMaxNum", (model.RoomMaxNum == null) ? o : model.RoomMaxNum)
             , new SqlParameter("IsDefault", (model.IsDefault == null) ? o : model.IsDefault)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            );
        }
    }
}