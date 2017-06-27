/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 23/06/2017
 * Time: 11:27
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
	/// Description of MeusVoos.
	/// </summary>
	[TestModule("C789922D-0AEC-47BA-A258-A31CA2A02A38", ModuleType.UserCode, 1)]
	public class MeusVoos : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static MeusVoos instance = new MeusVoos();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public MeusVoos()
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuarioInfo, new RecordItemIndex(0));
			repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario.Click(1);
			Delay.Milliseconds(490);
			
			Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
			Delay.Duration(1000, false);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MeusVoos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MeusVoosInfo, new RecordItemIndex(2));
			repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MeusVoos.Click(1);
			Delay.Milliseconds(490);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoos'.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoosInfo, new RecordItemIndex(3));
			Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoosInfo);
			Delay.Milliseconds(0);
			
			Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));

		}
	}
}
