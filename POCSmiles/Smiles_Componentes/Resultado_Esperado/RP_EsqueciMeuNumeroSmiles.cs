/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 01/06/2017
 * Time: 16:17
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
using Ranorex.Core.Repository;

namespace POCSmiles.Smiles_Componentes.Resultado_Esperado
{
	#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The RP_EsqueciMeuNumeroSmiles recording.
	/// </summary>
	[TestModule("192a468c-7bee-42cd-a754-ef80dadd27db", ModuleType.UserCode, 1)]
	public partial class RP_EsqueciMeuNumeroSmiles : ITestModule
	{
		/// <summary>
		/// Holds an instance of the POCSmiles.SmilesRepository repository.
		/// </summary>
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_EsqueciMeuNumeroSmiles instance = new RP_EsqueciMeuNumeroSmiles();
		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static RP_EsqueciMeuNumeroSmiles Instance
		{
			get { return instance; }
		}
		
		#region parameters

		string _out_num_smiles = "";
		[TestVariable("9bcf7b19-bb06-40d7-aba9-be3100d16cc8")]
		public string out_num_smiles
		{
			get { return _out_num_smiles; }
			set { _out_num_smiles = value; }
		}

		#endregion
		
		public static void Start()
		{
			TestModuleRunner.Run(Instance);
		}
		
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
		void ITestModule.Run()
		{
			
			
			var iComponentStatus = Program.startComponent();
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 400;
				Delay.SpeedFactor = 1.00;

				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SeuNumSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.SeuNumSmilesInfo , new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SeuNumSmiles);
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Output", "Output of SmilesID value" + _out_num_smiles + "'.", repo.SmilesOMelhorProgramaDeMilhasS1.SeuNumSmilesInfo, new RecordItemIndex(1));
				out_num_smiles = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.SeuNumSmiles, "innertext");
				Program.setProtonOutput("out_Numero_Smiles", out_num_smiles);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Close PopUp", "Closing windows 'repo.SmilesOMelhorProgramaDeMilhasS1.FecharRecMeuNumSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.FecharMsgInfo , new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.FecharMsg.Click();
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
		}

	}
}
