using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerCategory Category { get; set; }
    }
}
