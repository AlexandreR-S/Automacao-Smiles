/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:43
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

namespace POCSmiles.Smiles_Componentes.Menu_Usuario
{
    /// <summary>
    /// Description of AlterarMeusDados.
    /// </summary>
    [TestModule("22AE65D7-E3DF-4260-B674-52D070239174", ModuleType.UserCode, 1)]
    public class AlterarMeusDados : ITestModule
    {
    	
    	public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static AlterarMeusDados instance = new AlterarMeusDados();
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AlterarMeusDados()
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
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuarioInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_DadosUsuario.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_AlterarMeusDados' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_AlterarMeusDadosInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_AlterarMeusDados.Click(1);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoes'.", repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoesInfo, new RecordItemIndex(3));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.AlterarDados_SalvarAlteracoesInfo);
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
			}
			
			iComponentStatus = Program.endComponent();
        }
    }
}
