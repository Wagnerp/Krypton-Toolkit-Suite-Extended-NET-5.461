﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class GlobalStringSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GlobalStringSettings defaultInstance = ((GlobalStringSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GlobalStringSettings())));
        
        public static GlobalStringSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BasePaletteMode {
            get {
                return ((string)(this["BasePaletteMode"]));
            }
            set {
                this["BasePaletteMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("This will become informative...")]
        public string FeedbackText {
            get {
                return ((string)(this["FeedbackText"]));
            }
            set {
                this["FeedbackText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PaletteExportPath {
            get {
                return ((string)(this["PaletteExportPath"]));
            }
            set {
                this["PaletteExportPath"] = value;
            }
        }
    }
}
