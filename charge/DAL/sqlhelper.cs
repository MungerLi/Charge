/****************************
 
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data ;
using Microsoft.VisualBasic;




namespace DAL
{
    public class sqlhelper
    {
        public static string Connstring = ConfigurationManager.ConnectionStrings["ConnStr"].ToString(); //接收配置文件的连接内容
       
        /// <summary>
        /// 有参数的查询
        /// </summary>
        /// <param name="cmdtxt"> cmdtxt 为执行的sql语句</param>
        /// <param name="cmdType"> 查询时的方式</param>
        /// <param name="paras">查询时的命令参数</param>
        /// <returns> 查询之后以表的形式返回</returns>
        public static DataTable GetDatable(string cmdtxt, CommandType cmdType, SqlParameter[] paras) //datatable 内存中的数据表
        {
            //连接
            SqlConnection conn = new SqlConnection(Connstring);
            //定义命名变量
            SqlCommand cmd = default(SqlCommand);  //? 为什么这里是默认的，没有参数的时候也可以执行，是这个样子的吗？
            //定义数据适配器，dataset内存中的数据缓存
            DataSet dataset = null;
            // 数据连接，叔据适配器 填充dataset 的
            SqlDataAdapter adapter = default(SqlDataAdapter);
            //实例化命名变量
            cmd = new SqlCommand(cmdtxt, conn);
            //命令执行的类型
            cmd.CommandType = cmdType;
            //命令执行的参数
            cmd.Parameters.AddRange(paras);
            //初始化新实例
            adapter = new SqlDataAdapter(cmd);
            dataset = new DataSet();

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(dataset); //填充数据
            }

            //catch (Exception ex)
            //{
            //    //这里暂时没有
               
            //}

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //获取dataset表的集合
            return dataset.Tables[0];
        }

        /// <summary>
        /// 没有参数的查询
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool ExecuteNonquery(string cmdTxt, CommandType cmdType, SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(Connstring)) //创建数据库的链接
            {
                //定义变量名
                SqlCommand cmd = default(SqlCommand);
                //实例化变量名
                cmd = new SqlCommand(cmdTxt, conn);
                //命令类型
                cmd.CommandType = cmdType;
                //命令参数
                //cmd.Parameters.AddRange(sqlparams);
                //打开连接
                conn.Open();
                int count = cmd.ExecuteNonQuery(); //判断返回受影响的行数

                bool flag;
                if (count > 0) { flag = true; }
                else { flag = false; }
                return flag;
            }
        }

        public static void ExecuteNoquery(string cmdTxt, CommandType cmdType, SqlParameter[] paras)
        {
            //创建数据库的连接
            using (SqlConnection conn = new SqlConnection(Connstring ))
            {
                //定义变量名
                SqlCommand cmd = default(SqlCommand);
                //实例化变量名
                cmd = new SqlCommand(cmdTxt, conn);
                //命令类型
                cmd.CommandType = cmdType;
                //命令参数
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                
            }

        }

        #region 没有参数的sqlhelper
        public static DataTable GetDatable(string cmdtxt, CommandType cmdType) //datatable 内存中的数据表
        {
            //连接
            SqlConnection conn = new SqlConnection(Connstring);
            //定义命名变量
            SqlCommand cmd = default(SqlCommand);  //? 为什么这里是默认的，没有参数的时候也可以执行，是这个样子的吗？
            //定义数据适配器，dataset内存中的数据缓存
            DataSet dataset = null;
            // 数据连接，叔据适配器 填充dataset 的
            SqlDataAdapter adapter = default(SqlDataAdapter);
            //实例化命名变量
            cmd = new SqlCommand(cmdtxt, conn);
            //命令执行的类型
            cmd.CommandType = cmdType;
            
            
            //初始化新实例
            adapter = new SqlDataAdapter(cmd);
            dataset = new DataSet();

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(dataset); //填充数据
            }

            //catch (Exception ex)
            //{
            //    //这里暂时没有

            //}

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //获取dataset表的集合
            return dataset.Tables[0];
        }

        #endregion
    }
}
