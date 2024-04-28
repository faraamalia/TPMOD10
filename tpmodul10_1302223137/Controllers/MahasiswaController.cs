using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223137.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa ("Farah Amalia Putri", "1302223137" ),
            new Mahasiswa ("Faris Azhar Dwiputra", "1302223123" ),
            new Mahasiswa ("Wildan Syukri Ni'am", "1302220005"),
            new Mahasiswa ("Muhammad Bintang Al-Fath", "1302223099"),
            new Mahasiswa ("Arga Adolf Lumunon", "1302223038"),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }


        //GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

        //POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswaList.Add(value);
        }
    }
}

