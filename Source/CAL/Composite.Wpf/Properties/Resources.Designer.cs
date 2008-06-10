﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.Composite.Wpf.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.Composite.Wpf.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The object must be of type &apos;{0}&apos; in order to use the current region adapter..
        /// </summary>
        internal static string AdapterInvalidTypeException {
            get {
                return ResourceManager.GetString("AdapterInvalidTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContentControl&apos;s Content property must not be set when also used with Regions..
        /// </summary>
        internal static string ContentControlHasContentException {
            get {
                return ResourceManager.GetString("ContentControlHasContentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deactivation is not possible in this type of region..
        /// </summary>
        internal static string DeactiveNotPossibleException {
            get {
                return ResourceManager.GetString("DeactiveNotPossibleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both the executeMethod and the canExecuteMethod delegates cannot be null..
        /// </summary>
        internal static string DelegateCommandDelegatesCannotBeNull {
            get {
                return ResourceManager.GetString("DelegateCommandDelegatesCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ItemsControl&apos;s ItemsSource property must not be set when also used with Regions..
        /// </summary>
        internal static string ItemsControlHasItemsSourceException {
            get {
                return ResourceManager.GetString("ItemsControlHasItemsSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping with the given type is already registered: {0}.
        /// </summary>
        internal static string MappingExistsException {
            get {
                return ResourceManager.GetString("MappingExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region with the given name is already registered: {0}.
        /// </summary>
        internal static string RegionNameExistsException {
            get {
                return ResourceManager.GetString("RegionNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View already exists in region..
        /// </summary>
        internal static string RegionViewExistsException {
            get {
                return ResourceManager.GetString("RegionViewExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View with name &apos;{0}&apos; already exists in the region..
        /// </summary>
        internal static string RegionViewNameExistsException {
            get {
                return ResourceManager.GetString("RegionViewNameExistsException", resourceCulture);
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
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found.
        /// </summary>
        internal static string ValueNotFound {
            get {
                return ResourceManager.GetString("ValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region does not contain the view you are trying to remove.
        /// </summary>
        internal static string ViewToRemoveNotInRegion {
            get {
                return ResourceManager.GetString("ViewToRemoveNotInRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region does not contain the view you are trying to show..
        /// </summary>
        internal static string ViewToShowNotInRegion {
            get {
                return ResourceManager.GetString("ViewToShowNotInRegion", resourceCulture);
            }
        }
    }
}
