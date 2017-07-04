/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 17:51
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
	/// Description of RP_FinalizacaoReserva.
	/// </summary>
	[TestModule("5E6225C6-B06A-4D16-A21E-C9C7A0256328", ModuleType.UserCode, 1)]
	public class RP_FinalizacaoReserva : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_FinalizacaoReserva instance = new RP_FinalizacaoReserva();
		
		public RP_FinalizacaoReserva()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static RP_FinalizacaoReserva Instance
		{
			get { return instance; }
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
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}