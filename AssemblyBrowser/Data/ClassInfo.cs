namespace AssemblyBrowser.Data
{
    public class ClassInfo
    {
        private readonly List<MemberInfo> _memberInfos;
        public List<MemberInfo> MemberInfos { get { return _memberInfos; } }
        public ClassInfo()
        {
            _memberInfos = new List<MemberInfo>();
        }

        public void AddMemberInfo(MemberInfo memberInfo)
        {
            _memberInfos.Add(memberInfo);
        }
    }
}
