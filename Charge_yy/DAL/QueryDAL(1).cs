/****************************
 * 文件名：LoginDAL
 * 命名空间：DAL
 * 版本号：V1.0.0.0
 * 创建人：刘雅雯
 * 创建时间：2016/12/23 11:55:41
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;
using System.Data.SqlClient;
using System.Reflection;


namespace DAL
{
    class QueryDAL :IDal.ICheck 
    {
        

       // public DataTable SelectUser(Entity.User User) //之前用的都是datatable
       public IList <Entity.User> SelectUser(Entity.User User)
        {
            //SqlParameter[] sqlParams = { new SqlParameter("@userID", UserInfo.UserID ), new SqlParameter("@pwd", UserInfo.PassWord ) };
            SqlParameter[] sqlParams = {new SqlParameter("@userID", User.UserID)};
            //string sql ="select * from User_info where UserID=@userID and PassWord=@pwd";
            string sql = @"select * from User_info where UserID=@userID";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text , sqlParams);
           //IList<Entity.User> users =
            IList<Entity.User > user = DAL.CovertHelper<Entity.User >.ConvertToModel(table);
            return user;
            //return table; //之前用的都是datatable
        }             
    }

    #region 查询学生的基本信息--2017.01.08
    //查询学生信息,返回值为表
    class StudentDAL :IDal.IqueryStudnet 
    {
        public  IList<Entity.Student > SelectUser(Entity.Student student)
        {

            SqlParameter[] sqlParams = { new SqlParameter("@StudentNo", student.StudentNo) };
            string sql = "select * from Student_info where StudentNo =@StudentNo";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlParams);
            IList<Entity.Student> Student = DAL.CovertHelper<Entity.Student >.ConvertToModel(table);
            return Student;
        }

    }
#endregion

    #region 查询学生金额--2017.01.09
    class StudentMoneyDAL : IDal.IqueryCard  
    {


        public IList<Entity.Card> Select(Entity.Card card)
        {
           
            SqlParameter[] sqlParams = { new SqlParameter("@CardNo", card.CardNo) };
            string sql = "select * from Card_info where CardNo = @CardNo";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlParams);
            IList<Entity.Card> Card = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
            return Card;

        }
    }
 
#endregion


    #region 查询卡号是否注册--2017.1.15
    class IsExitCardNoDAL : IDal.IqueryCard
    {
        public IList<Entity.Card> Select(Entity.Card card)
        {
            if (card.CardNo== 0 )
            {
                SqlParameter[] sqlparams = {//new SqlParameter ("@CardNo",card.CardNo ),
                                            new SqlParameter ("@StudentNo",card.StudentNo ),
                                            new SqlParameter ("@Notes","使用")};
                string sql = "select * from Card_info where studentno = @StudentNo and notes =@Notes ";
                DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
                IList<Entity.Card> Card = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
                return Card;
            }
            else
            {
                SqlParameter[] sqlparams = {new SqlParameter ("@CardNo",card.CardNo ),
                                            //new SqlParameter ("@StudentNo",card.StudentNo ),
                                            new SqlParameter ("@Notes","使用")};
                string sql = "select * from Card_info where cardno = @CardNo and notes =@Notes ";
                DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
                IList<Entity.Card> Card = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
                return Card;
            }
            
            
        }

    }
 

#endregion

#region 查询是否有该卡号--2017.01.19
    class IsExitCardno : IDal.IqueryCard
    {
        public IList<Entity.Card> Select(Entity.Card card)
        {
            SqlParameter[] sqlparams = {new SqlParameter ("@CardNo",card.CardNo ),
                                            //new SqlParameter ("@StudentNo",card.StudentID ),
                                            new SqlParameter ("@Notes","使用")};
            string sql = "select * from Card_info where cardno = @CardNo and notes =@Notes ";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
            IList<Entity.Card> Card = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
            return Card;
        }
    }
 
    
#endregion

#region 查询是否正在上机--2017.01.20
    class IsOnline : IDal.IOnline
    {
        public IList<Entity.online> select(Entity.online online)
        {
            SqlParameter[] sqlparams = { new SqlParameter ("@cardno", online.CardNo) };
            string sql;
            if (online.CardNo==0)
            {
                sql = "select * from online_info ";
            }
            else
            {
                 sql = "select * from online_info where cardno=@cardno ";
                
            }
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
            IList<Entity.online> lOnline = DAL.CovertHelper<Entity.online>.ConvertToModel(table);
            return lOnline;
        }
    }
 
#endregion

#region 查询上机记录 2017-01-23
    class QuerLine : IDal.IQueryline
    {
        public IList<Entity.line> select(Entity.line line)
        {
            SqlParameter[] sqlparams ={new SqlParameter ("@cardno",line.CardNo ),
                                        new SqlParameter ("@loginDate",line.LoginDate ),
                                          new SqlParameter ("@logintime",line.LoginTime ),
                                      };
            string sql = "select * from line_info where cardno = @cardno and logindate = @loginDate and logintime =@logintime ";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
            IList<Entity.line> Lline = DAL.CovertHelper<Entity.line>.ConvertToModel(table);
            return Lline;

        }
    }
 

#endregion

#region 得到basicdate的数据--2017.01.23
    class BasicDateDAL : IDal.IqueryBasicdate
    {
       

        public IList<Entity.BasicData> select(Entity.BasicData basicdate)
        {
            SqlParameter[] sqlparams = { null };
            string sql = "select * from basicdata_info ";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text);
            IList<Entity.BasicData> LBasicDate = DAL.CovertHelper<Entity.BasicData>.ConvertToModel(table);
            return LBasicDate;
        }
    }
 

#endregion

#region  查询card中的金额
    //class CardDal : IDal.IqueryCard
    //{
    //    public IList<Entity.Card> Select(Entity.Card card)
    //    {
    //        SqlParameter[] sqlparams = { new SqlParameter("@cardno", card.CardNo) };
    //        string sql = "select * from card_info where cardno=@cardno";
    //        DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
    //        IList<Entity.Card> LCard = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
    //        return LCard;
    //    }




        
    //}
 

#endregion

#region 组合查询的存储过程
    class QueryGroupDal : IDal.IGroupQuery
    {
       /* public IList<Entity.GroupQuery> select(Entity.GroupQuery GroupCheck)
        {
            
           // SqlParameter[] sqlparams = {new SqlParameter ("@Field1",GroupCheck.fileds1 ),
           //                                 new SqlParameter ("@Field2",GroupCheck.fileds2 ),
           //                                 new SqlParameter ("@Field3",GroupCheck.fileds3 ),

           //                                 new SqlParameter ("@Operator1",GroupCheck.Operator1 ),
           //                                 new SqlParameter ("@Operator2",GroupCheck.Operator2 ),
           //                                 new SqlParameter ("@Operator3",GroupCheck.Operator3 ),

           //                                 new SqlParameter ("@Context1",GroupCheck.Context1 ),
           //                                 new SqlParameter ("@Context2",GroupCheck.Context2 ),
           //                                 new SqlParameter ("@Context3",GroupCheck.Context3 ),

           //                                 new SqlParameter ("@Relation1",GroupCheck.Relation1 ),
           //                                 new SqlParameter ("@Relation2",GroupCheck.Relation2 )
                                       
           //                                 //new SqlParameter ("@table",GroupCheck.table )
           //                             };
           // string sql ="GroupCheck";
           // //string y="select * from worklog_info where "+ GroupCheck.fileds1 + GroupCheck.Operator1 + GroupCheck.Context1;
           // //string sql;
           //// //拼接语句
           ////// sql = "select * from @table where @Field1 @Operator1 @Context1";
           //// sql = @"select * from @table where @Field1= @Context1";
           // DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.StoredProcedure  , sqlparams);
            IList<Entity.GroupQuery> LgroupQuery = DAL.CovertHelper<Entity.GroupQuery>.ConvertToModel(table);
            return LgroupQuery;
        }
        */
        
        DataTable IDal.IGroupQuery.select(Entity.GroupQuery GroupCheck)
        {
            SqlParameter[] sqlparams = {new SqlParameter ("@Field1",GroupCheck.fileds1 ),
                                            new SqlParameter ("@Field2",GroupCheck.fileds2 ),
                                            new SqlParameter ("@Field3",GroupCheck.fileds3 ),

                                            new SqlParameter ("@Operator1",GroupCheck.Operator1 ),
                                            new SqlParameter ("@Operator2",GroupCheck.Operator2 ),
                                            new SqlParameter ("@Operator3",GroupCheck.Operator3 ),

                                            new SqlParameter ("@Context1",GroupCheck.Context1 ),
                                            new SqlParameter ("@Context2",GroupCheck.Context2 ),
                                            new SqlParameter ("@Context3",GroupCheck.Context3 ),

                                            new SqlParameter ("@Relation1",GroupCheck.Relation1 ),
                                            new SqlParameter ("@Relation2",GroupCheck.Relation2 )
                                       
                                            //new SqlParameter ("@table",GroupCheck.table )
                                        };
            string sql = "worklog_info";
            if (GroupCheck.table == "worklog_info")
            {
                sql = "GroupCheck";
            }

            if (GroupCheck.table == "line")
            {
                sql = "Groupline";
            }

            if (GroupCheck.table == "Student")
            {
                sql = "GroupStudent";
            }
            

            //string sql = GroupCheck.table;
            //switch (sql)
            //{
            //    case "worklog_info":
            //       return  "GroupCheck";
            //    case "line":
            //        return  "Groupline";
            //    //case "":
            //    //    sql = "";

            //}
            ////string sql = "GroupCheck";


            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.StoredProcedure, sqlparams);
            return table;
        }
    }

    #endregion

#region 结账，将操作员和管理员自动填入
    class QueryUserDAL : IDal.IQueryUser
    {
        public IList<Entity.User> select(Entity.User user)
        {
            //throw new NotImplementedException();
            IList<Entity.User> Luser;          
            string sql;

            //条件：实体没有传过来参数
            if (user.UserID == null)
            {
              SqlParameter[] sqlparams = { //new SqlParameter ("@userID",user.UserID ),
                                           new SqlParameter ("@lever","管理员" ),
                                           new SqlParameter ("@lever2","操作员" )
                                       
                                       };
                 sql = "select * from user_info where level=@lever or level=@lever2 ";
                 DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
                  Luser = DAL.CovertHelper<Entity.User>.ConvertToModel(table);
            }
                //条件：实体传递过来参数的时候
            else
            {
                SqlParameter[] sqlparamsB = { new SqlParameter ("@userID",user.UserID ),
                                           new SqlParameter ("@lever","管理员" ),
                                           new SqlParameter ("@lever2","操作员" )
                                       
                                       };
                 sql = "select * from user_info where userID=@userID";
                 DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparamsB);
                  Luser = DAL.CovertHelper<Entity.User>.ConvertToModel(table);
            }
            //DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlparams);
            //IList<Entity.User> Luser = DAL.CovertHelper<Entity.User>.ConvertToModel(table);
            return Luser;
        }
    }
 
#endregion

#region 查询onwork补充worklog
    class QueryOnwork : IDal.IqueryOnwork
    {

        public IList<Entity.onWork > select(Entity.onWork onwork)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = {
                                      new SqlParameter ("@userID",onwork.UserID )
                                   };
            string sql = "select * from onwork_info where userID=@userID ";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, para );
            IList<Entity.onWork> lOnwork = DAL.CovertHelper<Entity.onWork>.ConvertToModel(table);
            return lOnwork ;
        }
    }
#endregion

}
