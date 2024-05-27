using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyNhaTroMain.getset;

namespace QuanLyNhaTroMain.databasecnt
{
    public class ThongTinDKDAO
    {
        DataProvider dp;
        public ThongTinDKDAO()
        {
            dp = new DataProvider();
        }

        public int Insert(string sql, KhachDangKy kdk)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", kdk.Id));
            paras.Add(new SqlParameter("@ho", kdk.Ho));
            paras.Add(new SqlParameter("@ten", kdk.Ten));
            paras.Add(new SqlParameter("@gioitinh", kdk.GioiTinh));
            paras.Add(new SqlParameter("@ngaysinh", kdk.NgaySinh));
            paras.Add(new SqlParameter("@cmnd", kdk.CMND));
            paras.Add(new SqlParameter("@quequan", kdk.QueQuan));
            paras.Add(new SqlParameter("@nghenghiep", kdk.NgheNghiep));
            paras.Add(new SqlParameter("@makhuvuc", kdk.MaKhuVuc));
            paras.Add(new SqlParameter("@maloaiphong", kdk.MaLoaiPhong));

            try
            {
                return (dp.IExecuteNonQuery(sql, System.Data.CommandType.Text, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetDataThongTinDK(string sql)
        {
            DataTable dt = new DataTable();
            dp.Connect();
            try
            {
                dt = dp.GetData(sql);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }

        public int XoaKDK(string sql)
        {
            try
            {
                return dp.DExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
    }
}
