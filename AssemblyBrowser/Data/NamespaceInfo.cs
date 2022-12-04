using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.Data
{
    public class NamespaceInfo
    {
        private Dictionary<string, ClassInfo> _classInfos;
        public Dictionary<string, ClassInfo> ClassInfos { get { return _classInfos; } }
        public string Name { get; }

        public NamespaceInfo(string name)
        {
            _classInfos = new Dictionary<string, ClassInfo>();
            Name = name;
        }
    }
}
