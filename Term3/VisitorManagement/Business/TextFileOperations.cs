using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VisitorManagement.Business
{
    public class TextFileOperations
    {

        private readonly IWebHostEnvironment _webHostEnviroment;



        public TextFileOperations(IWebHostEnvironment webHostEnviroment)
        {
            _webHostEnviroment = webHostEnviroment;
        }

        public IEnumerable<string> LoadConditionsForAcceptanceText()
        {
            // COA
            string webRootPath = _webHostEnviroment.WebRootPath;

            FileInfo filePath = new FileInfo(Path.Combine(webRootPath, "COA.txt"));

            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());

            return lines.ToList();
        }


    }
}
