/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 06/06/2017
 * Time: 09:37
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

namespace POCSmiles.Smiles_Componentes.EsqueciMeusDados
{
	/// <summary>
	/// Description of EsqueciMInhaSenha.
	/// </summary>
	[TestModule("B93A501F-96B5-47D8-8D26-217248FB6CBC", ModuleType.UserCode, 1)]
	public class EsqueciMinhaSenha : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static EsqueciMinhaSenha instance = new EsqueciMinhaSenha();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public EsqueciMinhaSenha()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		#region Variables

		string _NumSmiles;

		/// <summary>
		/// Gets or sets the value of variable NumSmiles.
		/// </summary>
		[TestVariable("26def317-6606-4b67-9b37-30a346151bc2")]
		public string NumSmiles
		{
			get { return _NumSmiles; }
			set { _NumSmiles = value; }
		}

		string _CPF ;

		/// <summary>
		/// Gets or sets the value of variable CPF.
		/// </summary>
		[TestVariable("b3724f0b-8242-4a57-bc54-36e7cf0fb3ef")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
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
				
				CPF=Program.getProtonValue("in_CPF");
				NumSmiles = Program.getProtonValue("in_Numero_Smiles");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone'.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone.Click(1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.YuiPatchedV3110114701446020751849' at 87;7.", repo.SmilesOMelhorProgramaDeMilhasS1.YuiPatchedV3110114701446020751849Info, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.YuiPatchedV3110114701446020751849.Click("87;7", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumSmiles' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumSmilesInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumSmiles.PressKeys(NumSmiles, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CPF' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_CPF'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_CPFInfo, new RecordItemIndex(4));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_CPF.PressKeys(CPF, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarInfo, new RecordItemIndex(5));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar.Click(1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(6));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
