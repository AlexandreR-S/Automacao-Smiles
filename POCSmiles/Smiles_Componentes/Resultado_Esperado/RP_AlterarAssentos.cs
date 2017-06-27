/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 23/06/2017
 * Time: 12:03
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
	/// Description of RP_AlterarAssentos.
	/// </summary>
	[TestModule("60E5E2DD-87A9-45B0-AADA-0E7DCF1210F3", ModuleType.UserCode, 1)]
	public class RP_AlterarAssentos : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_AlterarAssentos instance = new RP_AlterarAssentos();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_AlterarAssentos()
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
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo);
            Delay.Milliseconds(0);
            
            //validarReembolso(CPFSmilesID, IdentificacaoVoo, TipoPagamentoAssento);
            //Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NEXT}'.", new RecordItemIndex(3));
            Keyboard.Press("{NEXT}", 5);
            Delay.Milliseconds(90);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
		}
	}
}
