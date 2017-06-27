/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 23/06/2017
 * Time: 11:57
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
	/// Description of SelecionarVooAssento.
	/// </summary>
	[TestModule("46C07DF2-A27F-44F6-BC3A-CB76EEB117E6", ModuleType.UserCode, 1)]
	public class SelecionarVooAssento : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static SelecionarVooAssento instance = new SelecionarVooAssento();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SelecionarVooAssento()
		{
			// Do not delete - a parameterless constructor is required!
		}

string _IdentificacaoVoo = "";
[TestVariable("a9f4a0a7-9c7f-4d39-8dff-cb6f3f086228")]
public string IdentificacaoVoo
{
	get { return _IdentificacaoVoo; }
	set { _IdentificacaoVoo = value; }
}

string _TipoAssento = "";
[TestVariable("ede7e26b-eac4-4d30-8ca3-7bd3857446c2")]
public string TipoAssento
{
	get { return _TipoAssento; }
	set { _TipoAssento = value; }
}

string _TipoPagamentoAssento = "";
[TestVariable("cb865c3a-e324-4309-bb08-de1e6a35020e")]
public string TipoPagamentoAssento
{
	get { return _TipoPagamentoAssento; }
	set { _TipoPagamentoAssento = value; }
}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			
			IdentificacaoVoo = "ID";//Program.getProtonValue("in_");
			TipoAssento = "tipoa";//Program.getProtonValue("in_");
			TipoPagamentoAssento = "tipop";//Program.getProtonValue("in_");
			
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
            Program.SelecionarVoo(IdentificacaoVoo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ProximosVoos_BotaoExpandir' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ProximosVoos_BotaoExpandirInfo, new RecordItemIndex(2));
            //repo.SmilesOMelhorProgramaDeMilhasS1.ProximosVoos_BotaoExpandir.Click(1);
            //Delay.Milliseconds(0);
            
            Program.WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos'.", repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo, new RecordItemIndex(4));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo);
            Delay.Milliseconds(0);
            
            Program.SelecionarAssento(TipoAssento, TipoPagamentoAssento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Program.WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo, new RecordItemIndex(9));
            repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(10));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo);
            Delay.Milliseconds(0);
            
            Program.captureData();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
		}
	}
}
