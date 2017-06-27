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
	/// Description of AcessarExtrato.
	/// </summary>
	[TestModule("4B7FBC33-DEEE-4829-9B6A-8B86F5C075E9", ModuleType.UserCode, 1)]
	public class AcessarExtrato : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AcessarExtrato instance = new AcessarExtrato();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AcessarExtrato()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MinhaConta_Extrato' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_ExtratoInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_Extrato.Click();
				Delay.Milliseconds(200);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctions'.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctionsInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctionsInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
