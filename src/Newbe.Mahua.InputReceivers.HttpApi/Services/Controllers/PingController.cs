using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Newbe.Mahua.Agents.HttpApi.Services.Controllers
{
    public class PingController : Controller
    {
        [HttpGet]
        public Task<string> Ping()
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}