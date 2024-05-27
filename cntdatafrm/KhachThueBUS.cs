using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaTroMain
{
    public class KhachThueBUS
    {
        public List<KhachThue> GetKhach_List(string sql)
        {
            try
            {
                List<KhachThue> result = new KhachThueDAO().GetKhachThue(sql);
                return result;
            }
            catch (SqlException ex)
            {
                
                throw ex ;
            }
        }


        public DataTable GetKhach(string maphong)
        {
            try
            {
                DataTable result = new KhachThueDAO().GetData(maphong);
                return result;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DataTable GetKhachTheoMaPhong(string sql)
        {
            try
            {
                DataTable result = new KhachThueDAO().GetDataChung(sql);
                return result;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Insert(string sql,KhachThue kt)
        {
            try
            {
                return new KhachThueDAO().Insert(sql, kt);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        
    }
}