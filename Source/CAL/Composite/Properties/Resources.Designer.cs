﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.Composite.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.Composite.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1}: {2}. Priority: {3}. Timestamp:{0:u}..
        /// </summary>
        internal static string DefaultTextLoggerPattern {
            get {
                return ResourceManager.GetString("DefaultTextLoggerPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add dependency for unknown module {0}.
        /// </summary>
        internal static string DependencyForUnknownModule {
            get {
                return ResourceManager.GetString("DependencyForUnknownModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A module declared a dependency on another module which is not declared to be loaded. Missing module(s): {0}.
        /// </summary>
        internal static string DependencyOnMissingModule {
            get {
                return ResourceManager.GetString("DependencyOnMissingModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} was not found..
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicated module with name {0} has been found by the loader..
        /// </summary>
        internal static string DuplicatedModule {
            get {
                return ResourceManager.GetString("DuplicatedModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load module {0} from assembly {1}. Error was:
        ///{2}.
        /// </summary>
        internal static string FailedToLoadModule {
            get {
                return ResourceManager.GetString("FailedToLoadModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly file {0} was not found..
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
    }
}
