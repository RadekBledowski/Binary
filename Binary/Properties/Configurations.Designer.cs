﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Binary.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Configurations : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configurations defaultInstance = ((Configurations)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configurations())));
        
        public static Configurations Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DarkTheme {
            get {
                return ((bool)(this["DarkTheme"]));
            }
            set {
                this["DarkTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PassPassed {
            get {
                return ((bool)(this["PassPassed"]));
            }
            set {
                this["PassPassed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LaunchFile {
            get {
                return ((string)(this["LaunchFile"]));
            }
            set {
                this["LaunchFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Nikki by MaxHwoy | Autogenerated")]
        public string Watermark {
            get {
                return ((string)(this["Watermark"]));
            }
            set {
                this["Watermark"] = value;
            }
        }
    }
}
