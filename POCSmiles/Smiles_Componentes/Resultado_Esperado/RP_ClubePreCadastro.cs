/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 19/06/2017
 * Time: 13:40
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
	/// Description of RP_ClubePreCadastro.
	/// </summary>
	[TestModule("C825CD40-A4D7-4B17-9F8D-3B360276CB09", ModuleType.UserCode, 1)]
	public class RP_ClubePreCadastro : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ClubePreCadastro instance = new RP_ClubePreCadastro();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_ClubePreCadastro()
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
				
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesao'.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesaoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesaoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
			
			
		}
	}
}
