using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal interface IMemberInfoGenerator
    {
        MemberInfo GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, string namespaceName, string className);
    }
}
