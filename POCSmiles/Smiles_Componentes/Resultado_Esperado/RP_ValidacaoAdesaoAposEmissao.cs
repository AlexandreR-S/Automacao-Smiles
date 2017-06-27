/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 13:14
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
    /// Description of RP_ValidacaoAdesaoAposEmissao.
    /// </summary>
    [TestModule("B2764627-5655-43A6-BCBC-4985EB482D98", ModuleType.UserCode, 1)]
    public class RP_ValidacaoAdesaoAposEmissao : ITestModule
    {
    	
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_ValidacaoAdesaoAposEmissao instance = new RP_ValidacaoAdesaoAposEmissao();
		
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_ValidacaoAdesaoAposEmissao()
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesao'.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesaoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_MensagemAdesaoInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_OK' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_OKInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_OK.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
				Delay.Duration(1000, false);
				
				WaitPageLoad();
				Delay.Milliseconds(0);
				
			}
			
			iComponentStatus = Program.endComponent();
        }
        
		private void WaitPageLoad()
		{
			try {
				Report.Info("Waiting page load");
				Smiles_UserCode.WaitLoad(repo,30);
				Report.Info("Page loaded");
			} catch (Exception) {
				Report.Error("SelecionarVoo - Error waiting page load");
				throw new System.Exception("SelecionarVoo.WaitPageLoad");
			}
		}
    }
}
