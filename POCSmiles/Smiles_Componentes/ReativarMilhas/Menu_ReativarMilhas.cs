/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 22/06/2017
 * Time: 13:48
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

namespace POCSmiles.Smiles_Componentes.ReativarMilhas
{
	/// <summary>
	/// Description of Menu_ReativarMilhas.
	/// </summary>
	[TestModule("42402D9F-0426-4013-86AE-91AA3139B879", ModuleType.UserCode, 1)]
	public class Menu_ReativarMilhas : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static Menu_ReativarMilhas instance = new Menu_ReativarMilhas();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Menu_ReativarMilhas()
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
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhas' at 72;7.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhasInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhas.Click("72;7", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhas' at 143;16.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhasInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhas.Click("143;16", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhasInfo, new RecordItemIndex(3));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhasInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
				
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
