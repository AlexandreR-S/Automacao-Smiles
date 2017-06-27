/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 13:18
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
    /// Description of RP_CriarEvento.
    /// </summary>
    [TestModule("13938E18-387E-4E86-937A-350895B5951E", ModuleType.UserCode, 1)]
    public class RP_CriarEvento : ITestModule
    {
    	public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_CriarEvento instance = new RP_CriarEvento();
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_CriarEvento()
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

			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_Evento_Criado'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_Evento_CriadoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_Evento_CriadoInfo);
				Delay.Milliseconds(100);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
				
				//SaveGIFTDB(CPFSmilesID, ArrecadarMilhasAte, NomeEvento);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Gift_IrParaEventos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Gift_IrParaEventosInfo, new RecordItemIndex(3));
				repo.SmilesOMelhorProgramaDeMilhasS1.Gift_IrParaEventos.Click(1);
				Delay.Milliseconds(0);
			}
			
			iComponentStatus = Program.endComponent();
        }
        
		public void WaitSystemLoad(string timeout)
        {
        	try {
        		Report.Info("Wainting system load");
        		Smiles_UserCode.WaitLoad(repo, int.Parse(timeout));
        		Report.Info("System loaded");
        	} catch (Exception) {
        		Report.Error("BuscarVoos - Error waiting system load. Timeout:" + timeout);
        		throw new System.Exception("BuscarVoos.WaitSystemLoad");
        	}
        }

        public void SaveGIFTDB(string numSmiles, string dataFim, string nome)
        {
        	try {
        		Report.Info("Saving data");
        		if (dataFim.Contains("d+")) 
        		{
        			dataFim = System.DateTime.Today.AddDays(int.Parse(dataFim.Replace("d+",""))).ToShortDateString();
        		}
        		WebElement eLink = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//a[@class~'smls-color-orange orange'][1]";
        		string link = eLink.Element.GetAttributeValueText("InnerText");
        		//UtilsDB.insertNewGIFT(numSmiles, link, dataFim,nome);
        	} catch (Exception) {
        		Report.Error("Error saving GIFT data in DB");
        	}
        }
    }
}
