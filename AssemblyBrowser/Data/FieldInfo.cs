namespace AssemblyBrowser.Data
{
    public class FieldInfo : MemberInfo
    {
        public string FieldType { get; set; }

        public FieldInfo(string name, bool isStatic, string fieldType)
        {
            Name = name;
            IsStatic = isStatic;
            FieldType = fieldType;
        }
    }
}
