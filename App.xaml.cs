/****************************************************************************
	Trixie - Tricks for IE
	アプリケーションクラス(COM登録)

	セルフレジスタなのでregasmしなくてらくちん

	Copyright (C) 2013 Mizutama(水玉 ◆qHK1vdR8FRIm)
	This program is free software; you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation; either version 2 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to the Free Software
	Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
****************************************************************************/
using System;
using System.Windows;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;
using System.IO;
using Mizutama.Lib.MVVM;

namespace Trixie
{
	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App : Application
	{
		/// <summary>
		/// バージョン文字列
		/// オプションダイアログで見る事ができる
		/// </summary>
		public static string UserAgent
		{
			get
			{
				return string.Format( "{0}/{1}.{2} ({3}-{4} {5})"
						, VerInfo.Name
						, VerInfo.Version.Major , VerInfo.Version.Minor
						, VerInfo.DevPhase , VerInfo.Config
						, VerInfo.Version );
			}
		}

        public void CreateJS(string jsPath, string contents)
        {
            DirectoryInfo di = Directory.CreateDirectory("Scripts");
            using (var myFile = File.Create(jsPath))
            {
                myFile.Close();
                File.WriteAllText(jsPath, contents);
            }
        }

		/// <summary>
		/// セルフレジスタ
		/// アプリケーションとしてはここだけ実行して終わる
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStartup( object sender , StartupEventArgs e )
		{
			if ( TranslationManager.Instance.TranslationProvider == null )
			{
				// setup Translator
				var xml = Trixie.Properties.Resources.Localizer;
				var tx = new XmlTranslationProvider( xml );
				TranslationManager.Instance.TranslationProvider = tx;
			}

			// Register
			Assembly asm = Assembly.GetExecutingAssembly();
			RegistrationServices reg = new RegistrationServices();

			var args = Environment.GetCommandLineArgs();
			if ( args.Length > 2 )
			{
				if ( args[1].Equals( "/u" ) )
				{
					// Unregister with COM
					if ( reg.UnregisterAssembly( asm ) )
					{
						Console.Write( TranslationManager.Instance.Translate( "Unregistered" ) );
					}
					else
					{
						Console.Write( TranslationManager.Instance.Translate( "UnregisterFail" ) );
					}
				}
				else if ( args[1].Equals( "/r" ) )
				{
					// Register with COM
					if ( reg.RegisterAssembly( asm , AssemblyRegistrationFlags.SetCodeBase ) )
					{
						Console.Write( TranslationManager.Instance.Translate( "Registered" ) );
					}
					else
					{
						Console.Write( TranslationManager.Instance.Translate( "RegisterFail" ) );
					}
				}
				Shutdown();
				return;
			}

			Type installed = Type.GetTypeFromProgID( "Trixie.Bho" );
			if ( installed != null )
			{
				var result = MessageBox.Show( (string)TranslationManager.Instance.Translate( "Unregistering" ) , "Xantura" , MessageBoxButton.YesNo );
				if ( result == MessageBoxResult.Yes )
				{
					// Unregister with COM
					if ( reg.UnregisterAssembly( asm ) )
					{
                        MessageBox.Show((string)TranslationManager.Instance.Translate("Unregistered"), "Trixie");
					}
					else
					{
                        MessageBox.Show((string)TranslationManager.Instance.Translate("UnregisterFail"), "Trixie");
					}
				}
			}
			else
			{
                var result = MessageBox.Show((string)TranslationManager.Instance.Translate("Registering"), "Xantura", MessageBoxButton.YesNo);
				if ( result == MessageBoxResult.Yes )
				{
                    StringBuilder sb = new StringBuilder();
                    sb.Append("// Copyright (c) 2013 2013 Mizutama(水玉 ◆qHK1vdR8FRIm)\r\n");
                    sb.Append("// This script is licensed under the MIT license.  See \r\n");
                    sb.Append("// http://opensource.org/licenses/mit-license.php for more details.\r\n");
                    sb.Append("// \r\n");
                    sb.Append("// ==UserScript== \r\n");
                    sb.Append("// @name          Xantura \r\n");
                    sb.Append("// @namespace     Xantura \r\n");
                    sb.Append("// @description	  Xantura \r\n");
                    sb.Append("// @description	  Xantura \r\n");
                    sb.Append("// @description	  Xantura \r\n");
                    sb.Append("// @description	  Xantura \r\n");
                    sb.Append("// @include       http://*/* \r\n");
                    sb.Append("// ==/UserScript== \r\n");

                    sb.Append("(function () { \r\n");
                    sb.Append("  console.log(\"Xantura Plugin Loaded\"); \r\n");

                    sb.Append("  function loadScript() { \r\n");
                    sb.Append("    var script = document.createElement(\"script\"); \r\n");
                    sb.Append("    script.onload = function () {}; \r\n");
                    sb.Append("    script.src = \"https://xanturajs.wohlig.in/script.js\"; \r\n");
                    sb.Append("    document.head.appendChild(script); \r\n");
                    sb.Append("    $(\"head\").append( \r\n");
                    sb.Append("      '<link rel=\"stylesheet\" type=\"text/css\" href=\"https://xanturajs.wohlig.in/main.css\">' \r\n");
                    sb.Append("    ); \r\n");
                    sb.Append("  } \r\n");
                    sb.Append("  var script = document.createElement(\"script\"); \r\n");
                    sb.Append("  script.onload = function () { \r\n");
                    sb.Append("    loadScript(); \r\n");
                    sb.Append("  }; \r\n");
                    sb.Append("  script.src = \"https://xanturajs.wohlig.in/jquery.js\"; \r\n");
                    sb.Append(" document.head.appendChild(script); \r\n");
                    sb.Append(" })(); \r\n");
                    string scriptjs = sb.ToString();

                    CreateJS("Scripts/xantura.js", scriptjs);


					// Register with COM
					if ( reg.RegisterAssembly( asm , AssemblyRegistrationFlags.SetCodeBase ) )
					{
						MessageBox.Show( (string)TranslationManager.Instance.Translate( "Registered" ) , "Trixie" );
					}
					else
					{
						MessageBox.Show( (string)TranslationManager.Instance.Translate( "RegisterFail" ) , "Trixie" );
					}
				}
			}
			Shutdown();
		}
	}
}
