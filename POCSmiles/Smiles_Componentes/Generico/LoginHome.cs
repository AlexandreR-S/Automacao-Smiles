/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 06/06/2017
 * Time: 09:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Reporting;

namespace POCSmiles.Smiles_Componentes.Generico
{
	/// <summary>
	/// Description of LoginHome.
	/// </summary>
	[TestModule("090B16BB-891D-4ABB-81D1-98B7D7BB1AAB", ModuleType.UserCode, 1)]
	public class LoginHome : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static LoginHome instance = new LoginHome();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public LoginHome()
		{
			// Do not delete - a parameterless constructor is required!
		}

		#region Variables

		string _Numero_Smiles = "";
		[TestVariable("c18afcf8-7624-4cef-adb1-b87ace5409f8")]
		public string Numero_Smiles
		{
			get { return _Numero_Smiles; }
			set { _Numero_Smiles = value; }
		}
		
		string _CPF = "242049054";

		/// <summary>
		/// Gets or sets the value of variable CPFSmilesID.
		/// </summary>
		[TestVariable("097ea65f-8b47-4583-8163-f04976c07a06")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
		}

		string _Senha = "1010";

		/// <summary>
		/// Gets or sets the value of variable Senha.
		/// </summary>
		[TestVariable("be0e6fea-cb89-445f-a69c-b31c49a9fc8b")]
		public string Senha
		{
			get { return _Senha; }
			set { _Senha = value; }
		}
		string CPFNumeroSmiles;

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
				
				CPF = Program.getProtonValue("in_CPF");
				Numero_Smiles =	Program.getProtonValue("in_Numero_Smiles");
				Senha = Program.getProtonValue("in_Senha");
				
				if(CPF != null && CPF != ""){
					CPFNumeroSmiles = CPF;
				}else if(Numero_Smiles != null  && Numero_Smiles != ""){
					CPFNumeroSmiles = Numero_Smiles;
				}else{
					Report.Error("Parameter","None of the two parameters used to login were found");
				}
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Program.WaitSystemLoad("45");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(6));
				repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone.Click(Location.LowerCenter, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CPFSmilesID' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Login_CPFNumeroSmiles2'.", repo.SmilesOMelhorProgramaDeMilhasS1.Login_CPFNumeroSmiles2Info, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.Login_CPFNumeroSmiles2.PressKeys(CPFNumeroSmiles, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Senha' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Login_Senha2'.", repo.SmilesOMelhorProgramaDeMilhasS1.Login_Senha2Info, new RecordItemIndex(9));
				repo.SmilesOMelhorProgramaDeMilhasS1.Login_Senha2.PressKeys(Senha, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Login_Entrar2' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Login_Entrar2Info, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.Login_Entrar2.Click(1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_ExpandirOpcoesUsuario'.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_ExpandirOpcoesUsuarioInfo, new RecordItemIndex(11));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_ExpandirOpcoesUsuarioInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(15));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}