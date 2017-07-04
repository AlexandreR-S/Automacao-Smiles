/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 16:51
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
	/// Description of VoosReservados.
	/// </summary>
	[TestModule("70EB6631-C0DE-42FA-9455-8A0083C9BBC2", ModuleType.UserCode, 1)]
	public class VoosReservados : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static VoosReservados instance = new VoosReservados();
		
		public VoosReservados()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static VoosReservados Instance
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservados' at UpperCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservadosInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservados.Click(Location.UpperCenter, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgora'.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgoraInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgoraInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}