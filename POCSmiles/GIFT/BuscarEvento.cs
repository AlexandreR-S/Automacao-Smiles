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

namespace POCSmiles.GIFT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarEvento recording.
    /// </summary>
    [TestModule("9db471bf-35da-45f5-9f16-a1e0feb2dd86", ModuleType.Recording, 1)]
    public partial class BuscarEvento : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static BuscarEvento instance = new BuscarEvento();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarEvento()
        {
            Evento = "";
            URL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarEvento Instance
        {
            get { return instance; }
        }

#region Variables

        string _Evento;

        /// <summary>
        /// Gets or sets the value of variable Evento.
        /// </summary>
        [TestVariable("88898ae9-89ad-42a5-aac9-1ebbd641469c")]
        public string Evento
        {
            get { return _Evento; }
            set { _Evento = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("aa7b91c3-8944-44bc-a709-ada666e82f1a")]
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

            TypeKeys("//input[@name='search']", Evento, URL);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.GIFT_BotaoBuscarEventos' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.GIFT_BotaoBuscarEventosInfo, new RecordItemIndex(1));
            //repo.SmilesOMelhorProgramaDeMilhasS1.GIFT_BotaoBuscarEventos.Click(1);
            //Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ENTER}'.", new RecordItemIndex(2));
            Keyboard.Press("{ENTER}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            WaitSystemLoad("60");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.GIFT_VisualizarEvento' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.GIFT_VisualizarEventoInfo, new RecordItemIndex(5));
            repo.SmilesOMelhorProgramaDeMilhasS1.GIFT_VisualizarEvento.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}