/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 10:58
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
	/// Description of CadastrarUsuario.
	/// </summary>
	[TestModule("0E94208E-E2D5-4D94-99FF-D45A62BD6362", ModuleType.UserCode, 1)]
	public class CadastrarUsuario : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static CadastrarUsuario instance = new CadastrarUsuario();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CadastrarUsuario()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Nome = "";
		[TestVariable("975740fe-7d9a-4e4f-80e2-51410433f226")]
		public string Nome
		{
			get { return _Nome; }
			set { _Nome = value; }
		}

		string _Sobrenome = "";
		[TestVariable("e6b998a2-0293-4836-8340-63757c048130")]
		public string Sobrenome
		{
			get { return _Sobrenome; }
			set { _Sobrenome = value; }
		}

		string _Nacionalidade = "";
		[TestVariable("e8cde93a-a79d-4317-913a-61b516497ac1")]
		public string Nacionalidade
		{
			get { return _Nacionalidade; }
			set { _Nacionalidade = value; }
		}

		string _Idioma = "";
		[TestVariable("244d5099-d9fa-49c3-a731-91a43ef94517")]
		public string Idioma
		{
			get { return _Idioma; }
			set { _Idioma = value; }
		}

		string _Sexo = "";
		[TestVariable("f118a0dd-2fc7-4dd6-9d98-b0f171d3cee0")]
		public string Sexo
		{
			get { return _Sexo; }
			set { _Sexo = value; }
		}

		string _DataNascimento = "";
		[TestVariable("1174be80-4f8a-41b8-9e67-e8828a3f9744")]
		public string DataNascimento
		{
			get { return _DataNascimento; }
			set { _DataNascimento = value; }
		}

		string _TipoDocumento = "";
		[TestVariable("9d6ad897-8332-41e9-ab18-9e66c4762008")]
		public string TipoDocumento
		{
			get { return _TipoDocumento; }
			set { _TipoDocumento = value; }
		}

		string _Documento = "";
		[TestVariable("707adc11-7c0b-4da6-b30b-9de65ed9cea2")]
		public string Documento
		{
			get { return _Documento; }
			set { _Documento = value; }
		}

		string _CPF = "";
		[TestVariable("be55fc29-2e8c-4c3b-9db4-cb816c898ba9")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
		}

		string _DDIRes = "";
		[TestVariable("69e9ee58-9cbb-4d27-8d63-ee4239f55938")]
		public string DDIRes
		{
			get { return _DDIRes; }
			set { _DDIRes = value; }
		}

		string _DDRes = "";
		[TestVariable("667f51e4-7f29-4cdf-9d2e-56d7e63d2ec3")]
		public string DDRes
		{
			get { return _DDRes; }
			set { _DDRes = value; }
		}

		string _NumRes = "";
		[TestVariable("ba6861cb-497c-49a2-b4b2-6691380347e0")]
		public string NumRes
		{
			get { return _NumRes; }
			set { _NumRes = value; }
		}

		string _DDICel = "";
		[TestVariable("62a38ea0-7b0e-4803-ab3e-00ff0942fe12")]
		public string DDICel
		{
			get { return _DDICel; }
			set { _DDICel = value; }
		}

		string _DDCel = "";
		[TestVariable("9fa2a74c-cc63-4695-bfb8-7d6b8e64276a")]
		public string DDCel
		{
			get { return _DDCel; }
			set { _DDCel = value; }
		}

		string _NumCel = "";
		[TestVariable("4332a2e0-abc8-4b48-865e-96a4b95dfa4f")]
		public string NumCel
		{
			get { return _NumCel; }
			set { _NumCel = value; }
		}

		string _Email = "";
		[TestVariable("33b0d80e-1ecf-41ad-b602-d6b3e3d703c4")]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		string _ConfirmarEmail = "";
		[TestVariable("5ab8dc3e-56b9-49d5-87e7-74ac529e52e6")]
		public string ConfirmarEmail
		{
			get { return _ConfirmarEmail; }
			set { _ConfirmarEmail = value; }
		}

		string _EnderecoPais = "";
		[TestVariable("ba5f3b59-f9d7-4926-aead-d92cbc09a6d3")]
		public string EnderecoPais
		{
			get { return _EnderecoPais; }
			set { _EnderecoPais = value; }
		}

		string _EnderecoCEP = "";
		[TestVariable("90f42915-51e9-4e51-8eda-d001b6b7a745")]
		public string EnderecoCEP
		{
			get { return _EnderecoCEP; }
			set { _EnderecoCEP = value; }
		}

		string _EnderecoNum = "";
		[TestVariable("2a4cf631-a863-4c47-b89a-133e70830884")]
		public string EnderecoNum
		{
			get { return _EnderecoNum; }
			set { _EnderecoNum = value; }
		}

		string _EnderecoCidade = "";
		[TestVariable("7bff8bf6-6be6-4e73-972e-be5371b01efb")]
		public string EnderecoCidade
		{
			get { return _EnderecoCidade; }
			set { _EnderecoCidade = value; }
		}

		string _Senha = "";
		[TestVariable("eefd8fd4-5b48-4fa3-9704-3128097d3936")]
		public string Senha
		{
			get { return _Senha; }
			set { _Senha = value; }
		}

		string _EnderecoRua = "";
		[TestVariable("65613a3f-21aa-4fd0-a786-a8ada323a06c")]
		public string EnderecoRua
		{
			get { return _EnderecoRua; }
			set { _EnderecoRua = value; }
		}

		string _EnderecoUF = "";
		[TestVariable("4f2d1ee0-528a-4b94-b76b-6cda533c6fe2")]
		public string EnderecoUF
		{
			get { return _EnderecoUF; }
			set { _EnderecoUF = value; }
		}

		string _out_CPF = "";
		[TestVariable("53e6b277-dd2d-4e5f-b128-ac0f2cdfb186")]
		public string out_CPF
		{
			get { return _out_CPF; }
			set { _out_CPF = value; }
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

			Nome = Program.getProtonValue("in_Nome");
			Sobrenome = Program.getProtonValue("in_Sobrenome");
			Nacionalidade = Program.getProtonValue("in_Nacionalidade");
			Idioma = Program.getProtonValue("in_Idioma");
			Sexo = Program.getProtonValue("in_Sexo");
			DataNascimento = Program.getProtonValue("in_Data_Nascimento");
			TipoDocumento = Program.getProtonValue("in_Tipo_Documento");
			Documento = Program.getProtonValue("in_Numero_Documento");
			CPF = Program.getProtonValue("in_CPF");
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
			Senha = Program.getProtonValue("in_Senha");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){

				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.CadastreSe' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.CadastreSeInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.CadastreSe.Click(Location.LowerCenter, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_Nome'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NomeInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NomeInfo);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_Nome'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NomeInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_Nome.PressKeys(Nome, 1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sobrenome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_Sobrenome'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_SobrenomeInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_Sobrenome.PressKeys(Sobrenome, 1);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'_selectNacionality']", Nacionalidade);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'_selectLanguage']", Idioma);
				Delay.Milliseconds(0);
				
				Program.SelectGenderFlag(".//div[@class~'control-group field-wrapper']",Sexo);
				Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
				//Delay.Duration(500, false);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_DiaNascimento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DiaNascimentoInfo, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DiaNascimento.PressKeys(DataNascimento, 50);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'_documentType']", TipoDocumento);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_DocumentoIdentidade'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DocumentoIdentidadeInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DocumentoIdentidade.PressKeys(Documento, 1);
				Delay.Milliseconds(0);
				
				CPF = Program.setCpf(CPF);
				Delay.Milliseconds(0);
				
				out_CPF = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CPF, "tagvalue");
				Program.setProtonOutput("out_CPF", out_CPF);
				
				Program.TypeKeys("//input[@id<'_homePhoneDDI']", DDIRes);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DDRes' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDResidencial'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDResidencialInfo, new RecordItemIndex(13));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDResidencial.PressKeys(DDRes, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumRes' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_TelefoneResidencial'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_TelefoneResidencialInfo, new RecordItemIndex(14));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_TelefoneResidencial.PressKeys(NumRes, 1);
				Delay.Milliseconds(90);
				
				Program.TypeKeys("//input[@id<'_cellPhoneDDI']", DDICel);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DDCel' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDCelular'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDCelularInfo, new RecordItemIndex(16));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_DDDCelular.PressKeys(DDCel, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumCel' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCelular'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCelularInfo, new RecordItemIndex(17));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCelular.PressKeys(NumCel, 1);
				Delay.Milliseconds(90);
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_Email, Email);
				Delay.Milliseconds(0);
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_ConfirmarEmail, ConfirmarEmail);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'_selectCountry']", EnderecoPais);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EnderecoCEP' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_CEP'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CEPInfo, new RecordItemIndex(21));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CEP.PressKeys(EnderecoCEP, 1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EnderecoRua' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_Endereco'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_EnderecoInfo, new RecordItemIndex(22));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_Endereco.PressKeys(EnderecoRua, 1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EnderecoNum' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCasa'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCasaInfo, new RecordItemIndex(23));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_NumeroCasa.PressKeys(EnderecoNum, 1);
				Delay.Milliseconds(0);
				
				Program.SelectItemListBox("//select[@id<'_stateBrazilian']", EnderecoUF);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EnderecoCIdade' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_Cidade'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CidadeInfo, new RecordItemIndex(25));
				//repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_Cidade.PressKeys(EnderecoCIdade, 1);
				Program.TypeKeys("//input[@id<'_city']", EnderecoCidade);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Senha' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_CrieSuaSenha'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CrieSuaSenhaInfo, new RecordItemIndex(26));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CrieSuaSenha.PressKeys(Senha, 1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Senha' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_ConfirmarSenha'.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_ConfirmarSenhaInfo, new RecordItemIndex(27));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_ConfirmarSenha.PressKeys(Senha, 1);
				Delay.Milliseconds(0);
				
				Program.SelectCheckBox("//input[@id<'_acceptTermsCheckbox']", ValueConverter.ArgumentFromString<bool>("check", "True"));
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Cadastro_FinalizarCadastro' at 84;12.", repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_FinalizarCadastroInfo, new RecordItemIndex(29));
				repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_FinalizarCadastro.Click("84;12", 1);
				Delay.Milliseconds(490);
				
				/*string sucesso = repo.SmilesOMelhorProgramaDeMilhasS1.ValidacaoPositiva_DadosAtualizadosComSucesso.GetInnerHtml();
			If (sucesso.Equals("Cadastro concluído com sucesso")) {
				Report.Log("Sucesso");
			}*/
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(30));
				
			}
			
			iComponentStatus = Program.endComponent();
			
		}
	}
}
