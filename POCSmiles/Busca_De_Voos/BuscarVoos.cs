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

namespace POCSmiles.Busca_De_Voos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarVoos recording.
    /// </summary>
    [TestModule("60096201-82c0-41a7-8f2b-da40db3297dc", ModuleType.Recording, 1)]
    public partial class BuscarVoos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static BuscarVoos instance = new BuscarVoos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarVoos()
        {
            De1 = "";
            Para1 = "";
            TipoTrajeto = "";
            De2 = "";
            Para2 = "";
            QuantidadeAdultos = "";
            QuantidadeBebes = "";
            QuantidadeCriancas = "";
            DataPartida1 = "";
            DataRetorno1 = "";
            DataPartida2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarVoos Instance
        {
            get { return instance; }
        }

#region Variables

        string _QuantidadeAdultos;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeAdultos.
        /// </summary>
        [TestVariable("6a98cd29-92cb-41bb-b28b-beda249d0789")]
        public string QuantidadeAdultos
        {
            get { return _QuantidadeAdultos; }
            set { _QuantidadeAdultos = value; }
        }

        string _QuantidadeBebes;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeBebes.
        /// </summary>
        [TestVariable("692e1237-a023-4e85-8ce7-c1d6c9ac980a")]
        public string QuantidadeBebes
        {
            get { return _QuantidadeBebes; }
            set { _QuantidadeBebes = value; }
        }

        string _QuantidadeCriancas;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeCriancas.
        /// </summary>
        [TestVariable("c65ad473-1cd3-40c9-b922-0cab821334e0")]
        public string QuantidadeCriancas
        {
            get { return _QuantidadeCriancas; }
            set { _QuantidadeCriancas = value; }
        }

        string _DataPartida1;

        /// <summary>
        /// Gets or sets the value of variable DataPartida1.
        /// </summary>
        [TestVariable("92521fba-6ae7-47da-998f-89341f05d33e")]
        public string DataPartida1
        {
            get { return _DataPartida1; }
            set { _DataPartida1 = value; }
        }

        string _DataRetorno1;

        /// <summary>
        /// Gets or sets the value of variable DataRetorno1.
        /// </summary>
        [TestVariable("bea34b74-a4e3-4917-9004-48080b41eb2a")]
        public string DataRetorno1
        {
            get { return _DataRetorno1; }
            set { _DataRetorno1 = value; }
        }

        string _DataPartida2;

        /// <summary>
        /// Gets or sets the value of variable DataPartida2.
        /// </summary>
        [TestVariable("dc1aef88-3818-420d-9f77-e86dc4d2f557")]
        public string DataPartida2
        {
            get { return _DataPartida2; }
            set { _DataPartida2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De1.
        /// </summary>
        [TestVariable("5844ff35-b4bb-432f-b339-6f2080e4401e")]
        public string De1
        {
            get { return repo.De1; }
            set { repo.De1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para1.
        /// </summary>
        [TestVariable("1b98686d-ef15-4e22-9c69-69a469191a90")]
        public string Para1
        {
            get { return repo.Para1; }
            set { repo.Para1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoTrajeto.
        /// </summary>
        [TestVariable("c466c55f-4e7c-4b73-83f0-ace281985195")]
        public string TipoTrajeto
        {
            get { return repo.TipoTrajeto; }
            set { repo.TipoTrajeto = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De2.
        /// </summary>
        [TestVariable("210268ad-11bb-470b-bbac-9de13134e502")]
        public string De2
        {
            get { return repo.De2; }
            set { repo.De2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para2.
        /// </summary>
        [TestVariable("8791f8fc-8ae5-476e-a9c0-e5a6a2d83e70")]
        public string Para2
        {
            get { return repo.Para2; }
            set { repo.Para2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVoo' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVooInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVoo.Click(Location.LowerCenter, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            WaitSystemLoad("45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVoo'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVooInfo, new RecordItemIndex(3));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVooInfo);
            Delay.Milliseconds(100);
            
            SelectItemFloatBox("//input[#'inputOrigin']", "//div[#'searchFlightTab']", De1);
            Delay.Milliseconds(100);
            
            SelectItemListBox("//select[#'pathFligth']", TipoTrajeto);
            Delay.Milliseconds(0);
            
            SelectItemFloatBox("//input[#'inputDestination']", "//div[#'searchFlightTabBack']", Para1);
            Delay.Milliseconds(100);
            
            SelectItemFloatBox("//input[#'inputMoreOrigin']", "//div[#'moreSearchFlightTab']", De2);
            Delay.Milliseconds(100);
            
            SelectItemFloatBox("//input[#'inputMoreDestination']", "//div[#'moreSearchFlightTabBack']", Para2);
            Delay.Milliseconds(100);
            
            SetCalendarDate("//input[#'inputGoingOriginDate']", DataPartida1);
            Delay.Milliseconds(0);
            
            SetCalendarDate("//input[#'inputBackDate']", DataRetorno1);
            Delay.Milliseconds(0);
            
            SetCalendarDate("//input[#'inputMoreGoingOriginDate']", DataPartida2);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'qtdAdult']", QuantidadeAdultos);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'qtdChild']", QuantidadeCriancas);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'qtdBaby']", QuantidadeBebes);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BuscarVoo' at 106;32.", repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BuscarVooInfo, new RecordItemIndex(15));
            repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BuscarVoo.Click("106;32", 1);
            Delay.Milliseconds(90);
            
            ClickIfExist();
            Delay.Milliseconds(0);
            
            WaitSystemLoad("60");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(18));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}