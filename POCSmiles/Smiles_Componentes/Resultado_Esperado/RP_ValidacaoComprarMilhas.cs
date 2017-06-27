/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 21/06/2017
 * Time: 13:17
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
	/// Description of RP_Validaçã.
	/// </summary>
	[TestModule("6CE0868C-C3A0-4A55-B30B-4D4EEEDB9888", ModuleType.UserCode, 1)]
	public class RP_ValidacaoComprarMilhas : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ValidacaoComprarMilhas instance = new RP_ValidacaoComprarMilhas();
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_ValidacaoComprarMilhas()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _CPFSmilesID = "";
		[TestVariable("0d3fe7bb-6b1f-4dc1-8fc6-b13e1616baa3")]
		public string CPFSmilesID
		{
			get { return _CPFSmilesID; }
			set { _CPFSmilesID = value; }
		}

		string _URL = "";
		[TestVariable("674c49a1-5760-41f2-ab41-2265fe8b8a9f")]
		public string URL
		{
			get { return _URL; }
			set { _URL = value; }
		}

		string _Milhas = "";
		[TestVariable("03b26554-fd6b-4304-b97f-7a29abf52df7")]
		public string Milhas
		{
			get { return _Milhas; }
			set { _Milhas = value; }
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

				URL = Program.getProtonValue("in_URL");
				CPFSmilesID = Program.getProtonValue("in_Numero_Smiles");
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo);
				Delay.Milliseconds(100);
				
				//Program.AtualizarMilhasBD(CPFSmilesID, URL, Milhas);
				Program.AtualizarMilhasBD(CPFSmilesID, URL);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
