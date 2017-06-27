/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace POCSmiles.Smiles_Componentes.Links
{
	/// <summary>
	/// Description of NavegacaoLinksFooter.
	/// </summary>
	[TestModule("370C11AF-B3CD-43F4-AF1F-F18199F3349A", ModuleType.UserCode, 1)]
	public class NavegacaoLinksFooter : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;
		
		
		static NavegacaoLinksFooter instance = new NavegacaoLinksFooter();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public NavegacaoLinksFooter()
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
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.NavegacaoFooter_Links' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.NavegacaoFooter_LinksInfo, new RecordItemIndex(0));
			repo.SmilesOMelhorProgramaDeMilhasS1.NavegacaoFooter_Links.Click(1);
			Delay.Milliseconds(490);
			
			Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
		}
	}
}
