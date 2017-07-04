/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 17:18
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
	/// Description of PagamentoComTecladoVirtual.
	/// </summary>
	[TestModule("1E2EDD88-8DB4-4771-B4C5-00EDA3CB64EE", ModuleType.UserCode, 1)]
	public class PagamentoComTecladoVirtual : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static PagamentoComTecladoVirtual instance = new PagamentoComTecladoVirtual();
		
		public PagamentoComTecladoVirtual()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static PagamentoComTecladoVirtual Instance
		{
			get { return instance; }
		}
		
		#region Variables

		string _NomeTitular;

		/// <summary>
		/// Gets or sets the value of variable NomeTitular.
		/// </summary>
		[TestVariable("fc16fb03-5156-4007-b730-647942f38c09")]
		public string NomeTitular
		{
			get { return _NomeTitular; }
			set { _NomeTitular = value; }
		}

		string _NumeroCartao;

		/// <summary>
		/// Gets or sets the value of variable NumeroCartao.
		/// </summary>
		[TestVariable("a6916ecb-effc-4712-99c4-a25af4b5b359")]
		public string NumeroCartao
		{
			get { return _NumeroCartao; }
			set { _NumeroCartao = value; }
		}

		string _MesVencimento;

		/// <summary>
		/// Gets or sets the value of variable MesVencimento.
		/// </summary>
		[TestVariable("f802c138-811f-4a8a-9712-1a29c1e2544a")]
		public string MesVencimento
		{
			get { return _MesVencimento; }
			set { _MesVencimento = value; }
		}

		string _AnoVencimento;

		/// <summary>
		/// Gets or sets the value of variable AnoVencimento.
		/// </summary>
		[TestVariable("12c3b37f-9ff4-449f-af58-c8921599d2ff")]
		public string AnoVencimento
		{
			get { return _AnoVencimento; }
			set { _AnoVencimento = value; }
		}

		string _CodigoSeguranca;

		/// <summary>
		/// Gets or sets the value of variable CodigoSeguranca.
		/// </summary>
		[TestVariable("b6b4c220-e203-400a-9aca-08f83502a1aa")]
		public string CodigoSeguranca
		{
			get { return _CodigoSeguranca; }
			set { _CodigoSeguranca = value; }
		}

		string _Parcelas;

		/// <summary>
		/// Gets or sets the value of variable Parcelas.
		/// </summary>
		[TestVariable("5f00993e-ef31-4245-bbbe-8f8ab9604bd8")]
		public string Parcelas
		{
			get { return _Parcelas; }
			set { _Parcelas = value; }
		}

		string _TecladoVirtual;

		/// <summary>
		/// Gets or sets the value of variable TecladoVirtual.
		/// </summary>
		[TestVariable("876f5bc4-e78f-4930-a337-e5706a44e943")]
		public string TecladoVirtual
		{
			get { return _TecladoVirtual; }
			set { _TecladoVirtual = value; }
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
			
			NomeTitular = Program.getProtonValue("in_Nome_Titular_Cartao");
			NumeroCartao = Program.getProtonValue("in_Numero_Cartao");
			MesVencimento = Program.getProtonValue("in_Mes_Vencimento_Cartao");
			AnoVencimento = Program.getProtonValue("in_Ano_Vencimento_Cartao");
			CodigoSeguranca = Program.getProtonValue("in_Codigo_Seguranca_Cartao");
			Parcelas = Program.getProtonValue("in_Parcelas");
			TecladoVirtual = Program.getProtonValue("in_Teclado_Virtual");
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Program.TypeKeys("//input[@id='creditCardNumber' or @id='cardNumber']", NumeroCartao);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id='cardHolderName' or @id='creditCardHolderName']", NomeTitular);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id='cardDataMonth' or @id='expirationMonth']/../", MesVencimento);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id='cardDataYear' or @id='expirationYear']/../", AnoVencimento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id='cardCvc' or @id='secureCode']", CodigoSeguranca);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id='installmentSelect' or @id='installmentSelector']/../", Parcelas);
				Delay.Milliseconds(0);
				
				Program.InserirTecladoVirtual(TecladoVirtual);
				Delay.Milliseconds(0);
				
				Program.ClickIfExist();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento.Click(1);
				Delay.Milliseconds(490);
				
				Program.WaitLoad();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}