using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace tpmodul9_1302210001
{
    [Route("api/[controller]")]
    [ApiController]

    public class Mahasiswa
    {
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "Bintang Rayhan Wijaya", Nim = "1302213002"},
            new mahasiswa {Nama = "Rayhan Wijaya Bintang", Nim = "1302213003"},
            new mahasiswa {Nama = "Wijaya Bintang Rayhan ", Nim = "1302213004"},
            new mahasiswa {Nama = "Prima Mahendra Yazadi", Nim = "1302210001"},
            new mahasiswa {Nama = "Mahendra Yazadi Prima", Nim = "1302210001"}
        };

       

        
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        
        [HttpGet("{id}")]
        public mahasiswa Get(int id)
        {
            return mhs[id];
        }

         
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}
