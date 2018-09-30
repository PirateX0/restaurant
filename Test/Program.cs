using System;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    internal class Program
    {
        private int myproperty;

        public int MYPROPERTY
        {
            get { return myproperty; }
            set { myproperty = value; }
        }

        private static void Main(string[] args)
        {
            #region 参数化查询中对于'号中的%号的处理

            //MyClass c = null;
            //c = new MyClass();
            //c.MyPropertyId = 100;
            //Console.WriteLine(c.MyPropertyId);

            //参数化查询中对于'号中的%号的处理
            //string MemName="金";
            //错误写法
            //string sql = "select MemName from MemberInfo where MemName like '%@MemName%'";
            //DataTable table = SQLHelper.ExecuteQuery(sql, new SqlParameter("MemName", MemName));
            //推荐写法
            //string sql = "select MemName from MemberInfo where MemName like @MemName";
            //DataTable table = SQLHelper.ExecuteQuery(sql, new SqlParameter("MemName","%"+MemName+"%"));
            //正确写法
            //返回的SQL为select MemName from MemberInfo where MemName like '%'+'金'+'%'
            //支持SQL，但不支持MySQL
            //string sql = "select MemName from MemberInfo where MemName like '%'+@MemName+'%'";
            //DataTable table = SQLHelper.ExecuteQuery(sql, new SqlParameter("MemName",  MemName ));

            //foreach (DataRow row in table.Rows)
            //{
            //    Console.WriteLine(row["MemName"]);
            //}

            #endregion 参数化查询中对于'号中的%号的处理

            #region 向数据库中插入Null

            //sqlsever中可以直接插入null吗,不可以，只能插入DBNull.Value
            //mysql可以直接插入null
            //try
            //{
            //    string sql = "insert into t_persons(name,age) values(@name,@age)";
            //    SqlParameter[] pars = {
            //                            new SqlParameter("@name","1115"),
            //                            new SqlParameter("@age",DBNull.Value)
            //                        };
            //    SQLHelper.ExecuteNonQuery(sql, pars);
            //    Console.WriteLine("ok!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error T.T" + ex.Message);
            //}

            #endregion 向数据库中插入Null

            #region sqlserver中datetime的默认值

            //string sql = "insert into t_persons(name) values('lll')";
            //SQLHelper.ExecuteNonQuery(sql);
            //string sql = "insert into t_persons(name,birthday) values('lll',@birthday)";
            //DateTime? time = null;
            //SQLHelper.ExecuteNonQuery(sql, new SqlParameter("@birthday", DBNull.Value));
            //Console.WriteLine("ok");
            //sql = "select * from t_persons";
            //DataTable table = SQLHelper.ExecuteQuery(sql);
            //foreach (DataRow row in table.Rows)
            //{
            //    Console.WriteLine(row["birthday"]);
            //}

            #endregion sqlserver中datetime的默认值

            Console.ReadKey();
        }
    }
}