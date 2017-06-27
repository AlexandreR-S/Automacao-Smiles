/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 10:43
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

namespace POCSmiles.Smiles_Componentes.Menu_Usuario
{
	/// <summary>
	/// Description of MinhaConta.
	/// </summary>
	[TestModule("AE843301-AE9A-492A-B235-CD4EE0DAFB2C", ModuleType.UserCode, 1)]
	public class MinhaConta : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static MinhaConta instance = new MinhaConta();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public MinhaConta()
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
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MilhasInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaConta' at 87;14.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaContaInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaConta.Click("87;14", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SmilesOMelhorProgramaDeMilhasS1.Smiles_logo' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_logoInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_logo.MoveTo();
				Delay.Milliseconds(200);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Progressbar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ProgressbarInfo, new RecordItemIndex(4));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ProgressbarInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
