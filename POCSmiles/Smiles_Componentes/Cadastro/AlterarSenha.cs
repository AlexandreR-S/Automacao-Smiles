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
	/// Description of AlterarSenha.
	/// </summary>
	[TestModule("B0D9D677-5CCD-471A-A0ED-9238575A3847", ModuleType.UserCode, 1)]
	public class AlterarSenha : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AlterarSenha instance = new AlterarSenha();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AlterarSenha()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Senha = "";
		[TestVariable("c06bdd32-e281-48a7-84ba-9f97664277ae")]
		public string Senha
		{
			get { return _Senha; }
			set { _Senha = value; }
		}

		string _NovaSenha = "";
		[TestVariable("6478bac9-d8d2-403c-b453-937f550a4539")]
		public string NovaSenha
		{
			get { return _NovaSenha; }
			set { _NovaSenha = value; }
		}

		string _ConfirmarSenha = "";
		[TestVariable("f3d92f9b-128e-414a-a831-cc3b12519124")]
		public string ConfirmarSenha
		{
			get { return _ConfirmarSenha; }
			set { _ConfirmarSenha = value; }
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
			
			Senha = Program.getProtonValue("in_Senha_Atual");
			NovaSenha = Program.getProtonValue("in_Nova_Senha");
			ConfirmarSenha = Program.getProtonValue("in_Confirmar_Senha");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MyAccountChangePassword' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MyAccountChangePasswordInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MyAccountChangePassword.Click(1);
				Delay.Milliseconds(490);
				
				//senha atual
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Senha' with focus on 'SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SenhaAtual'.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SenhaAtualInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SenhaAtual.PressKeys(Senha, 1);
				Delay.Milliseconds(90);
				
				//nova senha
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2 down}' with focus on 'SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmileslo'.", repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmilesloInfo, new RecordItemIndex(16));
				repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmileslo.PressKeys(NovaSenha, 1);
				Delay.Milliseconds(90);
				
				//confirma nova senha
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2 down}' with focus on 'SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmileslo1'.", repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmileslo1Info, new RecordItemIndex(25));
				repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.InputTagSmilesloginportletWARSmileslo1.PressKeys(ConfirmarSenha, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AlterarDados_Enviar' at 53;23.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_EnviarInfo, new RecordItemIndex(4));
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_Enviar.Click("53;23", 1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}

