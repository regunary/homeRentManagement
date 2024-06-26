﻿using QuanLyNhaTroMain.databasecnt;
using QuanLyNhaTroMain.getset;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTroMain.cntdatafrm
{
    public class ThongTinDKBUS
    {
        public int Insert(string sql, KhachDangKy kdk)
        {
            try
            {
                return new ThongTinDKDAO().Insert(sql, kdk);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetThongTinDK(string sql)
        {
            try
            {
                DataTable result = new ThongTinDKDAO().GetDataThongTinDK(sql);
                return result;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int XoaKDK(string sql)
        {
            try
            {
                return (new ThongTinDKDAO().XoaKDK(sql));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
