using Microsoft.AspNetCore.Mvc;

namespace Marsyarh_1302213003.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pegawai2 : ControllerBase
    {
        public static List<Pegawai> a = new List<Pegawai>
        {
            new Pegawai ("Marsya", "Project Manager"),
            new Pegawai ("Indah", "UI/UX"),
            new Pegawai ("Arya", "Front End Dev"),
            new Pegawai ("Bimo", "Back End Dev"),
        };
        [HttpGet]
        public IEnumerable<Pegawai> Get()
        {
            return a;
        }

        [HttpGet("{id}")]
        public Pegawai Get(int id)
        {
            if(id <0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        [HttpPost]
        public void Post([FromBody] Pegawai value)
        {
            a.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            if (id <0 || id >= a.Count) 
            { 
                NotFound(); 
            }
            a.RemoveAt(id);
        }
    }
};

       
       
