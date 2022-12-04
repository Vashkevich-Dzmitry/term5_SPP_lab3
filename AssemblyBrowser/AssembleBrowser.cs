using System.Reflection;
using AssemblyBrowser.Data;
using AssemblyBrowser.MemberGenerators;

namespace AssemblyBrowser
{
    public class AssembleBrowser
    {
        private static readonly Dictionary<MemberTypes, IMemberInfoGenerator> _memberInfoGenerators;
        static AssembleBrowser()
        {
            _memberInfoGenerators = new Dictionary<MemberTypes, IMemberInfoGenerator>
            {
                { MemberTypes.Field, new FieldInfoGenerator() },
                { MemberTypes.Property, new PropertyInfoGenerator() },
                { MemberTypes.Method, new MethodInfoGenerator() }
            };
        }

        public static AssemblyInfo GetAssemblyInfo(string assemblyPath)
        {
            Assembly assembly;
            try
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new FileNotFoundException(assemblyPath, e);
            }
            catch (BadImageFormatException e)
            {
                throw new Exception("NotAnAssembly: " + assemblyPath, e);
            }

            AssemblyInfo modelAssemblyInfo = new(assembly.GetName().Name, assemblyPath);
            
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                foreach (System.Reflection.MemberInfo memberInfo in type.GetMembers(
                    BindingFlags.Public
                    | BindingFlags.NonPublic
                    | BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.DeclaredOnly))
                {
                    string namespaceName = type.Namespace ?? "global";
                    string className = type.Name;
                    if (_memberInfoGenerators.ContainsKey(memberInfo.MemberType))
                    {
                        var modelMemberInfo = _memberInfoGenerators[memberInfo.MemberType].GenerateMemberInfo(memberInfo, namespaceName, className);
                        var modelNamespaceInfo = modelAssemblyInfo.AddOrGetNamespaceInfo(namespaceName);
                        var modelClassInfo = modelNamespaceInfo.AddOrGetClassInfo(className);
                        modelClassInfo.AddMemberInfo(modelMemberInfo);
                    }
                }
            }

            return modelAssemblyInfo;
        }
    }
}
