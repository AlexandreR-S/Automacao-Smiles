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

namespace POCSmiles.Escolher_Assentos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EscolherAssentos recording.
    /// </summary>
    [TestModule("e698639e-423e-4cc7-b785-e5dd44ec35de", ModuleType.Recording, 1)]
    public partial class EscolherAssentos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static EscolherAssentos instance = new EscolherAssentos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EscolherAssentos()
        {
            TipoAssento = "CONFORT";
            TipoPagamentoAssento = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EscolherAssentos Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoAssento;

        /// <summary>
        /// Gets or sets the value of variable TipoAssento.
        /// </summary>
        [TestVariable("49d339cb-936f-46a7-8f59-37bf291f6287")]
        public string TipoAssento
        {
            get { return _TipoAssento; }
            set { _TipoAssento = value; }
        }

        string _TipoPagamentoAssento;

        /// <summary>
        /// Gets or sets the value of variable TipoPagamentoAssento.
        /// </summary>
        [TestVariable("7d5d39ee-ec5f-400b-8740-5c98d261384d")]
        public string TipoPagamentoAssento
        {
            get { return _TipoPagamentoAssento; }
            set { _TipoPagamentoAssento = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.EscolherAssentos' at 158;23.", repo.SmilesOMelhorProgramaDeMilhasS1.EscolherAssentosInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.EscolherAssentos.Click("158;23", 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos'.", repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo, new RecordItemIndex(1));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo);
            Delay.Milliseconds(100);
            
            SelecionarAssento(TipoAssento, TipoPagamentoAssento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentosInfo, new RecordItemIndex(3));
            repo.SmilesOMelhorProgramaDeMilhasS1.FinalizarSelecaoDeAssentos.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(4));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
