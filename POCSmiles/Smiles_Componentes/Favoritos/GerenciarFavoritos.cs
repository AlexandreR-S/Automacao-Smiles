/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:31
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

namespace POCSmiles.Smiles_Componentes.Favoritos
{
	/// <summary>
	/// Description of GerenciarFavoritos.
	/// </summary>
	[TestModule("9195520B-EBEC-4F2B-8802-1BD624037D68", ModuleType.UserCode, 1)]
	public class GerenciarFavoritos : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static GerenciarFavoritos instance = new GerenciarFavoritos();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public GerenciarFavoritos()
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
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MinhaConta_GerenciarFavoritos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_GerenciarFavoritosInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_GerenciarFavoritos.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiro'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiroInfo, new RecordItemIndex(1));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Favoritos_AdicionarNovoPassageiroInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
