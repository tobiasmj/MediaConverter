using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaConverter.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MediaConverter.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        [HttpGet("Files")]
        public IEnumerable<File> Files()
        {
            var fileNames = new[]
            {
                "file1.mkv","file2.mkv","file3.mkv","file4.mkv","file5.mkv"
            };
            return Enumerable.Range(1, 5).Select(index => new File
            {
                Name = fileNames[index]
            });
        }
    }
}