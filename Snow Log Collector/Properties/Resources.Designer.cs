﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SnowLogCollector.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SnowLogCollector.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Resource version=&quot;9.19.00&quot; defaultSize=&quot;9&quot; isCustom=&quot;false&quot;&gt;
        ///  
        ///    &lt;!-- 
        ///    
        ///      You can add custom scripts to the below and modify the existing ones if you want.  To format dates correctly in the Excel Export
        ///      I recommend doing CONVERT(VARCHAR, DateColumn, 120) AS [DateColumn] - but it&apos;s up to you. :) 
        ///      
        ///      Ensure you change isCustom = false to isCustom = true on Line 2.  It&apos;s not currently used in Version 2.0, but it&apos;s to future proof
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DataUpdateJob {
            get {
                return ResourceManager.GetString("DataUpdateJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Resource version=&quot;9.19.00&quot; defaultSize=&quot;33&quot; isCustom=&quot;false&quot;&gt;
        ///  
        ///    &lt;!-- 
        ///    
        ///      You can add custom scripts to the below and modify the existing ones if you want.  To format dates correctly in the Excel Export
        ///      I recommend doing CONVERT(VARCHAR, DateColumn, 120) AS [DateColumn] - but it&apos;s up to you. :) 
        ///      
        ///      Ensure you change isCustom = false to isCustom = true on Line 2.  It&apos;s not currently used in Version 2.0, but it&apos;s to future proof
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Microsoft365 {
            get {
                return ResourceManager.GetString("Microsoft365", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap snow_log_collector {
            get {
                object obj = ResourceManager.GetObject("snow_log_collector", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
