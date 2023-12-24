using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiInputDataMahasiswa
{
    class Mahasiswa
    {
        public string Nim;
        public string Nama;
        public string Kelas;
        public string NilaiHuruf;
        private int nilai;
        public int Nilai { get { return Nilai; } set
            {
                int val = value;
                Nilai = val;
                if(val > 81)
                {
                    NilaiHuruf = "A";
                }
                else if (val > 61)
                {
                    NilaiHuruf = "B";
                }
                else if (val > 41)
                {
                    NilaiHuruf = "C";
                }
                else if (val > 21)
                {
                    NilaiHuruf = "D";
                }
                else if (val > 0)
                {
                    NilaiHuruf = "E";
                }

            } }

    }
}
