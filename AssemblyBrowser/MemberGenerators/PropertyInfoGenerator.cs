using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal class PropertyInfoGenerator : IMemberInfoGenerator
    {
        MemberInfo IMemberInfoGenerator.GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, string namespaceName, string className)
        {
            if (memberInfo?.MemberType == System.Reflection.MemberTypes.Property)
            {
                System.Reflection.PropertyInfo property = (memberInfo as System.Reflection.PropertyInfo)!;
                PropertyInfo modelPropertyInfo = new ()
                {
                    Name = property.Name,
                    PropertyType = property.PropertyType.Name,
                    HasGetter = property.CanRead,
                    HasSetter = property.CanWrite,
                    IsStatic = property.CanRead ? property.GetGetMethod(true)!.IsStatic : property.GetSetMethod(true)!.IsStatic
                };
                return modelPropertyInfo;
            }
            else
            {
                throw new ArgumentException("Something went wrong");
            }
        }
    }
}
