using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class MemberTypeDAL
    {
        public int add(MemberType model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into MemberType (MemTypeName,MemTypeDesc,DelFlag,SubBy) output inserted.MemType values(@MemTypeName,@MemTypeDesc,@DelFlag,@SubBy)"
            , new SqlParameter("MemTypeName", (model.MemTypeName == null) ? o : model.MemTypeName)
            , new SqlParameter("MemTypeDesc", (model.MemTypeDesc == null) ? o : model.MemTypeDesc)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from MemberType  where MemType =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public MemberType get(int id)
        {
            string sqlText = @"select * from MemberType where MemType = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                MemberType model = new MemberType();
                DataRow dr = dt.Rows[0];
                model.MemType = dr.IsNull("MemType") ? null : (Int32?)dr["MemType"];
                model.MemTypeName = dr.IsNull("MemTypeName") ? null : (string)dr["MemTypeName"];
                model.MemTypeDesc = dr.IsNull("MemTypeDesc") ? null : (string)dr["MemTypeDesc"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                return model;
            }
        }

        public IEnumerable<MemberType> getAll()
        {
            string sqlText = @"select * from MemberType";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<MemberType> models = new List<MemberType>();
            foreach (DataRow dr in dt.Rows)
            {
                MemberType model = new MemberType();
                model.MemType = dr.IsNull("MemType") ? null : (Int32?)dr["MemType"];
                model.MemTypeName = dr.IsNull("MemTypeName") ? null : (string)dr["MemTypeName"];
                model.MemTypeDesc = dr.IsNull("MemTypeDesc") ? null : (string)dr["MemTypeDesc"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                models.Add(model);
            }
            return models;
        }

        public MemberType toModel(DataRow dr)
        {
            MemberType model = new MemberType();
            model.MemType = dr.IsNull("MemType") ? null : (Int32?)dr["MemType"];
            model.MemTypeName = dr.IsNull("MemTypeName") ? null : (string)dr["MemTypeName"];
            model.MemTypeDesc = dr.IsNull("MemTypeDesc") ? null : (string)dr["MemTypeDesc"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            return model;
        }

        public int update(MemberType model)
        {
            object o = DBNull.Value;
            string sqlText = @"update MemberType set MemTypeName=@MemTypeName,MemTypeDesc=@MemTypeDesc,DelFlag=@DelFlag,SubBy=@SubBy where MemType =@MemType ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("MemType", (model.MemType == null) ? o : model.MemType)
             , new SqlParameter("MemTypeName", (model.MemTypeName == null) ? o : model.MemTypeName)
             , new SqlParameter("MemTypeDesc", (model.MemTypeDesc == null) ? o : model.MemTypeDesc)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            );
        }
    }
}