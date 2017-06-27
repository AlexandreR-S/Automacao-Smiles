/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 23/06/2017
 * Time: 11:29
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

namespace POCSmiles.Smiles_Componentes.Reserva_De_Voo
{
	/// <summary>
	/// Description of ProximosVoos.
	/// </summary>
	[TestModule("346F556D-2DFB-4D94-9D1C-689A56B17AB8", ModuleType.UserCode, 1)]
	public class ProximosVoos : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ProximosVoos instance = new ProximosVoos();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ProximosVoos()
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoosInfo, new RecordItemIndex(0));
			repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ProximosVoos.Click(1);
			Delay.Milliseconds(490);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_CancelarVoo'.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_CancelarVooInfo, new RecordItemIndex(1));
			Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_CancelarVooInfo);
			Delay.Milliseconds(0);
			
			Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));

		}
	}
}
