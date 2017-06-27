/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 06/06/2017
 * Time: 11:50
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
	/// Description of RP_NavegacaoLinksPromocoes.
	/// </summary>
	[TestModule("4E120DFA-7113-46C3-A086-6252B0135919", ModuleType.UserCode, 1)]
	public class RP_NavegacaoLinksPromocoes : ITestModule
	{
	
		 public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_NavegacaoLinksPromocoes instance = new RP_NavegacaoLinksPromocoes();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_NavegacaoLinksPromocoes()
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
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_LeiaOsTermosECondicoesNaIntegra'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_LeiaOsTermosECondicoesNaIntegraInfo, new RecordItemIndex(0));
			Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_LeiaOsTermosECondicoesNaIntegraInfo);
			Delay.Milliseconds(100);
			
			Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));

		}
	}
}
