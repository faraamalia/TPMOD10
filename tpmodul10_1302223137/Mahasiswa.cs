namespace tpmodul10_1302223137.Controllers
{

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string Nama, string Nim)
        {
            this.Nama = Nama;
            this.Nim = Nim;
        }
    }
}