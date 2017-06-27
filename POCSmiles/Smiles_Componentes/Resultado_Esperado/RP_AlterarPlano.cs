/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 20/06/2017
 * Time: 17:32
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
	/// Description of RP_AlterarPlano.
	/// </summary>
	[TestModule("B4460E44-6C5C-48D6-8F1F-0EE120FB72DC", ModuleType.UserCode, 1)]
	public class RP_AlterarPlano : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_AlterarPlano instance = new RP_AlterarPlano();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_AlterarPlano()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_AlterarPlano'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_AlterarPlanoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_AlterarPlanoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_BotaoClose' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_BotaoCloseInfo, new RecordItemIndex(2));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_BotaoClose.Click(1);
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_Voltar.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
				Delay.Duration(500, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_NovoPlano' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_NovoPlanoInfo, new RecordItemIndex(4));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano.Click(1);
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_NovoPlano.Click(1);
				Delay.Milliseconds(0);
				
				Program.WaitSystemLoad("45");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Cancelar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.CancelarInfo, new RecordItemIndex(6));
				//repo.SmilesOMelhorProgramaDeMilhasS1.Clube_CancelarSolicitacao.Click(1);
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_Cancelar.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
				Delay.Duration(1000, false);
				
				Program.WaitSystemLoad("45");
				Delay.Milliseconds(0);
				
				//verificar janela de cancelamento
				Report.Log(ReportLevel.Info, "Mouse", "Verify existence of message object 'SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_Cancelado' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_CanceladoInfo, new RecordItemIndex(8));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_CanceladoInfo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_Voltar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_VoltarInfo, new RecordItemIndex(9));
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_Voltar.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano' at 98;21.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlanoInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano.Click();
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ButtonMudeJa'.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ButtonMudeJaInfo, new RecordItemIndex(11));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ButtonMudeJaInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));

			}
			iComponentStatus = Program.endComponent();

		}
	}
}
