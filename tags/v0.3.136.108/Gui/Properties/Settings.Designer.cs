﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sipek.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5060")]
        public int cfgSipPort {
            get {
                return ((int)(this["cfgSipPort"]));
            }
            set {
                this["cfgSipPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int cfgRingMode {
            get {
                return ((int)(this["cfgRingMode"]));
            }
            set {
                this["cfgRingMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>5060</string>
  <string>5060</string>
  <string>5060</string>
  <string>5060</string>
  <string>5060</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountPorts {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountPorts"]));
            }
            set {
                this["cfgSipAccountPorts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountRegPeriod {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountRegPeriod"]));
            }
            set {
                this["cfgSipAccountRegPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int cfgSipAccountDefault {
            get {
                return ((int)(this["cfgSipAccountDefault"]));
            }
            set {
                this["cfgSipAccountDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>*</string>
  <string>*</string>
  <string>*</string>
  <string>*</string>
  <string>*</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountDomains {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountDomains"]));
            }
            set {
                this["cfgSipAccountDomains"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgCFUFlag {
            get {
                return ((bool)(this["cfgCFUFlag"]));
            }
            set {
                this["cfgCFUFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string cfgCFUNumber {
            get {
                return ((string)(this["cfgCFUNumber"]));
            }
            set {
                this["cfgCFUNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string cfgCFNRNumber {
            get {
                return ((string)(this["cfgCFNRNumber"]));
            }
            set {
                this["cfgCFNRNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgCFNRFlag {
            get {
                return ((bool)(this["cfgCFNRFlag"]));
            }
            set {
                this["cfgCFNRFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgDNDFlag {
            get {
                return ((bool)(this["cfgDNDFlag"]));
            }
            set {
                this["cfgDNDFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgCFBFlag {
            get {
                return ((bool)(this["cfgCFBFlag"]));
            }
            set {
                this["cfgCFBFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string cfgCFBNumber {
            get {
                return ((string)(this["cfgCFBNumber"]));
            }
            set {
                this["cfgCFBNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgAAFlag {
            get {
                return ((bool)(this["cfgAAFlag"]));
            }
            set {
                this["cfgAAFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int cfgAATimeout {
            get {
                return ((int)(this["cfgAATimeout"]));
            }
            set {
                this["cfgAATimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string />
  <string />
  <string />
  <string />
  <string />
  <string />
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountDisplayName {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountDisplayName"]));
            }
            set {
                this["cfgSipAccountDisplayName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountAddresses {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountAddresses"]));
            }
            set {
                this["cfgSipAccountAddresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountPassword {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountPassword"]));
            }
            set {
                this["cfgSipAccountPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountIds {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountIds"]));
            }
            set {
                this["cfgSipAccountIds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountUsername {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountUsername"]));
            }
            set {
                this["cfgSipAccountUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountState {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountState"]));
            }
            set {
                this["cfgSipAccountState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string />
  <string />
  <string />
  <string />
  <string />
  <string />
  <string />
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountNames"]));
            }
            set {
                this["cfgSipAccountNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>PCMU/8000/1</string>\r\n  <string>PCMA/8000/1</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgCodecList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgCodecList"]));
            }
            set {
                this["cfgCodecList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string />
  <string />
  <string />
  <string />
  <string />
  <string />
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountProxyAddresses {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountProxyAddresses"]));
            }
            set {
                this["cfgSipAccountProxyAddresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string cfgStunServerAddress {
            get {
                return ((string)(this["cfgStunServerAddress"]));
            }
            set {
                this["cfgStunServerAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int cfgDtmfMode {
            get {
                return ((int)(this["cfgDtmfMode"]));
            }
            set {
                this["cfgDtmfMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>0</string>
  <string>0</string>
  <string>0</string>
  <string>0</string>
  <string>0</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountTransport {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountTransport"]));
            }
            set {
                this["cfgSipAccountTransport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool cfgSipPublishEnabled {
            get {
                return ((bool)(this["cfgSipPublishEnabled"]));
            }
            set {
                this["cfgSipPublishEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring />\r\n  <string />\r\n  <string />\r\n  <string />\r\n  <string />\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection cfgSipAccountIndex {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["cfgSipAccountIndex"]));
            }
            set {
                this["cfgSipAccountIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3600")]
        public int cfgRegistrationTimeout {
            get {
                return ((int)(this["cfgRegistrationTimeout"]));
            }
            set {
                this["cfgRegistrationTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool cfgVAD {
            get {
                return ((bool)(this["cfgVAD"]));
            }
            set {
                this["cfgVAD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int cfgECTail {
            get {
                return ((int)(this["cfgECTail"]));
            }
            set {
                this["cfgECTail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string cfgNameServer {
            get {
                return ((string)(this["cfgNameServer"]));
            }
            set {
                this["cfgNameServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool cfgUpdgradeSettings {
            get {
                return ((bool)(this["cfgUpdgradeSettings"]));
            }
            set {
                this["cfgUpdgradeSettings"] = value;
            }
        }
    }
}
