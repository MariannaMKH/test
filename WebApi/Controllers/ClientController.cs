using DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;

namespace WebApi.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        /// <summary>
        /// Get client report
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="from"> from date when report is needded- DateTime</param>
        /// <param name="to"> to what date - DateTime</param>
        /// <returns></returns>

        [System.Web.Http.HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<HistoryCheck>))]
        public IActionResult GetClientReport(int clientId, DateTime from, DateTime to)
        {
            var rep = new List<HistoryCheck>();
            using (var bl = Startup.CoreBlFactory.CreateIClientsBL())
            {
                rep = bl.GetHistoryForClient(clientId, from, to);
            }
            return Ok(rep);
        }
    }
}
