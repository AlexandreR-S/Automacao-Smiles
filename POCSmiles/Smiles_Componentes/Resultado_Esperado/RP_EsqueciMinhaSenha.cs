/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 06/06/2017
 * Time: 09:34
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
	/// Description of RP_EsqueciMinhaSenha.
	/// </summary>
	[TestModule("3761B01A-D54C-4ECE-9D00-7FAA542C8D0C", ModuleType.UserCode, 1)]
	public class RP_EsqueciMinhaSenha : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_EsqueciMinhaSenha instance = new RP_EsqueciMinhaSenha();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_EsqueciMinhaSenha()
		{
			// Do not delete - a parameterless constructor is required!
		}
		public static RP_EsqueciMinhaSenha Instance
		{
			get { return instance; }
		}
		
		
		#region Variables

		string _CPF ;

		/// <summary>
		/// Gets or sets the value of variable CPF.
		/// </summary>
		[TestVariable("cae5717f-1703-482c-8a07-fb233ebf33f8")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
		}


		#endregion

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			
			var iComponentStatus = Program.startComponent();
			
			CPF = Program.getProtonValue("in_CPF");
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmail'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmailInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmailInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmail' at 125;34.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmailInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarEmail.Click("125;34", 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_NovaSenhaFoiEnviadaPara'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_NovaSenhaFoiEnviadaParaInfo, new RecordItemIndex(3));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_NovaSenhaFoiEnviadaParaInfo);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Close message box", "Closing e-mail information box 'repo.SmilesOMelhorProgramaDeMilhasS1.FecharNovaSenhaEnviada'.",repo.SmilesOMelhorProgramaDeMilhasS1.FecharMensagemInfo , new RecordItemIndex(4));
				repo.SmilesOMelhorProgramaDeMilhasS1.FecharMensagem.Click();
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
				
				//UpdateDB(CPF, URL);
				Delay.Milliseconds(0);
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
