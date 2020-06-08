using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    public partial class DataBindingDemo
    {
        public string Name { get; set; } = "Tom";
        public string Gender { get; set; } = "Male";
        public string Colour { get; set; } = "background-color:white";
        public string Description { get; set; }
    }
}
