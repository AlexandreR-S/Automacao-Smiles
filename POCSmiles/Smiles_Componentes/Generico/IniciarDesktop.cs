/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 02/06/2017
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;
using POCSmiles.Mobile.AppSmiles.InicializacaoApp;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace POCSmiles.Smiles_Componentes.Generico
{
	/// <summary>
	/// Description of IniciarDesktop.
	/// </summary>
	[TestModule("50E42E85-06F5-4206-9CB7-80B8E8DB2D4A", ModuleType.UserCode, 1)]
	public class IniciarDesktop : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static IniciarDesktop instance = new IniciarDesktop();
		
		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static IniciarDesktop Instance
		{
			get { return instance; }
		}
		
		#region Variables
		string _Browser;
		[TestVariable("1fcbfc99-8966-4b0c-a71c-b3a17a12ca1d")]
		public string Browser
		{
			get { return _Browser; }
			set { _Browser = value; }
		}
		
		string _URL;
		[TestVariable("185f0992-ce86-4626-a0de-4d44904e5717")]
		public string URL
		{
			get { return _URL; }
			set { _URL = value; }
		}
		#endregion
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public IniciarDesktop()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				#region parameter
				URL = Program.getProtonValue("in_URL");
				Browser = Program.getProtonValue("in_Navegador");
				#endregion
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Program.Begin(Browser, URL);
				Delay.Milliseconds(0);
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
