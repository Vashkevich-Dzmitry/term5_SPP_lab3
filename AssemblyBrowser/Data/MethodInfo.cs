using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.Data
{
    public class MethodInfo : MemberInfo
    {
        public string ReturnType { get; set; }
        public string ParametersInfo { get; set; }
    }
}
