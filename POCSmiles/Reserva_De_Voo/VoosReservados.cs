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

namespace POCSmiles.Reserva_De_Voo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VoosReservados recording.
    /// </summary>
    [TestModule("b8f68838-2de1-4eed-8751-4d28b61a8ad4", ModuleType.Recording, 1)]
    public partial class VoosReservados : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static VoosReservados instance = new VoosReservados();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VoosReservados()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VoosReservados Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservados' at UpperCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservadosInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_VoosReservados.Click(Location.UpperCenter, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgora'.", repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgoraInfo, new RecordItemIndex(1));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_FinalizarEmissaoAgoraInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
