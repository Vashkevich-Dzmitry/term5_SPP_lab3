using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal interface IMemberGenerator
    {
        MemberInfo GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, ref string namespaceName, ref string className);
    }
}
