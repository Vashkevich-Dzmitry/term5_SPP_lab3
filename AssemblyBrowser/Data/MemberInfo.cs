using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.Data
{
    public abstract class MemberInfo
    {
        public string Name { get; set; }
        public bool IsStatic { get; set; }
    }
}
