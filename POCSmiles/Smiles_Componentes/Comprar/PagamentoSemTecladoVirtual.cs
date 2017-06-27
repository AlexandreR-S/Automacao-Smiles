/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 21/06/2017
 * Time: 13:22
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

namespace POCSmiles.Smiles_Componentes.Comprar
{
	/// <summary>
	/// Description of PagamentoSemTecladoVirtual.
	/// </summary>
	[TestModule("9154188D-731B-40DE-81AD-E10709FF6340", ModuleType.UserCode, 1)]
	public class PagamentoSemTecladoVirtual : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static PagamentoSemTecladoVirtual instance = new PagamentoSemTecladoVirtual();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public PagamentoSemTecladoVirtual()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _NumeroCartao = "";
		[TestVariable("f13199cc-de59-4f9d-91a9-797013adfbd3")]
		public string NumeroCartao
		{
			get { return _NumeroCartao; }
			set { _NumeroCartao = value; }
		}

		string _NomeTitular = "";
		[TestVariable("417215fa-7dd9-47dc-b0c5-d4e3e5ae7d04")]
		public string NomeTitular
		{
			get { return _NomeTitular; }
			set { _NomeTitular = value; }
		}

		string _MesVencimento = "";
		[TestVariable("af15d4bf-26e8-484c-93c8-072ab06fbc61")]
		public string MesVencimento
		{
			get { return _MesVencimento; }
			set { _MesVencimento = value; }
		}

		string _AnoVencimento = "";
		[TestVariable("7e1512b8-a8ef-4f39-aaa6-215279c5deb2")]
		public string AnoVencimento
		{
			get { return _AnoVencimento; }
			set { _AnoVencimento = value; }
		}

		string _CodigoSeguranca = "";
		[TestVariable("b60b54b0-c1da-46b7-be73-fe53bd476f98")]
		public string CodigoSeguranca
		{
			get { return _CodigoSeguranca; }
			set { _CodigoSeguranca = value; }
		}

		string _Parcelas = "";
		[TestVariable("edef52f7-d5d9-4ad0-b422-daede34b3ca1")]
		public string Parcelas
		{
			get { return _Parcelas; }
			set { _Parcelas = value; }
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
				
				NumeroCartao = Program.getProtonValue("in_Numero_Cartao");
				NomeTitular = Program.getProtonValue("in_Nome_Titular_Cartao");
				CodigoSeguranca = Program.getProtonValue("in_Codigo_Seguranca_Cartao");
				AnoVencimento =Program.getProtonValue("in_Ano_Vencimento_Cartao");
				MesVencimento =Program.getProtonValue("in_Mes_Vencimento_Cartao");
				Parcelas = Program.getProtonValue("in_Parcelas");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Program.WaitPageLoad();
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id='creditCardNumber' or @id='cardNumber']", NumeroCartao);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id='cardHolderName' or @id='creditCardHolderName']", NomeTitular);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBoxAsHuman("//div[#'cardDataMonthDiv']", MesVencimento, "1");
				Delay.Milliseconds(0);
				
				Program.SelectItemListBoxAsHuman("//div[#'cardDataYearDiv']", AnoVencimento, "1");
				Delay.Milliseconds(0);
				
//				Program.SelectItemListBox("//select[@id='cardDataMonth' or @id='expirationMonth']/../", MesVencimento);
//				Delay.Milliseconds(0);
//				
//				Program.SelectItemListBox("//select[@id='cardDataYear' or @id='expirationYear']/../", AnoVencimento);
//				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id='cardCvc' or @id='secureCode']", CodigoSeguranca);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id='installmentSelect' or @id='installmentSelector']/../", Parcelas);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo, new RecordItemIndex(9));
				repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento.Click(1);
				Delay.Milliseconds(490);
				
				Program.WaitLoad();
				Delay.Milliseconds(0);
				
				Program.SelectListboxAsUser();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
