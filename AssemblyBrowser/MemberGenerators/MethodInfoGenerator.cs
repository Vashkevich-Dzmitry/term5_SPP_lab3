using AssemblyBrowser.Data;

namespace AssemblyBrowser.MemberGenerators
{
    internal class MethodInfoGenerator : IMemberInfoGenerator
    {
        MemberInfo IMemberInfoGenerator.GenerateMemberInfo(System.Reflection.MemberInfo memberInfo, string namespaceName, string className)
        {
            if (memberInfo?.MemberType == System.Reflection.MemberTypes.Method)
            {
                System.Reflection.MethodInfo methodInfo = (memberInfo as System.Reflection.MethodInfo)!;
                MethodInfo modelMethodInfo = new()
                {
                    ReturnType = methodInfo.ReturnType.Name,
                    Name = methodInfo.Name,
                    IsStatic = methodInfo.IsStatic
                };

                System.Reflection.ParameterInfo[] parameters = methodInfo.GetParameters();
                string parametersInfo = "";
                if (parameters.Length > 0)
                {
                    foreach (System.Reflection.ParameterInfo parameter in parameters)
                    {
                        parametersInfo += parameter.ParameterType.Name + " " + parameter.Name + ", ";
                    }
                    parametersInfo = parametersInfo[0..^2];
                }
                modelMethodInfo.ParametersInfo = parametersInfo;
                return modelMethodInfo;
            }
            else
            {
                throw new ArgumentException("Something went wrong");
            }
        }
    }
}
