/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 13:46
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
    /// Description of RP_SolicitarMilhas.
    /// </summary>
    [TestModule("8B1076A8-A1C0-4D0D-9CB7-DBFE6EBA30F6", ModuleType.UserCode, 1)]
    public class RP_SolicitarMilhas : ITestModule
    {
    	
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_SolicitarMilhas instance = new RP_SolicitarMilhas();
		
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_SolicitarMilhas()
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
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_ButtonTagVerMeuExtrato' at 86;19.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_ButtonTagVerMeuExtratoInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_ButtonTagVerMeuExtrato.Click("86;19", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctions'.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctionsInfo, new RecordItemIndex(4));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_BtnTransctionsInfo);
				Delay.Milliseconds(100);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SendMessageSmiles' at 85;22.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SendMessageSmilesInfo, new RecordItemIndex(5));
				repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SendMessageSmiles.Click("85;22", 1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Crédito de Voo') on item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_CreditoDeVooManual'.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_CreditoDeVooManualInfo, new RecordItemIndex(6));
				Validate.Attribute(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_CreditoDeVooManualInfo, "InnerText", new Regex(Regex.Escape("Crédito de Voo")));
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
			}
			
			iComponentStatus = Program.endComponent();
        }
    }
}
