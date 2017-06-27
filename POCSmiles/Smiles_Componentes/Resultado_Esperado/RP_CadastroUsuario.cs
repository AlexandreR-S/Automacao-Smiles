/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
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
	/// Description of RP_CadastroUsuario.
	/// </summary>
	[TestModule("6CB17ABA-2D73-4611-8387-03DA9B5D4D53", ModuleType.UserCode, 1)]
	public class RP_CadastroUsuario : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;
		
		static RP_CadastroUsuario instance = new RP_CadastroUsuario();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public RP_CadastroUsuario()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _out_Numero_Smiles = "";
		[TestVariable("28aaab3c-0e45-48a9-91d9-dbe6e881d01d")]
		public string out_Numero_Smiles
		{
			get { return _out_Numero_Smiles; }
			set { _out_Numero_Smiles = value; }
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
			
			out_Numero_Smiles = Program.getProtonValue("out_Numero_Smiles");
			
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){;

				Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_ConfirmacaoCadastro'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_ConfirmacaoCadastroInfo, new RecordItemIndex(0));
				Validate.Attribute(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_ConfirmacaoCadastroInfo, "Visible", "True");
				Delay.Milliseconds(100);
				
				out_Numero_Smiles = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_ConfirmacaoCadastro, "innertext");
				Program.setProtonOutput("out_Numero_Smiles", out_Numero_Smiles);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
