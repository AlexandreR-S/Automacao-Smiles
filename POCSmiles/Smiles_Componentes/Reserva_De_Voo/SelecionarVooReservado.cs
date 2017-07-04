/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 17:00
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

namespace POCSmiles.Smiles_Componentes.Reserva_De_Voo
{
	/// <summary>
	/// Description of SelecionarVooReservado.
	/// </summary>
	[TestModule("C1448EF8-6971-43EB-AE08-C4F96686FC05", ModuleType.UserCode, 1)]
	public class SelecionarVooReservado : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static SelecionarVooReservado instance = new SelecionarVooReservado();
		
		public SelecionarVooReservado()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static SelecionarVooReservado Instance
		{
			get { return instance; }
		}

#region Variables

        string _IdentificacaoVoo;

        /// <summary>
        /// Gets or sets the value of variable IdentificacaoVoo.
        /// </summary>
        [TestVariable("92b71bb5-3bc2-4e56-bace-e9bf398b382d")]
        public string IdentificacaoVoo
        {
            get { return _IdentificacaoVoo; }
            set { _IdentificacaoVoo = value; }
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
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			var iComponentStatus = Program.startComponent();
			
			IdentificacaoVoo = Program.getProtonValue("in_Identificacao_Voo");
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				SelecionarVoo(IdentificacaoVoo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			
			iComponentStatus = Program.endComponent();
		}
		
		public void SelecionarVoo(string identificador)
		{
			try {
				Report.Info("Searching fly '" + identificador + "'");
				WebElement element = repo.SmilesOMelhorProgramaDeMilhasS1.VoosRservados_BotaoFinalizarReservaInfo.AbsolutePath.ToResolvedString().Replace("XXX",identificador);
				element.Click(Duration.FromMilliseconds(1));
				Report.Info("Fly '" + identificador + "' identified");
			} catch (Exception e) {
				Report.Error("SelecionarVooReservado - Error trying to select. Error:" + e.Message);
				throw new System.Exception("SelecionarVooReservado.SelecionarVoo");
			}
		}
	}
}