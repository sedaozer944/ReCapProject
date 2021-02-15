using Business1.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorSevice;
        public ColorsController(IColorService colorService)
        {
            _colorSevice = colorService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _colorSevice.GetColors();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("add")]
        //public IActionResult Add(Color color)
        //{
        //    var result = _colorSevice.Add(color);
        //    if (true)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
