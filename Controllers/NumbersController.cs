using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        public static int numberCache = 10;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("countUp/{number}")]
        public ActionResult<string> Get(int number)
        {
            List<int> Integers = new List<int>();
            for(int i = 1; i <= number; i++)
            {
                Integers.Add(i);
                
            }
            string result = "";
            foreach(int a in Integers)
            {
                if (result == "")
                {
                    result = result + a.ToString();
                }
                else
                {
                    result = result + "," + a.ToString();
                }
            }
            return result;

        }

        [HttpGet("runningSum/{number}")]
        public ActionResult<int> GetSum(int number)
        {
            
            return numberCache += number;
        }


        // GET api/values/5
        [HttpGet("double/{number}")]
        public ActionResult<int> GetDouble(int number)
        {
            return number * 2;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
