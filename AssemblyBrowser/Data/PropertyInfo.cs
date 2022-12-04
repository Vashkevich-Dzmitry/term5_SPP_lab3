using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.Data
{
    public class PropertyInfo : MemberInfo
    {
        public string PropertyType { get; set; }
        public bool HasGetter { get; set; }
        public bool HasSetter { get; set; }
    }
}
