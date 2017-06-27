/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 19/06/2017
 * Time: 12:47
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

namespace POCSmiles.Smiles_Componentes.ClubeSmiles
{
	/// <summary>
	/// Description of ComprarSemTecladoVirualClubeSmilesNew.
	/// </summary>
	[TestModule("36CB0380-BA81-4DE5-B821-3D80DA3EA9B9", ModuleType.UserCode, 1)]
	public class ComprarSemTecladoVirtualClubeSmilesNew : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ComprarSemTecladoVirtualClubeSmilesNew instance = new ComprarSemTecladoVirtualClubeSmilesNew();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ComprarSemTecladoVirtualClubeSmilesNew()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _NomeTitular = "";
		[TestVariable("f81ad5ff-c824-4b0e-8e6f-f8856fa7f97e")]
		public string NomeTitular
		{
			get { return _NomeTitular; }
			set { _NomeTitular = value; }
		}

		string _CodigoSeguranca = "";
		[TestVariable("fa016073-3d9d-4c35-9bec-d3400946afb1")]
		public string CodigoSeguranca
		{
			get { return _CodigoSeguranca; }
			set { _CodigoSeguranca = value; }
		}

		string _AnoVencimento = "";
		[TestVariable("f2cbf80e-86a8-45e8-9ab2-59a6b03fe18b")]
		public string AnoVencimento
		{
			get { return _AnoVencimento; }
			set { _AnoVencimento = value; }
		}

		string _MesVencimento = "";
		[TestVariable("f0247360-2fb2-48f8-a11b-888742c6fa0c")]
		public string MesVencimento
		{
			get { return _MesVencimento; }
			set { _MesVencimento = value; }
		}

		string _NumeroCartao = "";
		[TestVariable("72e30974-9abc-4403-b3f6-b3c8c213d562")]
		public string NumeroCartao
		{
			get { return _NumeroCartao; }
			set { _NumeroCartao = value; }
		}

string _DiaVencimentoClubeSmiles = "";
[TestVariable("2084ff72-9583-48af-88ef-b4415454f7c9")]
public string DiaVencimentoClubeSmiles
{
	get { return _DiaVencimentoClubeSmiles; }
	set { _DiaVencimentoClubeSmiles = value; }
}

string _BandeiraCartaoCredito = "";
[TestVariable("9472afb4-cb02-476d-9a01-afae41fea0fb")]
public string BandeiraCartaoCredito
{
	get { return _BandeiraCartaoCredito; }
	set { _BandeiraCartaoCredito = value; }
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
				
				NomeTitular = Program.getProtonValue("in_Nome_Titular_Cartao");
				NumeroCartao = Program.getProtonValue("in_Numero_Cartao");
				MesVencimento = Program.getProtonValue("in_Mes_Vencimento_Cartao");
				AnoVencimento = Program.getProtonValue("in_Ano_Vencimento_Cartao");
				CodigoSeguranca = Program.getProtonValue("in_Codigo_Seguranca_Cartao");
				DiaVencimentoClubeSmiles = Program.getProtonValue("in_Dia_Vencimento_Clube_Smiles");
				BandeiraCartaoCredito = Program.getProtonValue("in_Bandeira_Cartao");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				//SeleclCreditCardFlag(BandeiraCartaoCredito);
				//Delay.Milliseconds(0);
				
				//WaitSmilesLoad();
				//Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[#'creditCardHolderName']", NomeTitular);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[#'creditCardNumber']", NumeroCartao);
				Delay.Milliseconds(0);
				
				//SelectItemListBox("//select[#'expirationMonth']", MesVencimento);
				//Delay.Milliseconds(0);
				
				//SelectItemListBox("//select[#'expirationYear']", AnoVencimento);
				//Delay.Milliseconds(0);
				
				Program.SelectItemListBoxAsHuman("//div[@Class~'cs-select cs-skin-silver payment'][1]", MesVencimento, "1");
				Delay.Milliseconds(0);
				
				Program.SelectItemListBoxAsHuman("//div[@Class~'cs-select cs-skin-silver payment'][2]", AnoVencimento, "1");
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[#'secureCode']", CodigoSeguranca);
				Delay.Milliseconds(0);
				
				//SelecionarDiaVencimentoClubeSmiles(DiaVencimentoClubeSmiles);
				//Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordoEmissao' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordoEmissaoInfo, new RecordItemIndex(10));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordoEmissao.Click(1);
				//Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.LiEConcordoComOsDoClubeSmilesE' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.LiEConcordoComOsDoClubeSmilesEInfo, new RecordItemIndex(11));
				repo.SmilesOMelhorProgramaDeMilhasS1.LiEConcordoComOsDoClubeSmilesE.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}'.", new RecordItemIndex(12));
				Keyboard.Press("{Next}", 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar' at UpperCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(13));
				repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar.Click(Location.UpperCenter, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
				Delay.Duration(1000, false);
				
				Program.WaitLoad();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
				
				
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
