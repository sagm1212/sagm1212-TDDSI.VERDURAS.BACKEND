﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDDSI.VERDURAS.BACKEND.Domain.Constants;
using System;


/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute( "System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0" )]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
public class SqlQueriesConstants {

    private static global::System.Resources.ResourceManager resourceMan;

    private static global::System.Globalization.CultureInfo resourceCulture;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode" )]
    internal SqlQueriesConstants() {
    }

    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute( global::System.ComponentModel.EditorBrowsableState.Advanced )]
    public static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals( resourceMan, null )) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager( "TDDSI.VERDURAS.BACKEND.Domain.Constants.SqlQueriesConstants", typeof( SqlQueriesConstants ).Assembly );
                resourceMan = temp;
            }
            return resourceMan;
        }
    }

    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute( global::System.ComponentModel.EditorBrowsableState.Advanced )]
    public static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }

    /// <summary>
    ///   Looks up a localized string similar to SELECT
    ///w.&quot;Id&quot; AS &quot;Id&quot;,
    ///w.&quot;Date&quot; AS &quot;Date&quot;,
    ///w.&quot;TemperatureC&quot; AS &quot;TemperatureC&quot;,
    ///w.&quot;Summary&quot; AS &quot;Summary&quot;,
    ///w.&quot;Temperature&quot; AS &quot;TemperatureF&quot;,
    ///w.&quot;Enabled&quot; AS &quot;Enabled&quot;
    ///FROM &quot;TDDSI.VERDURAS.BACKENDMS&quot;.&quot;WeatherForecasts&quot; w.
    /// </summary>
    public static string AllWeastherForecasts {
        get {
            return ResourceManager.GetString( "AllWeastherForecasts", resourceCulture );
        }
    }
}
