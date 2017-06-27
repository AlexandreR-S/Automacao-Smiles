/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 10:57
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

namespace POCSmiles.Smiles_Componentes.Cadastro
{
	/// <summary>
	/// Description of AlterarDados.
	/// </summary>
	[TestModule("D07C12E9-45CE-4F0E-84FD-3A44D358299C", ModuleType.UserCode, 1)]
	public class AlterarDados : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AlterarDados instance = new AlterarDados();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AlterarDados()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Idioma = "";
		[TestVariable("7cdede62-d864-4dc9-9537-bc2f179a1365")]
		public string Idioma
		{
			get { return _Idioma; }
			set { _Idioma = value; }
		}

		string _Documento = "";
		[TestVariable("c2c681ce-128f-4cea-b2ff-2658e83cf99f")]
		public string Documento
		{
			get { return _Documento; }
			set { _Documento = value; }
		}

		string _DDIRes = "";
		[TestVariable("e85ad75b-02b4-41be-bc13-0191af9f6d80")]
		public string DDIRes
		{
			get { return _DDIRes; }
			set { _DDIRes = value; }
		}

		string _DDRes = "";
		[TestVariable("18cfe724-5f82-4d3c-bef0-694050d99262")]
		public string DDRes
		{
			get { return _DDRes; }
			set { _DDRes = value; }
		}

		string _NumRes = "";
		[TestVariable("68cf580a-21d6-4ee9-8e19-44fe2fc0b083")]
		public string NumRes
		{
			get { return _NumRes; }
			set { _NumRes = value; }
		}

		string _DDICel = "";
		[TestVariable("15aed3b6-c558-4e80-87fe-8c96d29023b5")]
		public string DDICel
		{
			get { return _DDICel; }
			set { _DDICel = value; }
		}

		string _DDCel = "";
		[TestVariable("bbf4f90f-f27a-4226-b294-2d985b907d7d")]
		public string DDCel
		{
			get { return _DDCel; }
			set { _DDCel = value; }
		}

		string _NumCel = "";
		[TestVariable("618a810c-b7ce-4ab5-9231-b0f76a00fc9b")]
		public string NumCel
		{
			get { return _NumCel; }
			set { _NumCel = value; }
		}

		string _Email = "";
		[TestVariable("e0af995b-e235-41a7-84e1-d8c1713fc683")]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		string _ConfirmarEmail = "";
		[TestVariable("dea8ec12-d8c2-4dcc-ac29-3e4f585f58ff")]
		public string ConfirmarEmail
		{
			get { return _ConfirmarEmail; }
			set { _ConfirmarEmail = value; }
		}

		string _EnderecoPais = "";
		[TestVariable("a4bcef73-66e0-4e6b-97c8-3c727f66a772")]
		public string EnderecoPais
		{
			get { return _EnderecoPais; }
			set { _EnderecoPais = value; }
		}

		string _EnderecoCEP = "";
		[TestVariable("d4a80986-aee1-44fa-aadb-1ccfe93e4cfb")]
		public string EnderecoCEP
		{
			get { return _EnderecoCEP; }
			set { _EnderecoCEP = value; }
		}

		string _EnderecoRua = "";
		[TestVariable("fea40ce4-9f9a-45c1-9a1a-755337d62827")]
		public string EnderecoRua
		{
			get { return _EnderecoRua; }
			set { _EnderecoRua = value; }
		}

		string _EnderecoNum = "";
		[TestVariable("7118dc0a-d69e-4db3-9d33-6f4c7f72d9a0")]
		public string EnderecoNum
		{
			get { return _EnderecoNum; }
			set { _EnderecoNum = value; }
		}

		string _EnderecoUF = "";
		[TestVariable("825f403c-2bbc-4bc9-a8e0-99331547cd01")]
		public string EnderecoUF
		{
			get { return _EnderecoUF; }
			set { _EnderecoUF = value; }
		}

		string _EnderecoCidade = "";
		[TestVariable("966c9897-dff7-441b-be65-8ed40de28409")]
		public string EnderecoCidade
		{
			get { return _EnderecoCidade; }
			set { _EnderecoCidade = value; }
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
			
			#region Variables
			
			Idioma = Program.getProtonValue("in_Idioma");
			Documento = Program.getProtonValue("in_Numero_Documento");
			DDIRes = Program.getProtonValue("in_DDI_Residencial");
			DDRes = Program.getProtonValue("in_DDD_Residencial");
			NumRes = Program.getProtonValue("in_Telefone_Residencial");
			DDICel = Program.getProtonValue("in_DDI_Celular");
			DDCel = Program.getProtonValue("in_DDD_Celular");
			NumCel = Program.getProtonValue("in_Telefone_Celular");
			Email = Program.getProtonValue("in_Email");
			ConfirmarEmail = Program.getProtonValue("in_Confirmação_Email");
			EnderecoPais = Program.getProtonValue("in_Pais");
			EnderecoCEP = Program.getProtonValue("in_CEP");
			EnderecoRua = Program.getProtonValue("in_Rua");
			EnderecoNum = Program.getProtonValue("in_Numero_Rua");
			EnderecoUF = Program.getProtonValue("in_UF");
			EnderecoCidade = Program.getProtonValue("in_Cidade");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Program.SelectItemListBox("//select[@id~'inputLanguage']", Idioma);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'inputRg']", Documento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'homePhoneDDI']", DDIRes);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'homePhoneDDD']", DDRes);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'homePhoneNumber']", NumRes);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'cellPhoneDDI']", DDICel);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'cellPhoneDDD']", DDCel);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'cellPhoneNumber']", NumCel);
				Delay.Milliseconds(0);
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_Email, Email);
				Delay.Milliseconds(0);
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_ConfirmarEmail, ConfirmarEmail);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'inputCountry']", EnderecoPais);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'inputZipCode']", EnderecoCEP);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'inputAddress']", EnderecoRua);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'inputHomeNumber']", EnderecoNum);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'stateBrazilian']", EnderecoUF);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@id<'inputCity']", EnderecoCidade);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoes' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoesInfo, new RecordItemIndex(16));
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoes.Click(1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
