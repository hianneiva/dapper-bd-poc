using System;

namespace DapperBD
{
    public class OrmAttribute : Attribute
    {
        public string Name { get; set; }
        public string IdName { get; set; }
        public bool Ignore { get; set; }
    }
}
