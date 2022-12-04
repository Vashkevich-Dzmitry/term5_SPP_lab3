using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal class MethodGenerator : IMemberGenerator
    {
        MemberInfo IMemberGenerator.GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, ref string namespaceName, ref string className)
        {
            throw new NotImplementedException();
        }
    }
}
