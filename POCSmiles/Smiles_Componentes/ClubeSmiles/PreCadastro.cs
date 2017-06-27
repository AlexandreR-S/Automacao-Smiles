/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 19/06/2017
 * Time: 13:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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
	/// Description of PreCadastro.
	/// </summary>
	[TestModule("5B960023-9641-4FA4-8178-6F874CEE6328", ModuleType.UserCode, 1)]
	public class PreCadastro : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static PreCadastro instance = new PreCadastro();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public PreCadastro()
		{
			// Do not delete - a parameterless constructor is required!
		}
		#region parameter
		string _CPF;
		[TestVariable("6cdfef73-f0af-4e69-8955-45168c709596")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
		}

		string _Nome;
		[TestVariable("7d83dcaa-3d8f-48a9-b2cb-6f9b95e88b05")]
		public string Nome
		{
			get { return _Nome; }
			set { _Nome = value; }
		}

		string _Sobrenome;
		[TestVariable("9b1081ac-16d2-46c9-b958-45311bdf5364")]
		public string Sobrenome
		{
			get { return _Sobrenome; }
			set { _Sobrenome = value; }
		}

		string _DataNascimentoDia;
		[TestVariable("ce5858b8-4b6c-415c-9d60-3e63cca32c17")]
		public string DataNascimentoDia
		{
			get { return _DataNascimentoDia; }
			set { _DataNascimentoDia = value; }
		}

		string _DataNascimentoMes;
		[TestVariable("c7d0a1af-edd2-4518-8ef5-9ca25b2a954c")]
		public string DataNascimentoMes
		{
			get { return _DataNascimentoMes; }
			set { _DataNascimentoMes = value; }
		}

		string _DataNascimentoAno;
		[TestVariable("f2175984-b3fe-4196-abde-9221d7927c4a")]
		public string DataNascimentoAno
		{
			get { return _DataNascimentoAno; }
			set { _DataNascimentoAno = value; }
		}

		string _DocumentoIdentidade;
		[TestVariable("a08fcb98-09f8-4947-a00b-ee5ce166aee7")]
		public string DocumentoIdentidade
		{
			get { return _DocumentoIdentidade; }
			set { _DocumentoIdentidade = value; }
		}

		string _Email;
		[TestVariable("327e1e31-a2be-4c77-977b-5f18fe8da677")]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		string _CEP;
		[TestVariable("4f08a482-b4f8-4903-ad9e-1502a5cab18b")]
		public string CEP
		{
			get { return _CEP; }
			set { _CEP = value; }
		}

		string _ConfirmarEmail;
		[TestVariable("d133bf62-38ba-4470-8898-719dd913fd1e")]
		public string ConfirmarEmail
		{
			get { return _ConfirmarEmail; }
			set { _ConfirmarEmail = value; }
		}

		string _Sexo;
		[TestVariable("bfa0c0ac-92d0-4623-b2b5-d158a9bffea0")]
		public string Sexo
		{
			get { return _Sexo; }
			set { _Sexo = value; }
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
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				#region parameter
				Nome = Program.getProtonValue("in_Nome");
				Sobrenome = Program.getProtonValue("in_Sobrenome");
				CPF = Program.getProtonValue("in_CPF");
				Sexo = Program.getProtonValue("in_Sexo");
				CEP = Program.getProtonValue("in_CEP");
				DataNascimentoAno= Program.getProtonValue("in_Data_Nascimento_Ano");
				DataNascimentoMes = Program.getProtonValue("in_Data_Nascimento_Mes");
				DataNascimentoDia = Program.getProtonValue("in_Data_Nascimento_Dia");
				ConfirmarEmail = Program.getProtonValue("in_Confirmação_Email");
				Email = Program.getProtonValue("in_Email");
				DocumentoIdentidade = Program.getProtonValue("in_CPF");
				#endregion
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
				Delay.Duration(500, false);
				
				Program.InserirCPF(repo.SmilesOMelhorProgramaDeMilhasS1.Clube_CPF, CPF);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_ContinuarInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar.Click(1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
				Delay.Duration(1000, false);
				
				repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Nome'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_NomeInfo, new RecordItemIndex(7));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Nome.PressKeys(Nome, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sobrenome' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Sobrenome'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_SobrenomeInfo, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Sobrenome.PressKeys(Sobrenome, 1);
				Delay.Milliseconds(90);
				
				Program.SelectGenderFlag("//form[#'_smilesclubnotloggedportlet_WAR_smilesclubportlet_frmPreRecordSmilesClub']/div/div/div[5]/div/",Sexo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoDia' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoDia'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoDiaInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoDia.PressKeys(DataNascimentoDia, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoMes' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoMes'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoMesInfo, new RecordItemIndex(11));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoMes.PressKeys(DataNascimentoMes, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoAno' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoAno'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoAnoInfo, new RecordItemIndex(12));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DataNascimentoAno.PressKeys(DataNascimentoAno, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DocumentoIdentidade' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DocumentoIdentidade'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DocumentoIdentidadeInfo, new RecordItemIndex(13));
				if(DocumentoIdentidade.Equals("ALEATORIO")){
				   	DocumentoIdentidade = Utils.RndNumber(9);
				}
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_DocumentoIdentidade.PressKeys(DocumentoIdentidade, 1);
				Delay.Milliseconds(90);
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Email,Email);
				Delay.Milliseconds(0);
				//Program.
				
				Program.setEmail(repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_ConfirmarEmail,ConfirmarEmail);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CEP' with focus on 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_CEP'.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_CEPInfo, new RecordItemIndex(16));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_CEP.PressKeys(CEP, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_AceitoTermos' at CenterLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_AceitoTermosInfo, new RecordItemIndex(17));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_AceitoTermos.Click(Location.CenterLeft, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(18));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ESCAPE}'.", new RecordItemIndex(19));
				Keyboard.Press("{ESCAPE}");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(20));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Continuar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_ContinuarInfo, new RecordItemIndex(21));
				repo.SmilesOMelhorProgramaDeMilhasS1.PreCadastro_Continuar.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(22));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Wait", "Waiting 40s for item 'SmilesOMelhorProgramaDeMilhasS1.Smiles_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_AguardeInfo, new ActionTimeout(40000), new RecordItemIndex(23));
				repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_AguardeInfo.WaitForNotExists(40000);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(24));
				
				
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
