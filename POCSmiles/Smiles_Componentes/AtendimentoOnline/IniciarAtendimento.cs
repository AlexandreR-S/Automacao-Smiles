/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 14:57
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
	/// Description of IniciarAtendimento.
	/// </summary>
	[TestModule("13BDAD4F-4E37-4BB1-AFAC-14E0C16CD810", ModuleType.UserCode, 1)]
	public class IniciarAtendimento : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static IniciarAtendimento instance = new IniciarAtendimento();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public IniciarAtendimento()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Atendimento_IniciarAtendimento' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Atendimento_IniciarAtendimentoInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Atendimento_IniciarAtendimento.Click(1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
			
		}
	}
}
