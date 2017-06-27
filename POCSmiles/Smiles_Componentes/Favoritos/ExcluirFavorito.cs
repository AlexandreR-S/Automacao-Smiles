/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:35
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

namespace POCSmiles.Smiles_Componentes.Favoritos
{
    /// <summary>
    /// Description of ExcluirFavorito.
    /// </summary>
    [TestModule("5151DAA4-871D-4392-AE7F-B50F7F33AE04", ModuleType.UserCode, 1)]
    public class ExcluirFavorito : ITestModule
    {
    	public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static ExcluirFavorito instance = new ExcluirFavorito();
		
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExcluirFavorito()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_Excluir' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_ExcluirInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_Excluir.Click(1);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(3));
			}
			
			iComponentStatus = Program.endComponent();
        }
    }
}
