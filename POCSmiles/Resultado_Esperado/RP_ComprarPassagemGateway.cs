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

namespace POCSmiles.Resultado_Esperado
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RP_ComprarPassagemGateway recording.
    /// </summary>
    [TestModule("1b1ffba2-0ba2-415d-96ea-9d2fb8b8a4b6", ModuleType.Recording, 1)]
    public partial class RP_ComprarPassagemGateway : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_ComprarPassagemGateway instance = new RP_ComprarPassagemGateway();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_ComprarPassagemGateway()
        {
            CPFSmilesID = "";
            DataPartida1 = "";
            QuantidadeAdultos = "";
            QuantidadeCriancas = "";
            QuantidadeBebes = "";
            ObservacoesPNR = "";
            TipoTrajeto = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RP_ComprarPassagemGateway Instance
        {
            get { return instance; }
        }

#region Variables

        string _CPFSmilesID;

        /// <summary>
        /// Gets or sets the value of variable CPFSmilesID.
        /// </summary>
        [TestVariable("d9799238-3bdc-405e-9c90-e29aceb95746")]
        public string CPFSmilesID
        {
            get { return _CPFSmilesID; }
            set { _CPFSmilesID = value; }
        }

        string _DataPartida1;

        /// <summary>
        /// Gets or sets the value of variable DataPartida1.
        /// </summary>
        [TestVariable("a60ac1bc-a0ce-4560-abb8-8de973410ec3")]
        public string DataPartida1
        {
            get { return _DataPartida1; }
            set { _DataPartida1 = value; }
        }

        string _QuantidadeAdultos;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeAdultos.
        /// </summary>
        [TestVariable("73bcf0e5-011b-4e05-a9eb-08673ed48d58")]
        public string QuantidadeAdultos
        {
            get { return _QuantidadeAdultos; }
            set { _QuantidadeAdultos = value; }
        }

        string _QuantidadeCriancas;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeCriancas.
        /// </summary>
        [TestVariable("eeb8ec2a-a2a8-404b-b9c4-51750105aa0e")]
        public string QuantidadeCriancas
        {
            get { return _QuantidadeCriancas; }
            set { _QuantidadeCriancas = value; }
        }

        string _QuantidadeBebes;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeBebes.
        /// </summary>
        [TestVariable("2482d8cc-5c79-429b-8c87-ef0887546da4")]
        public string QuantidadeBebes
        {
            get { return _QuantidadeBebes; }
            set { _QuantidadeBebes = value; }
        }

        string _ObservacoesPNR;

        /// <summary>
        /// Gets or sets the value of variable ObservacoesPNR.
        /// </summary>
        [TestVariable("2068ec8e-882b-43fd-add1-4fd36c82d44d")]
        public string ObservacoesPNR
        {
            get { return _ObservacoesPNR; }
            set { _ObservacoesPNR = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoTrajeto.
        /// </summary>
        [TestVariable("7aa0f20d-b202-40a9-bcaf-dbe026c5b6fb")]
        public string TipoTrajeto
        {
            get { return repo.TipoTrajeto; }
            set { repo.TipoTrajeto = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_MilhasCompradasSucessoInfo);
            Delay.Milliseconds(100);
            
            SavePNRDB(CPFSmilesID, DataPartida1, QuantidadeAdultos, QuantidadeCriancas, QuantidadeBebes, ObservacoesPNR, TipoTrajeto);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NEXT}'.", new RecordItemIndex(3));
            Keyboard.Press("{NEXT}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
