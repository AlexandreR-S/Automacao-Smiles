/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 11:24
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
	/// Description of RP_ImprimirCartao.
	/// </summary>
	[TestModule("6C666C74-FE7F-4C75-BC50-6ED3354A98A5", ModuleType.UserCode, 1)]
	public class RP_ImprimirCartao : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ImprimirCartao instance = new RP_ImprimirCartao();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_ImprimirCartao()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_VisulizacaoCartao'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_VisulizacaoCartaoInfo, new RecordItemIndex(0));
				Smiles_UserCode.WaitLoad(repo, 60);
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_VisulizacaoCartaoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
