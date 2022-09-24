using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.IService
{
   
    public interface IProcessFileService
    {
        public bool processFile(IFormFile file);
    }
    
}
