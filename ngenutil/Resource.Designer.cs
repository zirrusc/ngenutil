﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.17929
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ngenutil {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ngenutil.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   Ngen Utility に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   zirrusc に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Author {
            get {
                return ResourceManager.GetString("Author", resourceCulture);
            }
        }
        
        /// <summary>
        ///   .exe に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ExecutableExtension {
            get {
                return ResourceManager.GetString("ExecutableExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Parameter
        ///ngenutil
        ///ngenutil action
        ///ngenutil --help | -h | help
        ///
        ///action : 		&quot;
        ///	install &lt;assemblyPath&gt;
        ///	uninstall &lt;assemblyPath&gt;
        ///	update に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ParameterText {
            get {
                return ResourceManager.GetString("ParameterText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   This file name is not correct. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PathMissing {
            get {
                return ResourceManager.GetString("PathMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Applications|*.exe|All files|*.* に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReferFilter {
            get {
                return ResourceManager.GetString("ReferFilter", resourceCulture);
            }
        }
    }
}
