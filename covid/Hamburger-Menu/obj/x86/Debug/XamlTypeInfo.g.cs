﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Hamburger_Menu
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMetaDataProvider __appProvider;
        private global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMetaDataProvider();
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

namespace Hamburger_Menu.Hamburger_Menu_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider();
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
            _typeNameTable = new string[19];
            _typeNameTable[0] = "Hamburger_Menu.ViewModels.ViewModelLocator";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "Hamburger_Menu.ViewModels.MainViewModel";
            _typeNameTable[3] = "GalaSoft.MvvmLight.ViewModelBase";
            _typeNameTable[4] = "GalaSoft.MvvmLight.ObservableObject";
            _typeNameTable[5] = "WindowsStateTriggers.DeviceFamilyStateTrigger";
            _typeNameTable[6] = "Windows.UI.Xaml.StateTriggerBase";
            _typeNameTable[7] = "WindowsStateTriggers.DeviceFamily";
            _typeNameTable[8] = "System.Enum";
            _typeNameTable[9] = "System.ValueType";
            _typeNameTable[10] = "Boolean";
            _typeNameTable[11] = "Hamburger_Menu.MainPage";
            _typeNameTable[12] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[13] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[14] = "Windows.UI.Color";
            _typeNameTable[15] = "Byte";
            _typeNameTable[16] = "Hamburger_Menu.Views.Home";
            _typeNameTable[17] = "Hamburger_Menu.Views.Favourite";
            _typeNameTable[18] = "Hamburger_Menu.Views.Download";

            _typeTable = new global::System.Type[19];
            _typeTable[0] = typeof(global::Hamburger_Menu.ViewModels.ViewModelLocator);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::Hamburger_Menu.ViewModels.MainViewModel);
            _typeTable[3] = typeof(global::GalaSoft.MvvmLight.ViewModelBase);
            _typeTable[4] = typeof(global::GalaSoft.MvvmLight.ObservableObject);
            _typeTable[5] = typeof(global::WindowsStateTriggers.DeviceFamilyStateTrigger);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.StateTriggerBase);
            _typeTable[7] = typeof(global::WindowsStateTriggers.DeviceFamily);
            _typeTable[8] = typeof(global::System.Enum);
            _typeTable[9] = typeof(global::System.ValueType);
            _typeTable[10] = typeof(global::System.Boolean);
            _typeTable[11] = typeof(global::Hamburger_Menu.MainPage);
            _typeTable[12] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[13] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[14] = typeof(global::Windows.UI.Color);
            _typeTable[15] = typeof(global::System.Byte);
            _typeTable[16] = typeof(global::Hamburger_Menu.Views.Home);
            _typeTable[17] = typeof(global::Hamburger_Menu.Views.Favourite);
            _typeTable[18] = typeof(global::Hamburger_Menu.Views.Download);
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

        private object Activate_0_ViewModelLocator() { return new global::Hamburger_Menu.ViewModels.ViewModelLocator(); }
        private object Activate_2_MainViewModel() { return new global::Hamburger_Menu.ViewModels.MainViewModel(); }
        private object Activate_4_ObservableObject() { return new global::GalaSoft.MvvmLight.ObservableObject(); }
        private object Activate_5_DeviceFamilyStateTrigger() { return new global::WindowsStateTriggers.DeviceFamilyStateTrigger(); }
        private object Activate_11_MainPage() { return new global::Hamburger_Menu.MainPage(); }
        private object Activate_16_Home() { return new global::Hamburger_Menu.Views.Home(); }
        private object Activate_17_Favourite() { return new global::Hamburger_Menu.Views.Favourite(); }
        private object Activate_18_Download() { return new global::Hamburger_Menu.Views.Download(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Hamburger_Menu.ViewModels.ViewModelLocator
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_ViewModelLocator;
                userType.AddMemberName("MainViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Hamburger_Menu.ViewModels.MainViewModel
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("GalaSoft.MvvmLight.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  GalaSoft.MvvmLight.ViewModelBase
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("GalaSoft.MvvmLight.ObservableObject"));
                xamlType = userType;
                break;

            case 4:   //  GalaSoft.MvvmLight.ObservableObject
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_ObservableObject;
                xamlType = userType;
                break;

            case 5:   //  WindowsStateTriggers.DeviceFamilyStateTrigger
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.StateTriggerBase"));
                userType.Activator = Activate_5_DeviceFamilyStateTrigger;
                userType.AddMemberName("DeviceFamily");
                userType.AddMemberName("IsActive");
                xamlType = userType;
                break;

            case 6:   //  Windows.UI.Xaml.StateTriggerBase
                xamlType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  WindowsStateTriggers.DeviceFamily
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
                userType.AddEnumValue("Unknown", global::WindowsStateTriggers.DeviceFamily.Unknown);
                userType.AddEnumValue("Desktop", global::WindowsStateTriggers.DeviceFamily.Desktop);
                userType.AddEnumValue("Mobile", global::WindowsStateTriggers.DeviceFamily.Mobile);
                userType.AddEnumValue("Team", global::WindowsStateTriggers.DeviceFamily.Team);
                userType.AddEnumValue("IoT", global::WindowsStateTriggers.DeviceFamily.IoT);
                userType.AddEnumValue("Xbox", global::WindowsStateTriggers.DeviceFamily.Xbox);
                xamlType = userType;
                break;

            case 8:   //  System.Enum
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                xamlType = userType;
                break;

            case 9:   //  System.ValueType
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 10:   //  Boolean
                xamlType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Hamburger_Menu.MainPage
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 14:   //  Windows.UI.Color
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                userType.AddMemberName("B");
                userType.AddMemberName("G");
                userType.AddMemberName("R");
                xamlType = userType;
                break;

            case 15:   //  Byte
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 16:   //  Hamburger_Menu.Views.Home
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_Home;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  Hamburger_Menu.Views.Favourite
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_Favourite;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  Hamburger_Menu.Views.Download
                userType = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_Download;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_ViewModelLocator_MainViewModel(object instance)
        {
            var that = (global::Hamburger_Menu.ViewModels.ViewModelLocator)instance;
            return that.MainViewModel;
        }
        private object get_1_DeviceFamilyStateTrigger_DeviceFamily(object instance)
        {
            var that = (global::WindowsStateTriggers.DeviceFamilyStateTrigger)instance;
            return that.DeviceFamily;
        }
        private void set_1_DeviceFamilyStateTrigger_DeviceFamily(object instance, object Value)
        {
            var that = (global::WindowsStateTriggers.DeviceFamilyStateTrigger)instance;
            that.DeviceFamily = (global::WindowsStateTriggers.DeviceFamily)Value;
        }
        private object get_2_DeviceFamilyStateTrigger_IsActive(object instance)
        {
            var that = (global::WindowsStateTriggers.DeviceFamilyStateTrigger)instance;
            return that.IsActive;
        }
        private object get_3_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_3_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_4_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_4_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_5_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_5_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_6_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_6_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember xamlMember = null;
            global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Hamburger_Menu.ViewModels.ViewModelLocator.MainViewModel":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Hamburger_Menu.ViewModels.ViewModelLocator");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "MainViewModel", "Hamburger_Menu.ViewModels.MainViewModel");
                xamlMember.Getter = get_0_ViewModelLocator_MainViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "WindowsStateTriggers.DeviceFamilyStateTrigger.DeviceFamily":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsStateTriggers.DeviceFamilyStateTrigger");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "DeviceFamily", "WindowsStateTriggers.DeviceFamily");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_DeviceFamilyStateTrigger_DeviceFamily;
                xamlMember.Setter = set_1_DeviceFamilyStateTrigger_DeviceFamily;
                break;
            case "WindowsStateTriggers.DeviceFamilyStateTrigger.IsActive":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsStateTriggers.DeviceFamilyStateTrigger");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "IsActive", "Boolean");
                xamlMember.Getter = get_2_DeviceFamilyStateTrigger_IsActive;
                xamlMember.SetIsReadOnly();
                break;
            case "Windows.UI.Color.A":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_3_Color_A;
                xamlMember.Setter = set_3_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_4_Color_B;
                xamlMember.Setter = set_4_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_5_Color_G;
                xamlMember.Setter = set_5_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_6_Color_R;
                xamlMember.Setter = set_6_Color_R;
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
    internal class XamlUserType : global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlSystemBaseType
    {
        global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider _provider;
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

        public XamlUserType(global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
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
        global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Hamburger_Menu.Hamburger_Menu_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
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

