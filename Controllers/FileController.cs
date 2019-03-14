using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_file_upload_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            try
            {
                foreach (var file in files)
                {
                    Console.WriteLine($"Begin Uploaded File: {file.FileName}");

                    //simulate upload
                    Task.Delay(5000).Wait();

                    Console.WriteLine($"Finished Uploaded File: {file.FileName}");
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Unable to upload file(s).");
            }
        }
    }
}
