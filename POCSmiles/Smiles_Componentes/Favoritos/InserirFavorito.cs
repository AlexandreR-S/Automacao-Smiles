/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:33
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

namespace POCSmiles.Smiles_Componentes.Favoritos
{
	/// <summary>
	/// Description of InserirFavoritos.
	/// </summary>
	[TestModule("FC8C62ED-A2B4-4F9A-8A7D-A7B092980365", ModuleType.UserCode, 1)]
	public class InserirFavorito : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static InserirFavorito instance = new InserirFavorito();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public InserirFavorito()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Sexo = "";
		[TestVariable("cf0efeda-eec2-479e-a1c0-a8320e92cd4a")]
		public string Sexo
		{
			get { return _Sexo; }
			set { _Sexo = value; }
		}

		string _Nome = "";
		[TestVariable("dc56ebb7-4337-464c-b75a-f9a06b9f8996")]
		public string Nome
		{
			get { return _Nome; }
			set { _Nome = value; }
		}

		string _Sobrenome = "";
		[TestVariable("61e9c73b-3212-43bd-adc8-0797e8bfb2aa")]
		public string Sobrenome
		{
			get { return _Sobrenome; }
			set { _Sobrenome = value; }
		}

		string _DiaNascimento = "";
		[TestVariable("8836a979-38f0-48ab-9210-b2504d174a76")]
		public string DiaNascimento
		{
			get { return _DiaNascimento; }
			set { _DiaNascimento = value; }
		}

		string _MesNascimento = "";
		[TestVariable("85b2704d-99b7-4795-8147-11c851284b04")]
		public string MesNascimento
		{
			get { return _MesNascimento; }
			set { _MesNascimento = value; }
		}

		string _AnoNascimento = "";
		[TestVariable("b7586204-6af2-4180-9d86-27561a21602e")]
		public string AnoNascimento
		{
			get { return _AnoNascimento; }
			set { _AnoNascimento = value; }
		}

		string _NumeroDocumento = "";
		[TestVariable("9523a231-ac11-48e6-be1f-ad13ee4d8068")]
		public string NumeroDocumento
		{
			get { return _NumeroDocumento; }
			set { _NumeroDocumento = value; }
		}

		string _Email = "";
		[TestVariable("d3722f11-829c-4f8d-bd07-f0102e6cc316")]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		string _TipoDocumento = "";
		[TestVariable("e8a949bc-5057-42a5-8a9c-9be77648cc4b")]
		public string TipoDocumento
		{
			get { return _TipoDocumento; }
			set { _TipoDocumento = value; }
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
			
			Sexo = Program.getProtonValue("in_Sexo");
			Nome = Program.getProtonValue("in_Nome");
			Sobrenome = Program.getProtonValue("in_Sobrenome");
			DiaNascimento = Program.getProtonValue("in_Data_Nascimento_Dia");
			MesNascimento = Program.getProtonValue("in_Data_Nascimento_Mes");
			AnoNascimento = Program.getProtonValue("in_Data_Nascimento_Ano");
			NumeroDocumento = Program.getProtonValue("in_Numero_Documento");
			Email = Program.getProtonValue("in_Email");
			TipoDocumento = Program.getProtonValue("in_Tipo_Documento");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SmilesOMelhorProgramaDeMilhasS1' at UpperLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.SelfInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Self.MoveTo(Location.UpperLeft);
				Delay.Milliseconds(200);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiro' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiroInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiro.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Nome'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_NomeInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Nome.PressKeys(Nome, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sobrenome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Sobrenome'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_SobrenomeInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Sobrenome.PressKeys(Sobrenome, 10);
				Delay.Milliseconds(0);
				
				SelectGenderFlag(Sexo);
				Delay.Milliseconds(10);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DiaNascimento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_DiaNascimento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_DiaNascimentoInfo, new RecordItemIndex(5));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_DiaNascimento.PressKeys(DiaNascimento, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MesNascimento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Month'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_MonthInfo, new RecordItemIndex(6));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Month.PressKeys(MesNascimento, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AnoNascimento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Year'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_YearInfo, new RecordItemIndex(7));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Year.PressKeys(AnoNascimento, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Select() on item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_TipoDocumento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_TipoDocumentoInfo, new RecordItemIndex(8));
				Program.Invoke_Action_Favorito_TipoDocumento(TipoDocumento);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroDocumento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_NumeroDocumento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_NumeroDocumentoInfo, new RecordItemIndex(9));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_NumeroDocumento.PressKeys(NumeroDocumento, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Email' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Email'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_EmailInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Email.PressKeys(Email, 10);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Salvar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_SalvarInfo, new RecordItemIndex(11));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Salvar.Click(1);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(14));
				repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
			}
			
			iComponentStatus = Program.endComponent();
		}
		public void SelectGenderFlag(string sexo)
		{
			try {
				if (sexo.Equals("")) {
					return;
				}
				Report.Info("Selecting " + sexo);
				if (sexo.Equals("Masculino")) {
					Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@type='radio' and @value~'MALE']");
				}else{
					Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@type='radio' and @value~'FEMALE']");
				}
				Report.Info(sexo + " selected");
			} catch (Exception) {
				Report.Error("CadastrarUsuario - Error selecting genre");
				throw new System.Exception("CadastrarUsuario.SeleclGenrerFlag");
			}
		}
	}
}
