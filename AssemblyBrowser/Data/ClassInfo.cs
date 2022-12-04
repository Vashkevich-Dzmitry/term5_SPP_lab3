﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.Data
{
    public class ClassInfo
    {
        private Dictionary<string, MemberInfo> _memberInfos;
        public Dictionary<string, MemberInfo> MemberInfos { get { return _memberInfos; } }
        public ClassInfo()
        {
            _memberInfos = new Dictionary<string, MemberInfo>();
        }
    }
}
