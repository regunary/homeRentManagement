using QuanLyNhaTroMain.databasecnt;
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
    public class LoaiPhongBUS
    {
        public List<LoaiPhong> GetLoaiPhong(string sql)
        {
            try
            {
                List<LoaiPhong> tmp = new LoaiPhongDAO().GetLoaiPhong(sql);
                return tmp;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable GetLoaiPhongDA()
        {
            try
            {
                DataTable tmp = new LoaiPhongDAO().GetDataLoaiPhong();
                return tmp;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetLoaiPhongDA(string makhuvuc)
        {
            try
            {
                DataTable tmp = new LoaiPhongDAO().GetDataLoaiPhong(makhuvuc);
                return tmp;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
