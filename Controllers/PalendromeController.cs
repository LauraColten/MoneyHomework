using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalendromeController : Controller
    {
        // GET api/
        [HttpGet("{word}")]
        public ActionResult<bool> Get(string word)

        {
            char [] splitWord = word.ToCharArray();

            for(int i = 0; i < splitWord.Length / 2; i++)
            {
                if (splitWord[i] != splitWord[splitWord.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}