/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 22/06/2017
 * Time: 13:49
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

namespace POCSmiles.Smiles_Componentes.ReativarMilhas
{
	/// <summary>
	/// Description of ReativarMilhas.
	/// </summary>
	[TestModule("BD1667F4-C89A-4A64-839C-D75E96AF80B1", ModuleType.UserCode, 1)]
	public class ReativarMilhas : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ReativarMilhas instance = new ReativarMilhas();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ReativarMilhas()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Milhas = "";
		[TestVariable("14dd8cf3-0d26-4992-81b7-907fd2d0c590")]
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
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhas' at 88;19.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhasInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhas.Click("88;19", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_MilhasInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_MilhasInfo);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Milhas' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_MilhasInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas.PressKeys(Milhas, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoConfiramarReativarMilhas' at UpperCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoConfiramarReativarMilhasInfo, new RecordItemIndex(4));
				repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoConfiramarReativarMilhas.Click(Location.UpperCenter, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(5));
				repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
				
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
