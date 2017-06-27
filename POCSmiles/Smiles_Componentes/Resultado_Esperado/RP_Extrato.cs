/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 10:48
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

namespace POCSmiles.Smiles_Componentes.Extrato
{
	/// <summary>
	/// Description of RP_AcessarExtrato.
	/// </summary>
	[TestModule("906BD41C-51B7-4DA3-BD83-B87057C64BDB", ModuleType.UserCode, 1)]
	public class RP_Extrato : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_Extrato instance = new RP_Extrato();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_Extrato()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_Extrato'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_ExtratoInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_Extrato.EnsureVisible();
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_ExtratoInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
