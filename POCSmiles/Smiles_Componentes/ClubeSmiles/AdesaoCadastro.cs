/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
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

namespace POCSmiles.Smiles_Componentes.ClubeSmiles
{
	/// <summary>
	/// Description of AdesaoCadastro.
	/// </summary>
	[TestModule("20535A49-7264-4B91-B40B-4B0E8D0C7487", ModuleType.UserCode, 1)]
	public class AdesaoCadastro : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AdesaoCadastro instance = new AdesaoCadastro();
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AdesaoCadastro()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _CPF = "";
		[TestVariable("2807fb58-167e-484b-be62-ba73b9b7580e")]
		public string CPF
		{
			get { return _CPF; }
			set { _CPF = value; }
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
			
			#region Variables
			
			CPF = Program.getProtonValue("in_CPF");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Program.InvokeClick();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste'.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(2));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEsteInfo, new RecordItemIndex(5));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_QueroEste.Click();
				Delay.Milliseconds(200);
				
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_CPF.PressKeys(Program.getProtonValue("in_CPF"));
				Delay.Milliseconds(0);
				
				//Program.InserirCPF();
				//Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Clube_ContinuarInfo, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.Clube_Continuar.Click(1);
				Delay.Milliseconds(490);
				
				Program.WaitSmilesLoad();
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
				
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
