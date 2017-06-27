/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 13:44
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
    /// Description of RP_PainelMinhaConta.
    /// </summary>
    [TestModule("C17D9B97-FAE7-44F9-A964-452E711349F7", ModuleType.UserCode, 1)]
    public class RP_PainelMinhaConta : ITestModule
    {
    	
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_PainelMinhaConta instance = new RP_PainelMinhaConta();
		
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_PainelMinhaConta()
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
			
			if(Convert.ToInt32(iComponentStatus) == 2){;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_MilhasInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Milhas.MoveTo(1);
				Delay.Milliseconds(490);
				
				//ValidacaoMinhaConta();
				//Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Progressbar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ProgressbarInfo, new RecordItemIndex(2));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ProgressbarInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(3));
			}
        }
        
    }
}
