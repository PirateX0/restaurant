using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class CategoryInfoDAL
    {
        public int add(CategoryInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into CategoryInfo (CName,CNum,CRemark,DelFlag,SubTime,SubBy) output inserted.CId values(@CName,@CNum,@CRemark,@DelFlag,@SubTime,@SubBy)"
            , new SqlParameter("CName", (model.CName == null) ? o : model.CName)
            , new SqlParameter("CNum", (model.CNum == null) ? o : model.CNum)
            , new SqlParameter("CRemark", (model.CRemark == null) ? o : model.CRemark)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from CategoryInfo  where CId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public int update(CategoryInfo model)
        {
            object o = DBNull.Value;
            string sqlText = @"update CategoryInfo set CName=@CName,CNum=@CNum,CRemark=@CRemark,DelFlag=@DelFlag,SubTime=@SubTime,SubBy=@SubBy where CId =@CId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("CId", (model.CId == null) ? o : model.CId)
             , new SqlParameter("CName", (model.CName == null) ? o : model.CName)
             , new SqlParameter("CNum", (model.CNum == null) ? o : model.CNum)
             , new SqlParameter("CRemark", (model.CRemark == null) ? o : model.CRemark)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            );
        }

        public CategoryInfo get(int id)
        {
            string sqlText = @"select * from CategoryInfo where CId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                return toModel(dt.Rows[0]);
            }
        }

        public IEnumerable<CategoryInfo> getAll()
        {
            string sqlText = @"select * from CategoryInfo";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<CategoryInfo> models = new List<CategoryInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }

        public CategoryInfo toModel(DataRow dr)
        {
            CategoryInfo model = new CategoryInfo();
            model.CId = dr.IsNull("CId") ? null : (Int32?)dr["CId"];
            model.CName = dr.IsNull("CName") ? null : (string)dr["CName"];
            model.CNum = dr.IsNull("CNum") ? null : (string)dr["CNum"];
            model.CRemark = dr.IsNull("CRemark") ? null : (string)dr["CRemark"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            return model;
        }

        public int SoftDeleteCategoryInfoByCId(int cId)
        {
            //判断类别下的产品数量，如果有产品，要将产品也软删除

            //删除产品
            ProductInfoDAL pdal = new ProductInfoDAL();
            if (pdal.GetProductInfoCountByCid(cId) > 0)
            {
                pdal.SoftDeleteProductInfoByProCId(cId);
            }
            //删除类别
            string sql = "update CategoryInfo set DelFlag=1 where cid =" + cId;
            return sqlHelper.executeNonQuery(sql);
        }

        public List<CategoryInfo> GetAllCategoryInfoByDelFlag(int delFlag)
        {
            string sqlText = "select * from CategoryInfo where delFlag=" + delFlag;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<CategoryInfo> models = new List<CategoryInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                models.Add(toModel(dr));
            }
            return models;
        }
    }
}