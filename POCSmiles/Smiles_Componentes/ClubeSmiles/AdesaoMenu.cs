/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 10:38
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
	/// Description of AdesaoMenu.
	/// </summary>
	[TestModule("FE76B76E-4B09-4788-BB16-35F50518A0F9", ModuleType.UserCode, 1)]
	public class AdesaoMenu : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AdesaoMenu instance = new AdesaoMenu();
		
		public AdesaoMenu()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static AdesaoMenu Instance
		{
			get { return instance; }
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
				Delay.Duration(500, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_ContinuarInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar.Click(1);
				Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_EntreJa' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_EntreJaInfo, new RecordItemIndex(3));
				//repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_EntreJa.Click(1);
				//Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(4));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}