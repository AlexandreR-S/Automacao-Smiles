/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 11:08
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

namespace POCSmiles.Smiles_Componentes.ImprimirCartao
{
	/// <summary>
	/// Description of ImprimirCartaoSmiles.
	/// </summary>
	[TestModule("5B96949B-A9AD-4572-8C19-802170265B6C", ModuleType.UserCode, 1)]
	public class ImprimirCartaoSmiles : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ImprimirCartaoSmiles instance = new ImprimirCartaoSmiles();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ImprimirCartaoSmiles()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartao' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo);
				repo.SmilesOMelhorProgramaDeMilhasS1.ImprimirCartao.EnsureVisible();
				//Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo.AbsolutePath.ToResolvedString());
				Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.ImprimirCartaoInfo.AbsolutePath.ToResolvedString());
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));	
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
