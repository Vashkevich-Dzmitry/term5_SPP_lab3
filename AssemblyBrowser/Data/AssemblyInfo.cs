namespace AssemblyBrowser.Data
{
    public class AssemblyInfo
    {
        private readonly Dictionary<string, NamespaceInfo> _namespaceInfos;

        public Dictionary<string, NamespaceInfo> NamespaceInfos { get { return _namespaceInfos; } }
        public string Name { get; }
        public string Path { get; }

        internal AssemblyInfo(string name, string path)
        {
            _namespaceInfos = new Dictionary<string, NamespaceInfo>();
            Name = name;
            Path = path;
        }

        internal NamespaceInfo AddOrGetNamespaceInfo(string namespaceName)
        {
            if (!_namespaceInfos.ContainsKey(namespaceName))
            {
                _namespaceInfos.Add(namespaceName, new NamespaceInfo());
            }
            return _namespaceInfos[namespaceName];
        }
    }
}
