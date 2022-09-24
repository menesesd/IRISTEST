using API.Wrapper;
using Application.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessFileController : ControllerBase
    {

        private readonly IProcessFileService _processFileService;
        public ProcessFileController(IProcessFileService processFileService) { 
            _processFileService = processFileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new { message = "funciona" });
        }

        [HttpPost]        
        public async Task<IActionResult> Post([FromForm] IFormFile file)
        {

            if (!this._processFileService.processFile(file))
            {
                return BadRequest(new ResponseDTO {

                    Message = "No se pudo procesar el archivo contacte al administrador",
                    Success = false
                });
            }

            return Ok(new ResponseDTO
            {

                Message = "Archivo Procesado correctamente",
                Success = true
            });

        }
    }
}
