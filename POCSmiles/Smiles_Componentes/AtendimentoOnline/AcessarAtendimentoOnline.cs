/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 14:56
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

namespace POCSmiles.Smiles_Componentes.AtendimentoOnline
{
	/// <summary>
	/// Description of AcessarAtendimentoOnline.
	/// </summary>
	[TestModule("EE33A4AB-F731-4FC7-A544-251E7E11C654", ModuleType.UserCode, 1)]
	public class AcessarAtendimentoOnline : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AcessarAtendimentoOnline instance = new AcessarAtendimentoOnline();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AcessarAtendimentoOnline()
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
				
				Ranorex.Controls.ProgressForm.Hide();
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.PossoAjudar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudarInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudar1.Click(1);
				Delay.Milliseconds(490);
				
//			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Emilia' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_Preenchimento'.", repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_PreenchimentoInfo, new RecordItemIndex(1));
//			repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_Preenchimento.PressKeys("Emilia", 1);
//			Delay.Milliseconds(90);
//
//			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_Preenchimento'.", repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_PreenchimentoInfo, new RecordItemIndex(2));
//			repo.SmilesOMelhorProgramaDeMilhasS1.PossoAjudar_Preenchimento.PressKeys("{Return}", 1);
//			Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnline'.", repo.AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnlineInfo, new RecordItemIndex(3));
				//objeto atualizado para processo realizado no ambiente UAT3 - Alexandre Rodrigues - 20170619
				//Validate.Exists(repo.AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnlineInfo);
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Atendimento_AtendimentoOnlineInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
