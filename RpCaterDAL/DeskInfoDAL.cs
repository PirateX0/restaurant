using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class DeskInfoDAL
    {
        public int add(DeskInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into DeskInfo (RoomId,DeskName,DeskRemark,DeskRegion,DeskState,DelFlag,SubTime,SubBy) output inserted.DeskId values(@RoomId,@DeskName,@DeskRemark,@DeskRegion,@DeskState,@DelFlag,@SubTime,@SubBy)"
            , new SqlParameter("RoomId", (model.RoomId == null) ? o : model.RoomId)
            , new SqlParameter("DeskName", (model.DeskName == null) ? o : model.DeskName)
            , new SqlParameter("DeskRemark", (model.DeskRemark == null) ? o : model.DeskRemark)
            , new SqlParameter("DeskRegion", (model.DeskRegion == null) ? o : model.DeskRegion)
            , new SqlParameter("DeskState", (model.DeskState == null) ? o : model.DeskState)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from DeskInfo  where DeskId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public DeskInfo get(int id)
        {
            string sqlText = @"select * from DeskInfo where DeskId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                DeskInfo model = new DeskInfo();
                DataRow dr = dt.Rows[0];
                model = toModel(dr);
                return model;
            }
        }

        public int GetAliveDeskCountByRoomId(int roomId)
        {
            string sql = "select count(*) from DeskInfo where DelFlag=0 and RoomId=" + roomId;
            return (int)sqlHelper.executeScalar(sql);
        }

        public IEnumerable<DeskInfo> getAll()
        {
            string sqlText = @"select * from DeskInfo";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<DeskInfo> models = new List<DeskInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }

        public List<DeskInfo> GetAllAliveDeskInfoByRoomId(int roomId)
        {
            string sql = "select * from DeskInfo where DelFlag=0 and RoomId=" + roomId;
            DataTable table = sqlHelper.executeDataTable(sql);
            List<DeskInfo> desks = new List<DeskInfo>();
            foreach (DataRow row in table.Rows)
            {
                desks.Add(toModel(row));
            }
            return desks;
        }

        public List<DeskInfo> GetAllDeskInfoByDelFlag(int delFlag)
        {
            string sqlText = @"select * from DeskInfo where DelFlag=" + delFlag;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<DeskInfo> models = new List<DeskInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }

        public int SoftDelete(int id)
        {
            string sql = "update DeskInfo set DelFlag =1 where DeskId=" + id;
            return sqlHelper.executeNonQuery(sql);
        }

        //增加了DeskStateString属性
        public DeskInfo toModel(DataRow dr)
        {
            DeskInfo model = new DeskInfo();
            model.DeskId = dr.IsNull("DeskId") ? null : (Int32?)dr["DeskId"];
            model.RoomId = dr.IsNull("RoomId") ? null : (Int32?)dr["RoomId"];
            model.DeskName = dr.IsNull("DeskName") ? null : (string)dr["DeskName"];
            model.DeskRemark = dr.IsNull("DeskRemark") ? null : (string)dr["DeskRemark"];
            model.DeskRegion = dr.IsNull("DeskRegion") ? null : (string)dr["DeskRegion"];
            model.DeskState = dr.IsNull("DeskState") ? null : (Int32?)dr["DeskState"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            model.DeskStateString = model.DeskState == 0 ? "空闲" : "就餐";
            return model;
        }

        public int update(DeskInfo model)
        {
            object o = DBNull.Value;
            string sqlText = @"update DeskInfo set RoomId=@RoomId,DeskName=@DeskName,DeskRemark=@DeskRemark,DeskRegion=@DeskRegion,DeskState=@DeskState,DelFlag=@DelFlag,SubTime=@SubTime,SubBy=@SubBy where DeskId =@DeskId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("DeskId", (model.DeskId == null) ? o : model.DeskId)
             , new SqlParameter("RoomId", (model.RoomId == null) ? o : model.RoomId)
             , new SqlParameter("DeskName", (model.DeskName == null) ? o : model.DeskName)
             , new SqlParameter("DeskRemark", (model.DeskRemark == null) ? o : model.DeskRemark)
             , new SqlParameter("DeskRegion", (model.DeskRegion == null) ? o : model.DeskRegion)
             , new SqlParameter("DeskState", (model.DeskState == null) ? o : model.DeskState)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            );
        }

        public int UpdateDeskInfoStateByDeskIdAndState(int deskId, int state)
        {
            string sql = "update DeskInfo set DeskState=" + state + " where DelFlag=0 and DeskId=" + deskId;
            return sqlHelper.executeNonQuery(sql);
        }

        public int UpdateDeskInfoStateByDeskIdAndState(SqlConnection con, SqlTransaction tran, int deskId, int state)
        {
            string sql = "update DeskInfo set DeskState=" + state + " where DelFlag=0 and DeskId=" + deskId;
            return sqlHelper.executeNonQuery(con, tran, sql);
        }
    }
}