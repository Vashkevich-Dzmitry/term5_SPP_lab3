namespace AssemblyBrowser.Data
{
    public class NamespaceInfo
    {
        private readonly Dictionary<string, ClassInfo> _classInfos;
        public Dictionary<string, ClassInfo> ClassInfos { get { return _classInfos; } }

        public NamespaceInfo()
        {
            _classInfos = new Dictionary<string, ClassInfo>();
        }

        internal ClassInfo AddOrGetClassInfo(string className)
        {
            if (!_classInfos.ContainsKey(className))
            {
                _classInfos.Add(className, new ClassInfo());
            }
            return _classInfos[className];
        }
    }
}
