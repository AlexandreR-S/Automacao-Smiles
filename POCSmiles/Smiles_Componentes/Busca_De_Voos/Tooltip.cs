/*
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
	/// Description of Tooltip.
	/// </summary>
	[TestModule("F1EC8E2C-2EE5-4620-A37E-420FB1B502C5", ModuleType.UserCode, 1)]
	public class Tooltip : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static Tooltip instance = new Tooltip();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Tooltip()
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
				
				Program.SelectFlyPayment("Tooltip");
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
