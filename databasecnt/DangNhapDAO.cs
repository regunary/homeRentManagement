﻿using QuanLyNhaTroMain.getset;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTroMain.databasecnt
{
    public class DangNhapDAO
    {
        private DataProvider dp;

        public DangNhapDAO()
        {
            dp = new DataProvider();
        }
        public int Log(string sql, string id, string pass)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", id));
            paras.Add(new SqlParameter("@pw", pass));
            try
            {
                //SqlConnection cn = new SqlConnection(@"Server = USER-PC\KDC; Database = QLPhongTro; Integrated Security = true;");
                //cn.Open();

                int x = (int)dp.exeCuteScalarQuery(sql, System.Data.CommandType.Text, paras);
                return x;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        public List<GhiNho> getGN(string sql)
        {
            List<GhiNho> list = new List<GhiNho>();
            string id, pass;
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    id = dr.GetString(0).Trim();
                    pass = dr.GetString(1).Trim();

                    GhiNho gn = new GhiNho(id, pass);
                    list.Add(gn);
                }
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        public int Save(string id, string pass)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@ID", id));
            paras.Add(new SqlParameter("@Pass", pass));
            try
            {
                return (dp.IExecuteNonQuery("saveP", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Xoa()
        {
            try
            {
                return (dp.DExecuteNonQuery("Xoa", System.Data.CommandType.StoredProcedure));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int ChangePass(string id, string newPass)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@ID", id));
            paras.Add(new SqlParameter("@Pass", newPass));
            try
            {
                return (dp.IExecuteNonQuery("ChangePass", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int ThemTK(string sql, DangNhap dn)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@ID", dn.ID));
            paras.Add(new SqlParameter("@pass", dn.PassWord));
            try
            {
                return (dp.IExecuteNonQuery(sql, System.Data.CommandType.Text, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
