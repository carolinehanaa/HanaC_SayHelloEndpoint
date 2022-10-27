/*Caroline Hana
10-25-2022
Say Hello with persons name
Peer Review - Freddy Aguilar - the program takes their mini challenge 1 and converts it to API format. It takes the users input and outputs it on Postman in a sentence greeting the user including their name. Code formatted nicely and easy to read. Everything works as intended.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_SayHelloEndpoint.Controllers
{
    [Route("[controller]")]
    public class SayHello : Controller
    {
        [HttpGet]
        [Route("Hello/{name}")]

        public string hello(string name)
        {
            return $"Hello {name}";
        } 
    }
}