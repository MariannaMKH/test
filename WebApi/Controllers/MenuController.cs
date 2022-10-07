using DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        /// <summary>
        /// Get menu report
        /// </summary>
        /// <param name="from"> From date needed</param>
        /// <param name="to"> To date</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Menu>))]
        public IActionResult GetMenuReport( DateTime from, DateTime to)
        {
            var rep = new List<Menu>();
            using (var bl = Startup.CoreBlFactory.CreateMenuBL())
            {
                rep = bl.GetMenues(from, to);
            }
            return Ok(rep);
        }
    }
}
