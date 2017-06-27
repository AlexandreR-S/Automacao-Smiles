/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 14/06/2017
 * Time: 14:56
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
	/// Description of AtendimentoOnline.
	/// </summary>
	[TestModule("062D025A-F81A-4309-A12F-32DC5D912708", ModuleType.UserCode, 1)]
	public class AtendimentoOnline : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AtendimentoOnline instance = new AtendimentoOnline();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AtendimentoOnline()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnline' at Center.", repo.AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnlineInfo, new RecordItemIndex(0));
				//repo.AtendimentoOnlineHomologacao.Atendimento_AtendimentoOnline.Click(1);
				repo.SmilesOMelhorProgramaDeMilhasS1.Atendimento_AtendimentoOnline.Click(1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
