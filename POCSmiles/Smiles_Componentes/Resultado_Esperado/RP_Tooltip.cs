﻿/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 09/06/2017
 * Time: 16:54
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

namespace POCSmiles.Smiles_Componentes.Busca_De_Voos
{
	/// <summary>
	/// Description of RP_Tooltip.
	/// </summary>
	[TestModule("8F7013F7-8B7D-44B1-BD1F-7400C00D843B", ModuleType.UserCode, 1)]
	public class RP_Tooltip : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_Tooltip instance = new RP_Tooltip();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_Tooltip()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_Tooltip'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_TooltipInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_TooltipInfo);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Invoke Action", "Invoking EnsureVisible() on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_Tooltip'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_TooltipInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_Tooltip.EnsureVisible();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Focus() on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_Tooltip'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_TooltipInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_Tooltip.Focus();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(3));
			}
			iComponentStatus = Program.endComponent();

		}
	}
}
