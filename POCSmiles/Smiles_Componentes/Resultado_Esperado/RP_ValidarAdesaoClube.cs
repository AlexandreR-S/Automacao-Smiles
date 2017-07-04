/*
 * Created by Ranorex
 * User: caiop
 * Date: 03/07/2017
 * Time: 10:44
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
	/// Description of RP_ValidarAdesaoClube.
	/// </summary>
	[TestModule("CA61AF99-6245-4E87-9C89-790EF337DF82", ModuleType.UserCode, 1)]
	public class RP_ValidarAdesaoClube : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ValidarAdesaoClube instance = new RP_ValidarAdesaoClube();
		
		public RP_ValidarAdesaoClube()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static RP_ValidarAdesaoClube Instance
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
				
				Program.WaitLoad();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuarioInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaConta' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaContaInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MinhaConta.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_Configuracoes'.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfiguracoesInfo, new RecordItemIndex(4));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfiguracoesInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}