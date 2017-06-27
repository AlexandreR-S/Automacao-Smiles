/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 09/06/2017
 * Time: 10:04
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

namespace POCSmiles.Smiles_Componentes.ShoppingSmiles
{
	/// <summary>
	/// Description of MenuShoppingSmiles.
	/// </summary>
	[TestModule("C6FDBB5E-7CA3-4ECC-967C-A1D37968BE09", ModuleType.UserCode, 1)]
	public class MenuShoppingSmiles : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static MenuShoppingSmiles instance = new MenuShoppingSmiles();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public MenuShoppingSmiles()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ShoppingSmiles_MenuShoppingSmiles' at 32;10.", repo.SmilesOMelhorProgramaDeMilhasS1.ShoppingSmiles_MenuShoppingSmilesInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.ShoppingSmiles_MenuShoppingSmiles.Click("32;10", 1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
