﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MongoChat.Data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class ChatSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ChatSettings defaultInstance = ((ChatSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ChatSettings())));
        
        public static ChatSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mongodb://root:root@ds063779.mongolab.com:63779/chat")]
        public string DataBaseHost {
            get {
                return ((string)(this["DataBaseHost"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chat")]
        public string DataBaseName {
            get {
                return ((string)(this["DataBaseName"]));
            }
        }
    }
}
