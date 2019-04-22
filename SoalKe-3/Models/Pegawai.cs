using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoalKe_3.Models
{
    public class Pegawai
    {
        private int _golongan = 1;
        public string Nama { get; set; }

        public int Golongan {
            get { return _golongan; }
            set { }
        }
    }
}
