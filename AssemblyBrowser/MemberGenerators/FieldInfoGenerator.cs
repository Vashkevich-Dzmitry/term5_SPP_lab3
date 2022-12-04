using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal class FieldInfoGenerator : IMemberInfoGenerator
    {
        MemberInfo IMemberInfoGenerator.GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, string namespaceName, string className)
        {
            if (memberInfo?.MemberType == System.Reflection.MemberTypes.Field)
            {
                System.Reflection.FieldInfo fieldInfo = (memberInfo as System.Reflection.FieldInfo)!;
                FieldInfo viewModelFieldInfo = new()
                {
                    FieldType = fieldInfo.FieldType.Name,
                    Name = memberInfo.Name,
                    IsStatic = fieldInfo.IsStatic
                };
                return viewModelFieldInfo;
            }
            else
            {
                throw new ArgumentException("Something went wrong");
            }
        }
    }
}
