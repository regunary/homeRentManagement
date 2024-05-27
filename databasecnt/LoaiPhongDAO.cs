using QuanLyNhaTroMain.getset;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTroMain.databasecnt
{
    public class LoaiPhongDAO
    {
        private DataProvider dp;

        public LoaiPhongDAO()
        {
            dp = new DataProvider();
        }
        public List<LoaiPhong> GetLoaiPhong(string sql)
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            string ma, ten, ghichu;
            int dientich, dongia;
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    ma = dr.GetString(0);
                    ten = dr.GetString(1);
                    dientich = dr.GetInt16(2);
                    dongia = dr.GetInt16(3);
                    ghichu = dr.GetString(4);

                    LoaiPhong pro = new LoaiPhong(ma, ten, dientich, dongia, ghichu);
                    list.Add(pro);
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



        public DataTable GetDataLoaiPhong()
        {
            string sql = "SELECT * FROM LoaiPhong";
            DataTable da = dp.ExecuteAdapter(sql);
            return da;
        }

        public DataTable GetDataLoaiPhong(string maloaiphong)
        {
            string sql = "SELECT * FROM Phong WHERE MaLoaiPhong = '" + maloaiphong + "'";
            DataTable da = dp.GetData(sql);
            return da;
        }
    }
}
