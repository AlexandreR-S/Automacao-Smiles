/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 20/06/2017
 * Time: 17:26
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

namespace POCSmiles.Smiles_Componentes.ClubeSmiles
{
	/// <summary>
	/// Description of AlterarPlano.
	/// </summary>
	[TestModule("B7132003-1AF7-4A56-9E49-62F7DC72F33B", ModuleType.UserCode, 1)]
	public class AlterarPlano : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AlterarPlano instance = new AlterarPlano();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AlterarPlano()
		{
			// Do not delete - a parameterless constructor is required!
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

				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano' at 98;21.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlanoInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_ConhecerOutrosPlanos.Click("98;21", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				//            Program.WaitSystemLoad("45");
				//            Delay.Milliseconds(0);
				
				//            Program.SelecionarPlano();
				//            Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
				Delay.Duration(1000, false);
				
				Program.WaitSystemLoad("45");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_ChkAgreement' at CenterLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_ChkAgreementInfo, new RecordItemIndex(6));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ChkAgreement.Click(Location.CenterLeft, 1);
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_ChkAgreement.Click(Location.CenterLeft, 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmiles' at 134;11.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmilesInfo, new RecordItemIndex(7));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmiles.Click("134;11", 1);
				repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_NovoPlano.Click(Location.Center , 1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(8));

			}
			iComponentStatus = Program.endComponent();

		}
	}
}
