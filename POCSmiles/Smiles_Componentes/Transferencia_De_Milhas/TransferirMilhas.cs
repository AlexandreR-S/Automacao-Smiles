/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 28/06/2017
 * Time: 16:14
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

namespace POCSmiles.Smiles_Componentes.Transferencia_De_Milhas
{
	/// <summary>
	/// Description of TransferirMilhas.
	/// </summary>
	[TestModule("84969D14-2166-4F44-8877-6F3422934E2C", ModuleType.UserCode, 1)]
	public class TransferirMilhas : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static TransferirMilhas instance = new TransferirMilhas();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public TransferirMilhas()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _NumSmiles = "";
		[TestVariable("94f1e063-8be3-461c-b698-5b2eaacabfbf")]
		public string NumSmiles
		{
			get { return _NumSmiles; }
			set { _NumSmiles = value; }
		}

		string _CPF = "";
		[TestVariable("fdcd4722-89c7-479b-9d9d-04295c71260b")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
		}

		string _Milhas = "";
		[TestVariable("0c896019-9b68-40af-8cec-5451dcb45586")]
		public string Milhas
		{
			get { return _Milhas; }
			set { _Milhas = value; }
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
				
				Milhas = Program.getProtonValue("in_Milhas");
				CPF = Program.getProtonValue("in_CPF");
				NumSmiles = Program.getProtonValue("in_Numero_Smiles");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumSmiles' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles.PressKeys(NumSmiles, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CPF' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPF'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPFInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPF.PressKeys(CPF, 1);
				Delay.Milliseconds(80);
				
				//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Consultar' at 67;11.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_ConsultarInfo, new RecordItemIndex(3));
				//repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Consultar.Click("67;11", 1);
				//Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(4));
				Keyboard.Press("{TAB}");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(6));
				repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Milhas' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_MilhasInfo, new RecordItemIndex(7));
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas.Click();
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas.PressKeys(Milhas);
				Delay.Milliseconds(90);
				
				//Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
				//Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{NEXT}'.", new RecordItemIndex(9));
				Keyboard.Press("{TAB}{NEXT}");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Continuar' at UpperLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_ContinuarInfo, new RecordItemIndex(10));
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Continuar.Click(Location.UpperLeft, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
				Delay.Duration(1000, false);
				
				Program.WaitLoad();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(13));
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
