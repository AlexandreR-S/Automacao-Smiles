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

namespace POCSmiles.Mobile.RxBrowser.Meus_Voos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelecionarVooCancelamentoYY recording.
    /// </summary>
    [TestModule("1a9758b8-514f-4194-a36d-41aebb212f82", ModuleType.Recording, 1)]
    public partial class SelecionarVooCancelamentoYY : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SelecionarVooCancelamentoYY instance = new SelecionarVooCancelamentoYY();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelecionarVooCancelamentoYY()
        {
            IdentificacaoVoo = "SLMG6H";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelecionarVooCancelamentoYY Instance
        {
            get { return instance; }
        }

#region Variables

        string _IdentificacaoVoo;

        /// <summary>
        /// Gets or sets the value of variable IdentificacaoVoo.
        /// </summary>
        [TestVariable("68f306cc-8697-4bff-9d2d-a56c7ca4315b")]
        public string IdentificacaoVoo
        {
            get { return _IdentificacaoVoo; }
            set { _IdentificacaoVoo = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dispositivo.
        /// </summary>
        [TestVariable("da3e43bb-7e4d-42d3-af80-4010368868c5")]
        public string Dispositivo
        {
            get { return repo.Dispositivo; }
            set { repo.Dispositivo = value; }
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

            CancelarVoo(IdentificacaoVoo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RxBrowser.Dom.Button_Continuar' at Center", repo.RxBrowser.Dom.Button_ContinuarInfo, new RecordItemIndex(1));
            repo.RxBrowser.Dom.Button_Continuar.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RxBrowser.Dom.BtnCheckout'.", repo.RxBrowser.Dom.BtnCheckoutInfo, new RecordItemIndex(2));
            Validate.Exists(repo.RxBrowser.Dom.BtnCheckoutInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Dom.Self, false, new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}