namespace AssemblyBrowser.Data
{
    public class ClassInfo
    {
        private List<MemberInfo> _memberInfos;
        public List<MemberInfo> MemberInfos { get { return _memberInfos; } }
        public ClassInfo()
        {
            _memberInfos = new List<MemberInfo>();
        }
    }
}
