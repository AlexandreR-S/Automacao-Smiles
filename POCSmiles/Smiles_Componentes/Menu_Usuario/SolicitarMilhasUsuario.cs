/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 09/06/2017
 * Time: 15:37
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
	/// Description of SolicitarMilhas.
	/// </summary>
	[TestModule("D0631193-0D91-4D53-BA26-3C451B85CDF8", ModuleType.UserCode, 1)]
	public class SolicitarMilhasUsuario : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static SolicitarMilhasUsuario instance = new SolicitarMilhasUsuario();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SolicitarMilhasUsuario()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_SolicitarMilhas' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_SolicitarMilhasInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_SolicitarMilhas.Click(1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_DataVoo'.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_DataVooInfo, new RecordItemIndex(3));
				//old
				//Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_DataVooInfo);
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhasDeVooInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
