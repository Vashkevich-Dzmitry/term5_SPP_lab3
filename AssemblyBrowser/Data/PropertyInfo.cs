namespace AssemblyBrowser.Data
{
    public class PropertyInfo : MemberInfo
    {
        public string PropertyType { get; set; }
        public bool HasGetter { get; set; }
        public bool HasSetter { get; set; }
    }
}
