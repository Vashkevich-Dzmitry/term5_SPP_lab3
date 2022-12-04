using System.Reflection;
using AssemblyBrowser.Data;

namespace AssemblyBrowser
{
    public class AssembleBrowser
    {
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

            AssemblyInfo assemblyInfo = new(assembly.GetName().Name, assemblyPath);
            var namespaces = assembly.GetTypes().Select(type => type.Namespace).Distinct().ToList();
            namespaces.ForEach(_namespace =>
            {
                NamespaceInfo namespaceInfo = new();
                assemblyInfo.NamespaceInfos.Add(_namespace, namespaceInfo);

                var classes = assembly.GetTypes().Where(type => type.IsClass && type.Namespace == _namespace).ToList();

                classes.ForEach(_class=>
                {
                   
                });
            });

            return assemblyInfo;
        }
    }
}
