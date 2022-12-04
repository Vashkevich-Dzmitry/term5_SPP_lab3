namespace AssemblyBrowser.Data
{
    public class PropertyInfo : MemberInfo
    {
        public string PropertyType { get; set; }
        public bool HasGetter { get; set; }
        public bool HasSetter { get; set; }

        public PropertyInfo(string name, bool isStatic, string propertyType, bool hasGetter, bool hasSetter)
        {
            Name = name;
            IsStatic = isStatic;
            PropertyType = propertyType;
            HasGetter = hasGetter;
            HasSetter = hasSetter;
        }
    }
}
