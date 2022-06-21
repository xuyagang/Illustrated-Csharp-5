using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Test
{
    internal class SqlServerTest
    {
        static void Main()
        {
            Console.WriteLine("请输入账号：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();

            // 连接字符串
            string strConn = @$"Server=GSX-553; Database=DbTest; uid={userName}; pwd={password}";
            // 连接对象
            SqlConnection conn = new SqlConnection(strConn);
            // 打开数据库
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
                Console.WriteLine("数据库已连接");
            }
            else
                Console.WriteLine("数据库已开启，打开失败");
            

            // 数据库操作
            string sql = "select * from tbTest where Id=4";   // 定义查询语句
            SqlCommand cmd = new SqlCommand(sql, conn);
            // //返回影响的行数
            Console.WriteLine(cmd.ExecuteNonQuery());

            // 读取返回值
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string tempName = Convert.ToString(reader["Name"]);
                string tempName1 = Convert.ToString(reader["Address"]);
                string tempName2 = Convert.ToString(reader["City"]);
                Console.WriteLine($"{tempName}-{tempName1}-{tempName2}");
            }

            // 关闭数据库
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            Console.WriteLine("数据库已关闭");

        }
    }
}
