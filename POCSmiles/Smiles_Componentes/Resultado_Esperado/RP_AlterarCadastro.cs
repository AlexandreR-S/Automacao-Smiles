/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 26/06/2017
 * Time: 11:47
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
    /// Description of RP_AlterarCadastro.
    /// </summary>
    [TestModule("F8594CC2-F799-4AF6-A3F7-2813B9780973", ModuleType.UserCode, 1)]
    public class RP_AlterarCadastro : ITestModule
    {
    	
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static RP_AlterarCadastro instance = new RP_AlterarCadastro();
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_AlterarCadastro()
        {
            // Do not delete - a parameterless constructor is required!
        }

string _out_Numero_Protocolo = "";
[TestVariable("785a0655-a315-4831-b783-5a8fd7feda61")]
public string out_Numero_Protocolo
{
	get { return _out_Numero_Protocolo; }
	set { _out_Numero_Protocolo = value; }
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
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ValidacaoPositiva_DadosAtualizadosComSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.ValidacaoPositiva_DadosAtualizadosComSucessoInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ValidacaoPositiva_DadosAtualizadosComSucessoInfo);
				Delay.Milliseconds(100);
				
				out_Numero_Protocolo = Utils.GetAttrValue(repo.SmilesOMelhorProgramaDeMilhasS1.Navegacao_ProgramaSmiles, "innertext");
				Program.setProtonOutput("out_Numero_Protocolo", out_Numero_Protocolo);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.AltararDados_BotaoFechar' at 20;33.", repo.SmilesOMelhorProgramaDeMilhasS1.AltararDados_BotaoFecharInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.AltararDados_BotaoFechar.Click("20;33", 1);
				Delay.Milliseconds(490);
			}
			
			iComponentStatus = Program.endComponent();
        }
    }
}
