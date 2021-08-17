using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {
        public string Fullname{get; set; }
        public List<int> Numbers { get; set; }


        public List<Student> Students { get; set; }
    }
}
