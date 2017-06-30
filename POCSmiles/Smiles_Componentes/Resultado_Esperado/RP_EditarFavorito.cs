/*
 * Created by Ranorex
 * User: caiop
 * Date: 30/06/2017
 * Time: 09:41
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
	[TestModule("758891D4-9F0D-4ECF-8A35-01CB3C117031", ModuleType.UserCode, 1)]
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

#region Variables

		string _out_Sobrenome_Old = "";
		[TestVariable("964f0337-4d03-41c1-a5a1-f85227cf4a63")]
		public string out_Sobrenome_Old
		{
			get { return _out_Sobrenome_Old; }
			set { _out_Sobrenome_Old = value; }
		}
		
		string _out_Sobrenome_New = "";
		[TestVariable("d9dcb159-e704-4435-b767-541a0d511cc4")]
		public string out_Sobrenome_New
		{
			get { return _out_Sobrenome_New; }
			set { _out_Sobrenome_New = value; }
		}

#endregion

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
			
			out_Sobrenome_New = Program.getProtonValue("in_Sobrenome_New");
			out_Sobrenome_Old = Program.getProtonValue("in_Sobrenome_Old");
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				if(!out_Sobrenome_Old.Equals(out_Sobrenome_New)){
					Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				}
				else{
					Report.Screenshot(ReportLevel.Failure, "User", "", null, false, new RecordItemIndex(1));
				}				
			}
			
			iComponentStatus = Program.endComponent();
		}
	}
}
