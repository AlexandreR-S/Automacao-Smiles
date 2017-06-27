/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 19/06/2017
 * Time: 12:44
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

namespace POCSmiles.Smiles_Componentes.ClubeSmiles
{
	/// <summary>
	/// Description of MenuClubeSmiles.
	/// </summary>
	[TestModule("9A0AF39D-6F43-49BE-9DD8-1EBB69A144BB", ModuleType.UserCode, 1)]
	public class MenuClubeSmiles : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static MenuClubeSmiles instance = new MenuClubeSmiles();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public MenuClubeSmiles()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles' at 49;13.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmilesInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles.Click("49;13", 1);
				Delay.Milliseconds(490);
				
				Program.WaitPageLoad();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste'.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(2));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(3));
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
