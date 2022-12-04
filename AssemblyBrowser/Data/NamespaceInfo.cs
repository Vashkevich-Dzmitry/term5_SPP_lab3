namespace AssemblyBrowser.Data
{
    public class NamespaceInfo
    {
        private Dictionary<string, ClassInfo> _classInfos;
        public Dictionary<string, ClassInfo> ClassInfos { get { return _classInfos; } }

        public NamespaceInfo()
        {
            _classInfos = new Dictionary<string, ClassInfo>();
        }
    }
}
