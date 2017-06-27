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
    ///The SalvarReport recording.
    /// </summary>
    [TestModule("84ead3b2-5d7e-4dcc-a7e1-0d8302eeee75", ModuleType.Recording, 1)]
    public partial class SalvarReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SalvarReport instance = new SalvarReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SalvarReport()
        {
            CPFSmilesID = "";
            URL = "";
            Browser = "";
            IdentificacaoCaso = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SalvarReport Instance
        {
            get { return instance; }
        }

#region Variables

        string _CPFSmilesID;

        /// <summary>
        /// Gets or sets the value of variable CPFSmilesID.
        /// </summary>
        [TestVariable("357c077b-bff8-4545-be32-26e05d8ee77b")]
        public string CPFSmilesID
        {
            get { return _CPFSmilesID; }
            set { _CPFSmilesID = value; }
        }

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("ad0666d5-0470-448a-97d4-7758e7b9fa80")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
        }

        string _IdentificacaoCaso;

        /// <summary>
        /// Gets or sets the value of variable IdentificacaoCaso.
        /// </summary>
        [TestVariable("d4d3132d-fe45-43c6-8cb4-973b4464ece1")]
        public string IdentificacaoCaso
        {
            get { return _IdentificacaoCaso; }
            set { _IdentificacaoCaso = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("aca5bb12-9af5-4b08-893b-74cf8db51160")]
        public string URL
        {
            get { return repo.URL; }
            set { repo.URL = value; }
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

            CreateReportShortcut();
            Delay.Milliseconds(0);
            
            AtualizarMilhasBD(CPFSmilesID, URL);
            Delay.Milliseconds(0);
            
            AtualizarStatusCasoDeTesteDB(Browser, IdentificacaoCaso);
            Delay.Milliseconds(0);
            
            SalvarTempoExecucao();
            Delay.Milliseconds(0);
            
            //StopThreads();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
