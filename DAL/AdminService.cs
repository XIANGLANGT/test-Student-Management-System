using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdminService
    {
        /// <summary>
        /// 根据用户账号和密码登录
        /// </summary>
        /// <param name="objAdmin">封装了登录账号和密码的用户对象/param>
        /// <returns>返回包含用户信息的对象</returns>
        public Admin AdminLogin(Admin objAdmin)    //用实体类Admin充当数据类型
        {
            //组合SQL语句
            string sql = "select LoginId,LoginPwd,AdminName from Admins where loginId={0} and loginPwd='{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            try
            {
                //从数据库中查询
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())      //如果objReader.Read()返回true则执行if内的语句
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                    objReader.Close();
                }
                else
                {
                    objAdmin = null;  //如果登录不成功，则将当前对象清空
                }
            }
            catch (SqlException)
            {
                throw new Exception("应用程序和数据库连接出现问题！");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objAdmin;
        }

    }
}

