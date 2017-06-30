/*
 * Created by Ranorex
 * User: caiop
 * Date: 29/06/2017
 * Time: 17:48
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
	/// Description of EditarFavorito.
	/// </summary>
	[TestModule("F0832BF5-307E-4FE0-B94C-F00A60BAF032", ModuleType.UserCode, 1)]
	public class EditarFavorito : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static EditarFavorito instance = new EditarFavorito();
		
		public EditarFavorito()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static EditarFavorito Instance
		{
			get { return instance; }
		}
		
		#region Variables

		string _Nome;

		/// <summary>
		/// Gets or sets the value of variable Nome.
		/// </summary>
		[TestVariable("201c56e4-d6fb-463a-9c9c-0bbce9a26fb0")]
		public string Nome
		{
			get { return _Nome; }
			set { _Nome = value; }
		}

		string _Sobrenome;

		/// <summary>
		/// Gets or sets the value of variable Sobrenome.
		/// </summary>
		[TestVariable("73d70cd7-9dff-439e-9de8-ecbdc51ef404")]
		public string Sobrenome
		{
			get { return _Sobrenome; }
			set { _Sobrenome = value; }
		}

		string _Sexo;

		/// <summary>
		/// Gets or sets the value of variable Sexo.
		/// </summary>
		[TestVariable("85a20a3c-efb5-4f1c-b2e4-ef5b3ac9be6a")]
		public string Sexo
		{
			get { return _Sexo; }
			set { _Sexo = value; }
		}

		string _DiaNascimento;

		/// <summary>
		/// Gets or sets the value of variable DiaNascimento.
		/// </summary>
		[TestVariable("93a766bb-922d-40ff-8ee3-d5eaa39e18a2")]
		public string DiaNascimento
		{
			get { return _DiaNascimento; }
			set { _DiaNascimento = value; }
		}

		string _MesNascimento;

		/// <summary>
		/// Gets or sets the value of variable MesNascimento.
		/// </summary>
		[TestVariable("f4bf5137-9bb5-44e9-b29f-1a6e4e857141")]
		public string MesNascimento
		{
			get { return _MesNascimento; }
			set { _MesNascimento = value; }
		}

		string _AnoNascimento;

		/// <summary>
		/// Gets or sets the value of variable AnoNascimento.
		/// </summary>
		[TestVariable("26f82525-0ff5-4da8-9a3c-550a7035d7f0")]
		public string AnoNascimento
		{
			get { return _AnoNascimento; }
			set { _AnoNascimento = value; }
		}

		string _NumeroDocumento;

		/// <summary>
		/// Gets or sets the value of variable NumeroDocumento.
		/// </summary>
		[TestVariable("921d0ae1-c385-4540-89e1-19934c93d01c")]
		public string NumeroDocumento
		{
			get { return _NumeroDocumento; }
			set { _NumeroDocumento = value; }
		}

		string _Email;

		/// <summary>
		/// Gets or sets the value of variable Email.
		/// </summary>
		[TestVariable("60bd0147-a239-45a3-823f-e8b348139d86")]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		/// <summary>
		/// Gets or sets the value of variable TipoDocumento.
		/// </summary>
		[TestVariable("14c5605f-09aa-4531-b8fd-52adf0920b1e")]
		public string TipoDocumento
		{
			get { return repo.TipoDocumento; }
			set { repo.TipoDocumento = value; }
		}
		
		string _out_Sobrenome_Old = "";
		[TestVariable("964f0337-4d03-41c1-a5a1-f85227cf4a63")]
		public string out_Sobrenome_Old
		{
			get { return _out_Sobrenome_Old; }
			set { _out_Sobrenome_Old = value; }
		}
		
		string _out_Sobrenome_New = "";
		[TestVariable("d9dcb159-e704-4435-b767-541a0d511cc4")]
		public string out_Sobrenome_New
		{
			get { return _out_Sobrenome_New; }
			set { _out_Sobrenome_New = value; }
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
			
			#region Variables
			
			Sexo = Program.getProtonValue("in_Sexo");
			Nome = Program.getProtonValue("in_Nome");
			Sobrenome = Program.Generate(10);
			DiaNascimento = Program.getProtonValue("in_Data_Nascimento_Dia");
			MesNascimento = Program.getProtonValue("in_Data_Nascimento_Mes");
			AnoNascimento = Program.getProtonValue("in_Data_Nascimento_Ano");
			NumeroDocumento = Program.getProtonValue("in_Numero_Documento");
			Email = Program.getProtonValue("in_Email");
			TipoDocumento = Program.getProtonValue("in_Tipo_Documento");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Editar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_EditarInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Editar.Click(1);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[#'_smilesfavoritepassengerportlet_WAR_smilesbookingportlet_FirstName']", Nome);
				Delay.Milliseconds(0);
				
				out_Sobrenome_Old = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Sobrenome, "tagvalue");
				Program.setProtonOutput("out_Sobrenome_Old", out_Sobrenome_Old);
				
				Program.TypeKeys("//input[#'_smilesfavoritepassengerportlet_WAR_smilesbookingportlet_LastName']", Sobrenome);
				Delay.Milliseconds(0);
				
				out_Sobrenome_New = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Sobrenome, "tagvalue");
				Program.setProtonOutput("out_Sobrenome_New", out_Sobrenome_New);
				
				SelectGenderFlag(Sexo);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@name='day']", DiaNascimento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@name='month']", MesNascimento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@name='year']", AnoNascimento);
				Delay.Milliseconds(0);
				
				Program.Invoke_Action_Favorito_TipoDocumento(TipoDocumento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@name='documentNumber']", NumeroDocumento);
				Delay.Milliseconds(0);
				
				Program.TypeKeys("//input[@name='email']", Email);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Salvar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_SalvarInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Salvar.Click(1);
				Delay.Milliseconds(0);

				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
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
