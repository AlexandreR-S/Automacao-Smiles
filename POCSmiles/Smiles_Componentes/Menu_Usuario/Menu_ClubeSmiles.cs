/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 10:26
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

namespace POCSmiles.Smiles_Componentes.Menu_Usuario
{
	/// <summary>
	/// Description of Menu_ClubeSmiles.
	/// </summary>
	[TestModule("BA5C5CB8-EE03-4EA5-82F0-A55F7F122D11", ModuleType.UserCode, 1)]
	public class Menu_ClubeSmiles : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static Menu_ClubeSmiles instance = new Menu_ClubeSmiles();
		
		public Menu_ClubeSmiles()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static Menu_ClubeSmiles Instance
		{
			get { return instance; }
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
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles' at 49;9.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmilesInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles.Click("49;9", 1);
				Delay.Milliseconds(490);
				
				Program.WaitPageLoad();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste'.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(2));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(3));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}