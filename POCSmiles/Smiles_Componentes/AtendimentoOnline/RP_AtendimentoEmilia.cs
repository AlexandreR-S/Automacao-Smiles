/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 15/06/2017
 * Time: 16:46
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

namespace POCSmiles.Smiles_Componentes.AtendimentoOnline
{
	/// <summary>
	/// Description of RP_AtendimentoEmilia.
	/// </summary>
	[TestModule("E0DF7C96-0DB4-4CAE-928C-9A000602E211", ModuleType.UserCode, 1)]
	public class RP_AtendimentoEmilia : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_AtendimentoEmilia instance = new RP_AtendimentoEmilia();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_AtendimentoEmilia()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Emilia.OlaEmilia'.", repo.Emilia.OlaEmiliaInfo, new RecordItemIndex(0));
				Validate.Exists(repo.EmiliaInbenta.EmiliaInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				
				Program.CloseApplicationEmilia();
				Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press.", new RecordItemIndex(3));
				//Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, 62, Keyboard.DefaultKeyPressTime, 1, true);
				//Delay.Milliseconds(0);
				
				Program.CloseApplicationEmilia();
				Delay.Milliseconds(0);
				
				Program.CloseApplicationEmilia();
				Delay.Milliseconds(0);
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
