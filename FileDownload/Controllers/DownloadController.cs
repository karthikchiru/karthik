using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileDownload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {

        private readonly string filepath;
            
            public DownloadController(string   filepath)
        {
            this.filepath = filepath;
        }


        // GET: api/Download
        [HttpGet]
        public FileContentResult Get()
        {
            return File(System.IO.File.ReadAllBytes(filepath), "application/octet-stream", "file.csv");
        }

      
        }
    }

