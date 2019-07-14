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
            float amount = number;
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
                if (amount >= 100.00) {
                    amount -= 100.00F;
                    change["100s"]++;
                }else if (amount >= 50.00)
                {
                    amount -= 50.00F;
                    change["50s"]++;
                }else if (amount >= 20.00)
                {
                    amount -= 20.00F;
                    change["20s"]++;
                }else if (amount >=10.00)
                {
                    amount -= 10.00F;
                    change["10s"]++;
                }else if (amount >= 5.00)
                {
                    amount -= 5.00F;
                    change["5s"]++;
                }else if (amount >= 1.00)
                {
                    amount -= 1.00F;
                    change["1s"]++;
                }else if (amount >= 0.25 )
                {
                    amount -= 0.25F;
                    change["Quarters"]++;
                }else if (amount >= 0.10)
                {
                    amount -= 0.10F;
                    change["Dimes"]++;
                }else if (amount >= 0.05)
                {
                    amount -= 0.05F;
                    change["Nickels"]++;
                }else
                {
                    amount -= 0.01F;
                    change["Pennies"]++;
                }
            } return change;
        }


    }
}
