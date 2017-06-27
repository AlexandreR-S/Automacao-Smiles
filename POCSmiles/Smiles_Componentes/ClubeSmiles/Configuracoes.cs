/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 20/06/2017
 * Time: 17:18
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

namespace POCSmiles.Smiles_Componentes.ClubeSmiles
{
    /// <summary>
    /// Description of Configuracoes.
    /// </summary>
    [TestModule("9E4D49AE-4837-4F45-BCD4-FA1E9A739C72", ModuleType.UserCode, 1)]
    public class Configuracoes : ITestModule
    {
    	public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static Configuracoes instance = new Configuracoes();
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Configuracoes()
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_Configuracoes' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfiguracoesInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_Configuracoes.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano'.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlanoInfo, new RecordItemIndex(1));
            //Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlanoInfo);
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.AlterarPlano_ConhecerOutrosPlanosInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
  
        }
    }
}
