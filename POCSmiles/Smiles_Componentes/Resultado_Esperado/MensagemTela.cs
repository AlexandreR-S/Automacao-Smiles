/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 08/06/2017
 * Time: 12:59
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
	/// Description of MensagemTela.
	/// </summary>
	[TestModule("5DC1426F-72CD-43FB-896D-737853F7E29B", ModuleType.UserCode, 1)]
	public class MensagemTela : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static MensagemTela instance = new MensagemTela();
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public MensagemTela()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _MensagemEsperada = "";
		[TestVariable("4917eb15-74ed-4620-a561-826103e7e3b6")]
		public string MensagemEsperada
		{
			get { return _MensagemEsperada; }
			set { _MensagemEsperada = value; }
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
			
			#region parameter
			MensagemEsperada = Program.getProtonValue("in_Mensagem_Esperada");
			#endregion
			if(Convert.ToInt32(iComponentStatus) == 2){
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Program.WaitSmilesLoad();
				Program.ExpectedResult(MensagemEsperada, "true");
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
