using RpCater.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class ProductInfoDAL
    {
        public int add(ProductInfo model)
        {
            object o = DBNull.Value;
            return Convert.ToInt32(sqlHelper.executeScalar(
           "insert into ProductInfo (CId,ProName,ProCost,ProSpell,ProPrice,ProUnit,Remark,DelFlag,SubTime,ProStock,ProNum,SubBy) output inserted.ProId values(@CId,@ProName,@ProCost,@ProSpell,@ProPrice,@ProUnit,@Remark,@DelFlag,@SubTime,@ProStock,@ProNum,@SubBy)"
            , new SqlParameter("CId", (model.CId == null) ? o : model.CId)
            , new SqlParameter("ProName", (model.ProName == null) ? o : model.ProName)
            , new SqlParameter("ProCost", (model.ProCost == null) ? o : model.ProCost)
            , new SqlParameter("ProSpell", (model.ProSpell == null) ? o : model.ProSpell)
            , new SqlParameter("ProPrice", (model.ProPrice == null) ? o : model.ProPrice)
            , new SqlParameter("ProUnit", (model.ProUnit == null) ? o : model.ProUnit)
            , new SqlParameter("Remark", (model.Remark == null) ? o : model.Remark)
            , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
            , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
            , new SqlParameter("ProStock", (model.ProStock == null) ? o : model.ProStock)
            , new SqlParameter("ProNum", (model.ProNum == null) ? o : model.ProNum)
            , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            ));
        }

        public int delete(int id)
        {
            string sqlText = @"delete from ProductInfo  where ProId =@id ";
            return sqlHelper.executeNonQuery(sqlText, new SqlParameter("id", id));
        }

        public ProductInfo get(int id)
        {
            string sqlText = @"select * from ProductInfo where ProId = @id";
            DataTable dt = sqlHelper.executeDataTable(sqlText, new SqlParameter("id", id));
            if (dt.Rows.Count <= 0) { return null; }
            else
            {
                ProductInfo model = new ProductInfo();
                DataRow dr = dt.Rows[0];
                model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
                model.CId = dr.IsNull("CId") ? null : (Int32?)dr["CId"];
                model.ProName = dr.IsNull("ProName") ? null : (string)dr["ProName"];
                model.ProCost = dr.IsNull("ProCost") ? null : (System.Double?)dr["ProCost"];
                model.ProSpell = dr.IsNull("ProSpell") ? null : (string)dr["ProSpell"];
                model.ProPrice = dr.IsNull("ProPrice") ? null : (System.Double?)dr["ProPrice"];
                model.ProUnit = dr.IsNull("ProUnit") ? null : (string)dr["ProUnit"];
                model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.ProStock = dr.IsNull("ProStock") ? null : (Int32?)dr["ProStock"];
                model.ProNum = dr.IsNull("ProNum") ? null : (string)dr["ProNum"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                return model;
            }
        }

        public List<ProductInfo> GetAliveProductInfosByCid(int cId)
        {
            string sqlText = @"select * from ProductInfo where DelFlag=0 and CId=" + cId;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<ProductInfo> models = new List<ProductInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductInfo model = toModel(dr);
                models.Add(model);
            }
            return models;
        }

        public IEnumerable<ProductInfo> getAll()
        {
            string sqlText = @"select * from ProductInfo";
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<ProductInfo> models = new List<ProductInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductInfo model = new ProductInfo();
                model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
                model.CId = dr.IsNull("CId") ? null : (Int32?)dr["CId"];
                model.ProName = dr.IsNull("ProName") ? null : (string)dr["ProName"];
                model.ProCost = dr.IsNull("ProCost") ? null : (System.Double?)dr["ProCost"];
                model.ProSpell = dr.IsNull("ProSpell") ? null : (string)dr["ProSpell"];
                model.ProPrice = dr.IsNull("ProPrice") ? null : (System.Double?)dr["ProPrice"];
                model.ProUnit = dr.IsNull("ProUnit") ? null : (string)dr["ProUnit"];
                model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.ProStock = dr.IsNull("ProStock") ? null : (Int32?)dr["ProStock"];
                model.ProNum = dr.IsNull("ProNum") ? null : (string)dr["ProNum"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                models.Add(model);
            }
            return models;
        }

        public List<ProductInfo> GetAllByCid(int CId)
        {
            string sqlText = @"select * from ProductInfo where CId=" + CId;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<ProductInfo> models = new List<ProductInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductInfo model = toModel(dr);
                models.Add(model);
            }
            return models;
        }

        public List<ProductInfo> GetAllProductInfoByDelFlag(int delFlag)
        {
            string sqlText = @"select * from ProductInfo where DelFlag=" + delFlag;
            DataTable dt = sqlHelper.executeDataTable(sqlText);
            List<ProductInfo> models = new List<ProductInfo>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductInfo model = new ProductInfo();
                model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
                model.CId = dr.IsNull("CId") ? null : (Int32?)dr["CId"];
                model.ProName = dr.IsNull("ProName") ? null : (string)dr["ProName"];
                model.ProCost = dr.IsNull("ProCost") ? null : (System.Double?)dr["ProCost"];
                model.ProSpell = dr.IsNull("ProSpell") ? null : (string)dr["ProSpell"];
                model.ProPrice = dr.IsNull("ProPrice") ? null : (System.Double?)dr["ProPrice"];
                model.ProUnit = dr.IsNull("ProUnit") ? null : (string)dr["ProUnit"];
                model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
                model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
                model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
                model.ProStock = dr.IsNull("ProStock") ? null : (Int32?)dr["ProStock"];
                model.ProNum = dr.IsNull("ProNum") ? null : (string)dr["ProNum"];
                model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
                models.Add(model);
            }
            return models;
        }

        /// <summary>
        /// 通过类别id统计该类别下所有未删除的产品的数量
        /// </summary>
        /// <param name="cId"></param>
        /// <returns></returns>
        public int GetProductInfoCountByCid(int cId)
        {
            string sql = "select COUNT(*) from ProductInfo where DelFlag=0 and CId=" + cId;
            return (int)sqlHelper.executeScalar(sql);
        }

        public DataTable GetProductInfosByLikeProSpellOrProNum(string proSpellOrProNum)
        {
            string sql = "select * from ProductInfo where ProSpell like @ProSpell or ProNum like @ProNum";
            return sqlHelper.executeDataTable(sql,
                new SqlParameter("ProSpell", "%" + proSpellOrProNum + "%"),
                new SqlParameter("ProNum", "%" + proSpellOrProNum + "%"));
        }

        //软删除某一类别的全部产品，返回该类别产品的数量
        public int SoftDeleteProductInfoByProCId(int cId)
        {
            List<ProductInfo> list = GetAllByCid(cId);
            foreach (ProductInfo pro in list)
            {
                SoftDeleteProductInfoByProId((int)pro.ProId);
            }
            return list.Count;
        }

        public int SoftDeleteProductInfoByProId(int id)
        {
            string sql = "update ProductInfo set DelFlag=1 where proid =" + id;
            return sqlHelper.executeNonQuery(sql);
        }

        public ProductInfo toModel(DataRow dr)
        {
            ProductInfo model = new ProductInfo();
            model.ProId = dr.IsNull("ProId") ? null : (Int32?)dr["ProId"];
            model.CId = dr.IsNull("CId") ? null : (Int32?)dr["CId"];
            model.ProName = dr.IsNull("ProName") ? null : (string)dr["ProName"];
            model.ProCost = dr.IsNull("ProCost") ? null : (System.Double?)dr["ProCost"];
            model.ProSpell = dr.IsNull("ProSpell") ? null : (string)dr["ProSpell"];
            model.ProPrice = dr.IsNull("ProPrice") ? null : (System.Double?)dr["ProPrice"];
            model.ProUnit = dr.IsNull("ProUnit") ? null : (string)dr["ProUnit"];
            model.Remark = dr.IsNull("Remark") ? null : (string)dr["Remark"];
            model.DelFlag = dr.IsNull("DelFlag") ? null : (Int32?)dr["DelFlag"];
            model.SubTime = dr.IsNull("SubTime") ? null : (System.DateTime?)dr["SubTime"];
            model.ProStock = dr.IsNull("ProStock") ? null : (Int32?)dr["ProStock"];
            model.ProNum = dr.IsNull("ProNum") ? null : (string)dr["ProNum"];
            model.SubBy = dr.IsNull("SubBy") ? null : (Int32?)dr["SubBy"];
            return model;
        }

        public int update(ProductInfo model)
        {
            object o = DBNull.Value;
            string sqlText = @"update ProductInfo set CId=@CId,ProName=@ProName,ProCost=@ProCost,ProSpell=@ProSpell,ProPrice=@ProPrice,ProUnit=@ProUnit,Remark=@Remark,DelFlag=@DelFlag,SubTime=@SubTime,ProStock=@ProStock,ProNum=@ProNum,SubBy=@SubBy where ProId =@ProId ";
            return sqlHelper.executeNonQuery(sqlText
             , new SqlParameter("ProId", (model.ProId == null) ? o : model.ProId)
             , new SqlParameter("CId", (model.CId == null) ? o : model.CId)
             , new SqlParameter("ProName", (model.ProName == null) ? o : model.ProName)
             , new SqlParameter("ProCost", (model.ProCost == null) ? o : model.ProCost)
             , new SqlParameter("ProSpell", (model.ProSpell == null) ? o : model.ProSpell)
             , new SqlParameter("ProPrice", (model.ProPrice == null) ? o : model.ProPrice)
             , new SqlParameter("ProUnit", (model.ProUnit == null) ? o : model.ProUnit)
             , new SqlParameter("Remark", (model.Remark == null) ? o : model.Remark)
             , new SqlParameter("DelFlag", (model.DelFlag == null) ? o : model.DelFlag)
             , new SqlParameter("SubTime", (model.SubTime == null) ? o : model.SubTime)
             , new SqlParameter("ProStock", (model.ProStock == null) ? o : model.ProStock)
             , new SqlParameter("ProNum", (model.ProNum == null) ? o : model.ProNum)
             , new SqlParameter("SubBy", (model.SubBy == null) ? o : model.SubBy)
            );
        }
    }
}