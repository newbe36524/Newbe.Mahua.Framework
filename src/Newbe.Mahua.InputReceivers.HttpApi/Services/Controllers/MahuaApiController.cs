using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers;

namespace Newbe.Mahua.Agents.HttpApi.Services.Controllers
{
    public class MahuaApiController : Controller
    {
        private readonly IMahuaCenter _mahuaCenter;

        public MahuaApiController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }

        /// <summary>
        /// send mahua api request
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public Task Send(
            [FromBody] HttpInput input)
        {
            var send = _mahuaCenter.HandleMahuaInput(input);
            return send;
        }
    }
}