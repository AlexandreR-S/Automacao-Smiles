/*
 * Created by Ranorex
 * User: caiop
 * Date: 28/06/2017
 * Time: 11:36
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
	/// Description of RP_EditarFavorito.
	/// </summary>
	[TestModule("57730CDC-E01E-4BFF-84DB-3D6FF7DCE9E1", ModuleType.UserCode, 1)]
	public class RP_EditarFavorito : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_EditarFavorito instance = new RP_EditarFavorito();
		
		public RP_EditarFavorito()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		public static RP_EditarFavorito Instance
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortito'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortitoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortitoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}