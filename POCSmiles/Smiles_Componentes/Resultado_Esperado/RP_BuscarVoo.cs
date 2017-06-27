/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 09/06/2017
 * Time: 16:53
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
	/// Description of RP_BuscarVoo.
	/// </summary>
	[TestModule("463C8D99-8F48-4CB0-B9C6-659A7BFFEDEB", ModuleType.UserCode, 1)]
	public class RP_BuscarVoo : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_BuscarVoo instance = new RP_BuscarVoo();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_BuscarVoo()
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
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_SelecioneVoo'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_SelecioneVooInfo, new RecordItemIndex(0));
			Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_SelecioneVooInfo);
			Delay.Milliseconds(100);
			
			Program.FocusModalMenssage();
			Delay.Milliseconds(0);
			
			Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			
		}
	}
}
