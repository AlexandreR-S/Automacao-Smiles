/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 21/06/2017
 * Time: 13:03
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

namespace POCSmiles.Smiles_Componentes.ComprarMilhas
{
	/// <summary>
	/// Description of ComprarMilhasNEW.
	/// </summary>
	[TestModule("5BF10F80-5D9E-4869-AF71-6BBBA507A9E8", ModuleType.UserCode, 1)]
	public class ComprarMilhasNEW : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ComprarMilhasNEW instance = new ComprarMilhasNEW();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ComprarMilhasNEW()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _Voucher = "";
		[TestVariable("d28a9226-2598-4751-a3df-cb2a6f8cfd00")]
		public string Voucher
		{
			get { return _Voucher; }
			set { _Voucher = value; }
		}

		string _Milhas = "";
		[TestVariable("0551c90e-c1c3-4d1a-b4b5-eaa41cfc4c10")]
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
				
				Milhas = Program.getProtonValue("in_Milhas");
				Voucher = Program.getProtonValue("in_Voucher");

				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Program.SelectVoucher(Voucher);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Program.WaitSmilesLoad();
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}'.", new RecordItemIndex(3));
				Keyboard.Press("{END}");
				Delay.Milliseconds(0);
				
				//Program.TypeKeys("//button[@id~'btnApplied'+$Voucher]",Milhas);
				Program.TypeKeys("//input[@id~'amountWithoutBonus']", Milhas);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{NEXT}'.", new RecordItemIndex(5));
				Keyboard.Press("{TAB}{NEXT}");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Comprar' at UpperCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ComprarInfo, new RecordItemIndex(6));
				repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Comprar.Click(Location.UpperCenter, 1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo, new RecordItemIndex(7));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(8));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
