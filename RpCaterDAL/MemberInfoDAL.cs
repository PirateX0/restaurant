using RpCater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    /// <summary>
    /// 遇到多表联合问题，无法使用model。
    /// </summary>
    public class MemberInfoDAL
    {
        //我觉得没必要这么搞两个方法，既然都已经有了合并的方法。
        //其实这么搞没错，符合函数单一功能的原则。。
        //        public int AddMemberInfo(MemberInfo member)
        //        {
        //            string sql = @"insert into MemberInfo( MemName, MemMobilePhone, MemAddress, MemType, MemNum, MemGender, MemDiscount, MemMoney, DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday)
        //                           values(@MemName, @MemMobilePhone, @MemAddress, @MemType, @MemNum, @MemGender, @MemDiscount, @MemMoney, @DelFlag, @SubTime, @MemIntegral, @MemEndTime, @MemBirthday)";
        //            return AddOrUpdateMemberInfo(member,sql,MemberStatus.Insert);
        //        }

        //        public int UpdateMemberInfo(MemberInfo member)
        //        {
        //            string sql = @"update MemberInfo set MemName=@MemName, MemMobilePhone=@MemMobilePhone, MemAddress=@MemAddress, MemType=@MemType, MemNum=@MemNum, MemGender=@MemGender, MemDiscount=@MemDiscount, MemMoney=@MemMoney, DelFlag=@DelFlag, SubTime=@SubTime, MemIntegral=@MemIntegral, MemEndTime=@MemEndTime, MemBirthday=@MemBirthday
        //                           where MemberId=@MemberId";
        //            return AddOrUpdateMemberInfo(member,sql,MemberStatus.Update);
        //        }

        public void AddMemberListUsingTransaction(List<MemberInfo> memberList)
        {
            using (SqlConnection con = new SqlConnection(sqlHelper.conStr))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    foreach (MemberInfo member in memberList)
                    {
                        string sql = @"insert into MemberInfo( MemName, MemMobilePhone, MemAddress, MemGender,MemMoney)
                           values(@MemName, @MemMobilePhone, @MemAddress, @MemGender,  @MemMoney)";
                        SqlParameter[] paramaterArray = new SqlParameter[]
                        {
                            new SqlParameter("MemName",member.MemName),
                            new SqlParameter("MemMobilePhone",member.MemMobilePhone),
                            new SqlParameter("MemAddress",member.MemAddress),
                            new SqlParameter("MemGender",member.MemGender),
                            new SqlParameter("MemMoney",member.MemMoney)
                        };
                        sqlHelper.executeNonQuery(con, tran, sql, paramaterArray);
                    }
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public int AddOrUpdateMemberInfo(MemberInfo member, HandleStatus status)
        {
            string sql = null;
            List<SqlParameter> list = new List<SqlParameter>();
            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("MemName",member.MemName),
             new SqlParameter("MemMobilePhone",member.MemMobilePhone),
             new SqlParameter("MemAddress",member.MemAddress),
             new SqlParameter("MemType",member.MemType),
             new SqlParameter("MemNum",member.MemNum),
             new SqlParameter("MemGender",member.MemGender),
             new SqlParameter("MemDiscount",member.MemDiscount),
             new SqlParameter("MemMoney",member.MemMoney),
             new SqlParameter("DelFlag",member.DelFlag),
             new SqlParameter("SubTime",member.SubTime),
             new SqlParameter("MemIntegral",member.MemIntegral),
             new SqlParameter("MemEndTime",member.MemEndTime),
             new SqlParameter("MemBirthday",member.MemBirthday)
            };
            list.AddRange(parameters);
            if (status == HandleStatus.Insert)
            {
                sql = @"insert into MemberInfo( MemName, MemMobilePhone, MemAddress, MemType, MemNum, MemGender, MemDiscount, MemMoney, DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday)
                           values(@MemName, @MemMobilePhone, @MemAddress, @MemType, @MemNum, @MemGender, @MemDiscount, @MemMoney, @DelFlag, @SubTime, @MemIntegral, @MemEndTime, @MemBirthday)";
            }
            if (status == HandleStatus.Update)
            {
                list.Add(new SqlParameter("MemberId", member.MemberId));
                sql = @"update MemberInfo set MemName=@MemName, MemMobilePhone=@MemMobilePhone, MemAddress=@MemAddress, MemType=@MemType, MemNum=@MemNum, MemGender=@MemGender, MemDiscount=@MemDiscount, MemMoney=@MemMoney, DelFlag=@DelFlag, SubTime=@SubTime, MemIntegral=@MemIntegral, MemEndTime=@MemEndTime, MemBirthday=@MemBirthday
                           where MemberId=@MemberId";
            }
            return sqlHelper.executeNonQuery(sql, list.ToArray());
        }

        public int AddOrUpdateMemberInfo(SqlConnection con, SqlTransaction tran, MemberInfo member, HandleStatus status)
        {
            string sql = null;
            List<SqlParameter> list = new List<SqlParameter>();
            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("MemName",member.MemName),
             new SqlParameter("MemMobilePhone",member.MemMobilePhone),
             new SqlParameter("MemAddress",member.MemAddress),
             new SqlParameter("MemType",member.MemType),
             new SqlParameter("MemNum",member.MemNum),
             new SqlParameter("MemGender",member.MemGender),
             new SqlParameter("MemDiscount",member.MemDiscount),
             new SqlParameter("MemMoney",member.MemMoney),
             new SqlParameter("DelFlag",member.DelFlag),
             new SqlParameter("SubTime",member.SubTime),
             new SqlParameter("MemIntegral",member.MemIntegral),
             new SqlParameter("MemEndTime",member.MemEndTime),
             new SqlParameter("MemBirthday",member.MemBirthday)
            };
            list.AddRange(parameters);
            if (status == HandleStatus.Insert)
            {
                sql = @"insert into MemberInfo( MemName, MemMobilePhone, MemAddress, MemType, MemNum, MemGender, MemDiscount, MemMoney, DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday)
                           values(@MemName, @MemMobilePhone, @MemAddress, @MemType, @MemNum, @MemGender, @MemDiscount, @MemMoney, @DelFlag, @SubTime, @MemIntegral, @MemEndTime, @MemBirthday)";
            }
            if (status == HandleStatus.Update)
            {
                list.Add(new SqlParameter("MemberId", member.MemberId));
                sql = @"update MemberInfo set MemName=@MemName, MemMobilePhone=@MemMobilePhone, MemAddress=@MemAddress, MemType=@MemType, MemNum=@MemNum, MemGender=@MemGender, MemDiscount=@MemDiscount, MemMoney=@MemMoney, DelFlag=@DelFlag, SubTime=@SubTime, MemIntegral=@MemIntegral, MemEndTime=@MemEndTime, MemBirthday=@MemBirthday
                           where MemberId=@MemberId";
            }
            return sqlHelper.executeNonQuery(con, tran, sql, list.ToArray());
        }

        public List<MemberInfo> GetAllMemberInfoByDelFlag(int delFlag)
        {
            List<MemberInfo> list = null;
            string sql = "select * from MemberInfo where delFlag =" + delFlag;
            //            string sql=
            //            @"select b.MemTypeName,MemberId, MemName, MemMobilePhone, MemAddress, a.MemType, MemNum, MemGender, MemDiscount, MemMoney, a.DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday
            //             from MemberInfo a
            //             left join MemberType b
            //             on a.MemType =b.MemType
            //             where  a.delFlag = "+delFlag;
            DataTable table = SQLHelper.ExecuteQuery(sql);
            if (table.Rows.Count > 0)
            {
                list = new List<MemberInfo>();
                foreach (DataRow row in table.Rows)
                {
                    list.Add(GetMemberInfoByDataRow(row));
                }
            }
            return list;
        }

        public MemberInfo GetMemberInfoById(int id)
        {
            string sql = "select * from MemberInfo where MemberId=" + id;
            DataTable table = sqlHelper.executeDataTable(sql);
            return GetMemberInfoByDataRow(table.Rows[0]);
        }

        public DataTable GetMemberInfoDataTableByDelFlag(int delFlag)
        {
            string sql =
             @"select b.MemTypeName,MemberId, MemName, MemMobilePhone, MemAddress, a.MemType, MemNum, MemGender, MemDiscount, MemMoney, a.DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday
             from MemberInfo a
             left join MemberType b
             on a.MemType =b.MemType
             where  a.delFlag = " + delFlag;
            return sqlHelper.executeDataTable(sql);
        }

        public DataTable GetMemberInfoDataTableLikeMemName(string memName)
        {
            string sql =
                         @"select b.MemTypeName,MemberId, MemName, MemMobilePhone, MemAddress, a.MemType, MemNum, MemGender, MemDiscount, MemMoney, a.DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday
                         from MemberInfo a
                         left join MemberType b
                         on a.MemType =b.MemType
                         where a.DelFlag=0 and MemName like @MemName";
            return SQLHelper.ExecuteQuery(sql, new SqlParameter("MemName", "%" + memName + "%"));
        }

        public List<MemberInfo> GetMemberInfoLikeMemName(string memName)
        {
            List<MemberInfo> list = null;
            string sql = "select * from MemberInfo where DelFlag=0 and MemName like @MemName";
            //            string sql=
            //            @"select b.MemTypeName,MemberId, MemName, MemMobilePhone, MemAddress, a.MemType, MemNum, MemGender, MemDiscount, MemMoney, a.DelFlag, SubTime, MemIntegral, MemEndTime, MemBirthday
            //             from MemberInfo a
            //             left join MemberType b
            //             on a.MemType =b.MemType
            //            where a.DelFlag=0 and MemName like @MemName";
            DataTable table = SQLHelper.ExecuteQuery(sql, new SqlParameter("MemName", "%" + memName + "%"));
            if (table.Rows.Count > 0)
            {
                list = new List<MemberInfo>();
                foreach (DataRow row in table.Rows)
                {
                    list.Add(GetMemberInfoByDataRow(row));
                }
            }
            return list;
        }

        public int SoftDeleteMemberInfo(int id, int delFlag)
        {
            string sql = "update MemberInfo set DelFlag =" + delFlag + " where MemberId =" + id;
            return SQLHelper.ExecuteNonQuery(sql);
        }

        //累成狗了啊！
        private MemberInfo GetMemberInfoByDataRow(DataRow row)
        {
            DateTime time = Convert.ToDateTime("1900-01-01");
            MemberInfo info = new MemberInfo();
            info.DelFlag = row.IsNull("DelFlag") ? 0 : int.Parse(row["DelFlag"].ToString());
            info.MemAddress = row.IsNull("MemAddress") ? null : row["MemAddress"].ToString();
            info.MemberId = int.Parse(row["MemberId"].ToString());
            info.MemBirthday = row.IsNull("MemBirthday") ? time : Convert.ToDateTime(row["MemBirthday"].ToString());
            info.MemDiscount = row.IsNull("MemDiscount") ? 0 : float.Parse(row["MemDiscount"].ToString());
            info.MemEndTime = row.IsNull("MemEndTime") ? time : Convert.ToDateTime(row["MemEndTime"].ToString());
            info.MemGender = row.IsNull("MemGender") ? null : row["MemGender"].ToString();
            info.MemIntegral = row.IsNull("MemIntegral") ? 0 : int.Parse(row["MemIntegral"].ToString());
            info.MemMobilePhone = row.IsNull("MemMobilePhone") ? null : row["MemMobilePhone"].ToString();
            info.MemMoney = row.IsNull("MemMoney") ? 0 : float.Parse(row["MemMoney"].ToString());
            info.MemName = row.IsNull("MemName") ? null : row["MemName"].ToString();
            info.MemNum = row.IsNull("MemNum") ? null : row["MemNum"].ToString();
            info.MemType = row.IsNull("MemType") ? 0 : int.Parse(row["MemType"].ToString());
            info.SubTime = row.IsNull("SubTime") ? time : Convert.ToDateTime(row["SubTime"].ToString());

            return info;
        }
    }
}