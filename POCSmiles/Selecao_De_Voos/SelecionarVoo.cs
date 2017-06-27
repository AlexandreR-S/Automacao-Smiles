﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace POCSmiles.Selecao_De_Voos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelecionarVoo recording.
    /// </summary>
    [TestModule("d34223c2-0df9-483a-abef-6f7cecb565bc", ModuleType.Recording, 1)]
    public partial class SelecionarVoo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SelecionarVoo instance = new SelecionarVoo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelecionarVoo()
        {
            TipoPagamentoTaxas = "";
            TipoPagamentoVooVolta = "";
            TipoPagamentoVooIda = "";
            SiglaCompanhiaAereaIda = "";
            SiglaCompanhiaAereaVolta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelecionarVoo Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoPagamentoTaxas;

        /// <summary>
        /// Gets or sets the value of variable TipoPagamentoTaxas.
        /// </summary>
        [TestVariable("5176d5cd-db51-43f0-966f-6a3affc31a17")]
        public string TipoPagamentoTaxas
        {
            get { return _TipoPagamentoTaxas; }
            set { _TipoPagamentoTaxas = value; }
        }

        string _TipoPagamentoVooVolta;

        /// <summary>
        /// Gets or sets the value of variable TipoPagamentoVooVolta.
        /// </summary>
        [TestVariable("90ba7f03-0a59-498e-9318-0b855f04632d")]
        public string TipoPagamentoVooVolta
        {
            get { return _TipoPagamentoVooVolta; }
            set { _TipoPagamentoVooVolta = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoPagamentoVooIda.
        /// </summary>
        [TestVariable("b0cfb4e0-ebd9-4739-990d-55d333d4f4fc")]
        public string TipoPagamentoVooIda
        {
            get { return repo.TipoPagamentoVooIda; }
            set { repo.TipoPagamentoVooIda = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SiglaCompanhiaAereaIda.
        /// </summary>
        [TestVariable("628964d7-cd97-4296-b2f1-109cb64bcf49")]
        public string SiglaCompanhiaAereaIda
        {
            get { return repo.SiglaCompanhiaAereaIda; }
            set { repo.SiglaCompanhiaAereaIda = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SiglaCompanhiaAereaVolta.
        /// </summary>
        [TestVariable("ccb811ee-cde7-4c20-8c21-6ccae69e750c")]
        public string SiglaCompanhiaAereaVolta
        {
            get { return repo.SiglaCompanhiaAereaVolta; }
            set { repo.SiglaCompanhiaAereaVolta = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            SelectFlyPayment(TipoPagamentoVooIda, "IDA", SiglaCompanhiaAereaIda);
            Delay.Milliseconds(0);
            
            WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            //repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
            
            SelectFlyPayment(TipoPagamentoVooVolta, "VOLTA", SiglaCompanhiaAereaVolta);
            Delay.Milliseconds(0);
            
            WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(7));
            //repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
            
            SelectRatePayment(TipoPagamentoTaxas);
            Delay.Milliseconds(0);
            
            WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(11));
            //repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
            
            SelectCheckBox("//input[#'_smilesordersummaryportlet_WAR_smilesflightsportlet_INSTANCE_RCVV8sHo5yq4_check']", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1' at 63;15.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1Info, new RecordItemIndex(13));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1.Click("63;15", 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(14));
            Delay.Duration(3000, false);
            
            WaitPageLoad();
            Delay.Milliseconds(0);
            
            ClickIfExist();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
