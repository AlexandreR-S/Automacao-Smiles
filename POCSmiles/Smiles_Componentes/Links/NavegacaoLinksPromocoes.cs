/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 06/06/2017
 * Time: 11:49
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

namespace POCSmiles.Smiles_Componentes.Links
{
	/// <summary>
	/// Description of NavegacaoLinksPromocoes.
	/// </summary>
	[TestModule("F40AF05A-2CA9-4A7F-ABF4-93458FD26CB5", ModuleType.UserCode, 1)]
	public class NavegacaoLinksPromocoes : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static NavegacaoLinksPromocoes instance = new NavegacaoLinksPromocoes();

		string _Links = "COW";
		[TestVariable("904a2c68-e8ba-4b1c-9e87-271f0a5f3c89")]
		public string Links
		{
			get { return _Links; }
			set { _Links = value; }
		}


		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public NavegacaoLinksPromocoes()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _promocao = "";
		[TestVariable("793dbf02-c3af-411f-982e-454360b6363d")]
		public string promocao
		{
			get { return _promocao; }
			set { _promocao = value; }
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
			
			promocao = Program.getProtonValue("in_Promocao");
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				promocao = Program.getProtonValue("in_Promocao");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Promocoes_LinkPromocoes' at 41;8.", repo.SmilesOMelhorProgramaDeMilhasS1.Promocoes_LinkPromocoesInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Promocoes_LinkPromocoes.Click("41;8", 1);
				Delay.Milliseconds(1000);
				
				Program.WaitLoad(repo,20);
								
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Navegacao_ProgramaSmiles' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Navegacao_ProgramaSmilesInfo, new RecordItemIndex(1));
				Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString(), "InnerText", promocao, "1");
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
