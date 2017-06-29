/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 28/06/2017
 * Time: 16:09
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
	/// Description of TransferirMilhasUsuario.
	/// </summary>
	[TestModule("5C367F02-CF99-476E-A3CD-0DF7D7882B34", ModuleType.UserCode, 1)]
	public class TransferirMilhasUsuario : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static TransferirMilhasUsuario instance = new TransferirMilhasUsuario();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public TransferirMilhasUsuario()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MilhasInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_TransferirMilhas' at 87;14.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_TransferirMilhasInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_TransferirMilhas.Click("87;14", 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPF'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPFInfo, new RecordItemIndex(3));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPFInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
				
			}
			iComponentStatus = Program.endComponent();
			
		}
	}
}
