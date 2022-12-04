namespace AssemblyBrowser.Data
{
    public class MethodInfo : MemberInfo
    {
        public string ReturnType { get; set; }
        public string ParametersInfo { get; set; }

        public MethodInfo(string name, bool isStatic, string returnType, string ParametersInfo)
        {
            Name = name;
            IsStatic = isStatic;
            ReturnType = returnType;
            ParametersInfo = ParametersInfo;
        }
    }
}
