/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 15:53
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

namespace POCSmiles.Smiles_Componentes.Resultado_Esperado
{
	/// <summary>
	/// Description of RP_SelecionarAssentos.
	/// </summary>
	[TestModule("53F72798-F34F-49B6-B54D-D396C3915DA6", ModuleType.UserCode, 1)]
	public class RP_SelecionarAssentos : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_SelecionarAssentos instance = new RP_SelecionarAssentos();
		
		public RP_SelecionarAssentos()
		{
			// Do not delete - a parameterless constructor is required!
		}

		public static RP_SelecionarAssentos Instance
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_ValidacaoPositiva'.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_ValidacaoPositivaInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_ValidacaoPositivaInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}