/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 22/06/2017
 * Time: 13:54
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

namespace POCSmiles.Smiles_Componentes.Resultado_Esperado
{
	/// <summary>
	/// Description of RP_ReativarMilhas.
	/// </summary>
	[TestModule("5DED8788-050D-4D00-9F9C-87410AF7B9EE", ModuleType.UserCode, 1)]
	public class RP_ReativarMilhas : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ReativarMilhas instance = new RP_ReativarMilhas();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_ReativarMilhas()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MilhasReativadasComSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.MilhasReativadasComSucessoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MilhasReativadasComSucessoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));

			}
			iComponentStatus = Program.endComponent();

		}
	}
}
