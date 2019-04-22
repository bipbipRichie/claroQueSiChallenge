﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClaroQueSi
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMetaDataProvider __appProvider;
        private global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMetaDataProvider();
                }
                return __appProvider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return _AppProvider.GetXamlType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return _AppProvider.GetXamlType(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return _AppProvider.GetXmlnsDefinitions();
        }
    }
}

namespace ClaroQueSi.Claro_Client_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType) 
            { 
                if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByType(type);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType)
            {
                if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByName(typeName);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            lock (_xamlMembers)
            {
                if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
                {
                    return xamlMember;
                }
                xamlMember = CreateXamlMember(longMemberName);
                if (xamlMember != null)
                {
                    _xamlMembers.Add(longMemberName, xamlMember);
                }
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[9];
            _typeNameTable[0] = "ClaroQueSi.ViewModels.ViewModelLocator";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "ClaroQueSi.VM.MainPageVM";
            _typeNameTable[3] = "ClaroQueSi.Helpers.ViewModelBase";
            _typeNameTable[4] = "ClaroQueSi.VM.MovieDetailVM";
            _typeNameTable[5] = "ClaroQueSi.MainPage";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[7] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[8] = "ClaroQueSi.MovieDetail";

            _typeTable = new global::System.Type[9];
            _typeTable[0] = typeof(global::ClaroQueSi.ViewModels.ViewModelLocator);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::ClaroQueSi.VM.MainPageVM);
            _typeTable[3] = typeof(global::ClaroQueSi.Helpers.ViewModelBase);
            _typeTable[4] = typeof(global::ClaroQueSi.VM.MovieDetailVM);
            _typeTable[5] = typeof(global::ClaroQueSi.MainPage);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[7] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[8] = typeof(global::ClaroQueSi.MovieDetail);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_ViewModelLocator() { return new global::ClaroQueSi.ViewModels.ViewModelLocator(); }
        private object Activate_2_MainPageVM() { return new global::ClaroQueSi.VM.MainPageVM(); }
        private object Activate_4_MovieDetailVM() { return new global::ClaroQueSi.VM.MovieDetailVM(); }
        private object Activate_5_MainPage() { return new global::ClaroQueSi.MainPage(); }
        private object Activate_8_MovieDetail() { return new global::ClaroQueSi.MovieDetail(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  ClaroQueSi.ViewModels.ViewModelLocator
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_ViewModelLocator;
                userType.AddMemberName("MainPageInstance");
                userType.AddMemberName("MovieDetailPageInstance");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  ClaroQueSi.VM.MainPageVM
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("ClaroQueSi.Helpers.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  ClaroQueSi.Helpers.ViewModelBase
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  ClaroQueSi.VM.MovieDetailVM
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("ClaroQueSi.Helpers.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  ClaroQueSi.MainPage
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_MainPage;
                userType.AddMemberName("vm");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  ClaroQueSi.MovieDetail
                userType = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_MovieDetail;
                userType.AddMemberName("vm");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_ViewModelLocator_MainPageInstance(object instance)
        {
            var that = (global::ClaroQueSi.ViewModels.ViewModelLocator)instance;
            return that.MainPageInstance;
        }
        private object get_1_ViewModelLocator_MovieDetailPageInstance(object instance)
        {
            var that = (global::ClaroQueSi.ViewModels.ViewModelLocator)instance;
            return that.MovieDetailPageInstance;
        }
        private object get_2_MainPage_vm(object instance)
        {
            var that = (global::ClaroQueSi.MainPage)instance;
            return that.vm;
        }
        private void set_2_MainPage_vm(object instance, object Value)
        {
            var that = (global::ClaroQueSi.MainPage)instance;
            that.vm = (global::ClaroQueSi.VM.MainPageVM)Value;
        }
        private object get_3_MovieDetail_vm(object instance)
        {
            var that = (global::ClaroQueSi.MovieDetail)instance;
            return that.vm;
        }
        private void set_3_MovieDetail_vm(object instance, object Value)
        {
            var that = (global::ClaroQueSi.MovieDetail)instance;
            that.vm = (global::ClaroQueSi.VM.MovieDetailVM)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMember xamlMember = null;
            global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "ClaroQueSi.ViewModels.ViewModelLocator.MainPageInstance":
                userType = (global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ClaroQueSi.ViewModels.ViewModelLocator");
                xamlMember = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMember(this, "MainPageInstance", "ClaroQueSi.VM.MainPageVM");
                xamlMember.Getter = get_0_ViewModelLocator_MainPageInstance;
                xamlMember.SetIsReadOnly();
                break;
            case "ClaroQueSi.ViewModels.ViewModelLocator.MovieDetailPageInstance":
                userType = (global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ClaroQueSi.ViewModels.ViewModelLocator");
                xamlMember = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMember(this, "MovieDetailPageInstance", "ClaroQueSi.VM.MovieDetailVM");
                xamlMember.Getter = get_1_ViewModelLocator_MovieDetailPageInstance;
                xamlMember.SetIsReadOnly();
                break;
            case "ClaroQueSi.MainPage.vm":
                userType = (global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ClaroQueSi.MainPage");
                xamlMember = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMember(this, "vm", "ClaroQueSi.VM.MainPageVM");
                xamlMember.Getter = get_2_MainPage_vm;
                xamlMember.Setter = set_2_MainPage_vm;
                break;
            case "ClaroQueSi.MovieDetail.vm":
                userType = (global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ClaroQueSi.MovieDetail");
                xamlMember = new global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlMember(this, "vm", "ClaroQueSi.VM.MovieDetailVM");
                xamlMember.Getter = get_3_MovieDetail_vm;
                xamlMember.Setter = set_3_MovieDetail_vm;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);
    internal delegate object CreateFromStringMethod(string args);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlSystemBaseType
    {
        global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            global::System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (CreateFromStringMethod != null)
            {
                return this.CreateFromStringMethod(input);
            }
            else if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }
        public CreateFromStringMethod CreateFromStringMethod {get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::ClaroQueSi.Claro_Client_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
