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

namespace POCSmiles.Mobile.AppSmiles.BuscaDeVoos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarVoos recording.
    /// </summary>
    [TestModule("d629dba3-45ab-4e29-b4aa-8fac2e4d9a49", ModuleType.Recording, 1)]
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
            TipoTrajeto = "";
            Para1 = "";
            De2 = "";
            Para2 = "";
            DataPartida1 = "";
            DataRetorno1 = "";
            DataPartida2 = "";
            QuantidadeAdultos = "";
            QuantidadeCriancas = "";
            QuantidadeBebes = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarVoos Instance
        {
            get { return instance; }
        }

#region Variables

        string _DataPartida1;

        /// <summary>
        /// Gets or sets the value of variable DataPartida1.
        /// </summary>
        [TestVariable("4c3102bd-cf78-4612-ad74-c8f07b69b13a")]
        public string DataPartida1
        {
            get { return _DataPartida1; }
            set { _DataPartida1 = value; }
        }

        string _DataRetorno1;

        /// <summary>
        /// Gets or sets the value of variable DataRetorno1.
        /// </summary>
        [TestVariable("522d906a-6528-43d6-a8ca-8ee53d2a315b")]
        public string DataRetorno1
        {
            get { return _DataRetorno1; }
            set { _DataRetorno1 = value; }
        }

        string _DataPartida2;

        /// <summary>
        /// Gets or sets the value of variable DataPartida2.
        /// </summary>
        [TestVariable("07cef811-8905-4be7-8a13-016c3ec5f1ea")]
        public string DataPartida2
        {
            get { return _DataPartida2; }
            set { _DataPartida2 = value; }
        }

        string _QuantidadeAdultos;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeAdultos.
        /// </summary>
        [TestVariable("ca20cdd0-10de-41de-bae1-0a6d8a9aa93d")]
        public string QuantidadeAdultos
        {
            get { return _QuantidadeAdultos; }
            set { _QuantidadeAdultos = value; }
        }

        string _QuantidadeCriancas;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeCriancas.
        /// </summary>
        [TestVariable("fa0351f6-e6c9-4a89-93ab-dc22589d39e7")]
        public string QuantidadeCriancas
        {
            get { return _QuantidadeCriancas; }
            set { _QuantidadeCriancas = value; }
        }

        string _QuantidadeBebes;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeBebes.
        /// </summary>
        [TestVariable("a5f0d7f1-23ea-4f16-9147-0af77c6556f6")]
        public string QuantidadeBebes
        {
            get { return _QuantidadeBebes; }
            set { _QuantidadeBebes = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De1.
        /// </summary>
        [TestVariable("09cc0574-19c9-4843-b202-aef308ed5230")]
        public string De1
        {
            get { return repo.De1; }
            set { repo.De1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para1.
        /// </summary>
        [TestVariable("321fa093-95d3-4c9e-8e05-68a94d66f2e0")]
        public string Para1
        {
            get { return repo.Para1; }
            set { repo.Para1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De2.
        /// </summary>
        [TestVariable("82a7405f-a1d5-4d55-8037-fc7a4f62e9f3")]
        public string De2
        {
            get { return repo.De2; }
            set { repo.De2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para2.
        /// </summary>
        [TestVariable("c6d1fa73-ec58-4fb3-8e3a-dcb25c10a931")]
        public string Para2
        {
            get { return repo.Para2; }
            set { repo.Para2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoTrajeto.
        /// </summary>
        [TestVariable("c865e7b3-f8f2-4db1-947b-e7d6cb8a1182")]
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'AppSmiles.SearchFly.Trajeto' at Center", repo.AppSmiles.SearchFly.TrajetoInfo, new RecordItemIndex(0));
            repo.AppSmiles.SearchFly.Trajeto.Touch();
            Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AppSmiles.Self, false, new RecordItemIndex(1));
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'AppSmiles.SearchFly.De1' at Center", repo.AppSmiles.SearchFly.De1Info, new RecordItemIndex(2));
            //repo.AppSmiles.SearchFly.De1.Touch();
            //Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AppSmiles.Self, false, new RecordItemIndex(3));
            
            SelecionarDestinos(TipoTrajeto, De1, Para1, De2, Para2);
            Delay.Milliseconds(0);
            
            SelecionarDatas(TipoTrajeto, DataPartida1, DataRetorno1, DataPartida2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'AppSmiles.SearchFly.Trajeto' at Center", repo.AppSmiles.SearchFly.TrajetoInfo, new RecordItemIndex(6));
            repo.AppSmiles.SearchFly.Trajeto.Touch();
            Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AppSmiles.Self, false, new RecordItemIndex(7));
            
            SelecionarPassageiros(QuantidadeAdultos, QuantidadeCriancas, QuantidadeBebes);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'AppSmiles.SearchFly.Trajeto' at Center", repo.AppSmiles.SearchFly.TrajetoInfo, new RecordItemIndex(9));
            repo.AppSmiles.SearchFly.Trajeto.Touch();
            Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AppSmiles.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Touch Gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '5000' with swipe duration'500ms' and step count '0' on item 'AppSmiles.SearchFly'.", repo.AppSmiles.SearchFly.SelfInfo, new RecordItemIndex(11));
            repo.AppSmiles.SearchFly.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "5000"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'AppSmiles.SearchFly.BotaoBuscarVoos' at Center", repo.AppSmiles.SearchFly.BotaoBuscarVoosInfo, new RecordItemIndex(13));
            repo.AppSmiles.SearchFly.BotaoBuscarVoos.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'AppSmiles.TicketingActivity.BotaoOrdenarVoos'.", repo.AppSmiles.TicketingActivity.BotaoOrdenarVoosInfo, new RecordItemIndex(14));
            Validate.Exists(repo.AppSmiles.TicketingActivity.BotaoOrdenarVoosInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AppSmiles.Self, false, new RecordItemIndex(15));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}