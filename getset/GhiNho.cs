using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTroMain.getset
{
    public class GhiNho
    {
        public string ID { get; set; }
        public string pass { get; set; }
        public GhiNho(string ID, string pass)
        {
            this.ID = ID;
            this.pass = pass;
        }
    }
}
