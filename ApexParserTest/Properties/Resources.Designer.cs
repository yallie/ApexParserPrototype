﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexParserTest.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApexParserTest.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to public with sharing class ClassOne {
        ///    public void CallClassTwo() {
        ///        ClassTwo classTwo = new ClassTwo();
        ///        System.debug(&apos;Test&apos;);
        ///    }
        ///}.
        /// </summary>
        internal static string ClassOne {
            get {
                return ResourceManager.GetString("ClassOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public with sharing class ClassOne
        ///{
        ///     public void CallClassTwo()
        ///     {
        ///          ClassTwo classTwo = new ClassTwo();
        ///          System.debug(&apos;Test&apos;);
        ///     }
        ///}
        ///.
        /// </summary>
        internal static string ClassOne_Formatted {
            get {
                return ResourceManager.GetString("ClassOne_Formatted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public with sharing class ClassTwo {
        ///    public ClassTwo() {
        ///        System.debug(&apos;Test&apos;);
        ///    }
        ///
        ///    public ClassTwo(String vin) {
        ///    }
        ///}.
        /// </summary>
        internal static string ClassTwo {
            get {
                return ResourceManager.GetString("ClassTwo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public with sharing class ClassTwo
        ///{
        ///     public ClassTwo()
        ///     {
        ///          System.debug(&apos;Test&apos;);
        ///     }
        ///
        ///     public ClassTwo(String vin)
        ///     {
        ///     }
        ///}
        ///.
        /// </summary>
        internal static string ClassTwo_Formatted {
            get {
                return ResourceManager.GetString("ClassTwo_Formatted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class Demo
        ///{
        ///    public static void RunContactDemo()
        ///    {
        ///        Contact contactNew = new Contact(LastName = &apos;Jay1&apos;, EMail = &apos;abc@abc.com&apos;);
        ///        insert contactNew;
        ///        System.debug(contactNew.Id);
        ///
        ///        List&lt;Contact&gt; contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        ///        for (Contact c : contacts)
        ///        {
        ///            System.debug(c.Email); c.Email = &apos;new@new.com&apos;;
        ///        }
        ///        update contacts;
        ///        contacts = [SELECT Id, Email FROM Contact W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Demo {
            get {
                return ResourceManager.GetString("Demo", resourceCulture);
            }
        }
    }
}
