using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        // GET api/
        [HttpGet("{number}")]
        public ActionResult<Dictionary<string, int>> Get(float number)
        {
            float amount = number * 100;
            Dictionary<string, int > change = new Dictionary<string, int>()
            {
                { "100s" , 0 },
                { "50s", 0 },
                { "20s", 0 },
                { "10s", 0 },
                { "5s", 0 },
                { "1s", 0 },
                { "Quarters", 0},
                { "Dimes", 0},
                { "Nickels", 0},
                { "Pennies", 0}

            };
            while(amount > 0)
            {
                if (amount >= 10000) {
                    amount -= 10000;
                    change["100s"]++;
                }else if (amount >= 5000)
                {
                    amount -= 5000;
                    change["50s"]++;
                }else if (amount >= 2000)
                {
                    amount -= 2000;
                    change["20s"]++;
                }else if (amount >=1000)
                {
                    amount -= 1000;
                    change["10s"]++;
                }else if (amount >= 500)
                {
                    amount -= 500;
                    change["5s"]++;
                }else if (amount >= 100)
                {
                    amount -= 100;
                    change["1s"]++;
                }else if (amount >= 25 )
                {
                    amount -= 25;
                    change["Quarters"]++;
                }else if (amount >= 10)
                {
                    amount -= 10;
                    change["Dimes"]++;
                }else if (amount >= 5)
                {
                    amount -= 5;
                    change["Nickels"]++;
                }else
                {
                    amount -= 1;
                    change["Pennies"]++;
                }
            } return change;
        }


    }
}
