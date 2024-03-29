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

namespace POCSmiles.ClubeSmiles
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AlterarPlano recording.
    /// </summary>
    [TestModule("bf37ba35-401e-40fc-b4ce-835afce82cbb", ModuleType.Recording, 1)]
    public partial class AlterarPlano : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static AlterarPlano instance = new AlterarPlano();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AlterarPlano()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AlterarPlano Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano' at 98;21.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlanoInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_AlterarPlano.Click("98;21", 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            WaitSystemLoad("45");
            Delay.Milliseconds(0);
            
            SelecionarPlano();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            WaitSystemLoad("45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ChkAgreement' at CenterLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.ChkAgreementInfo, new RecordItemIndex(6));
            repo.SmilesOMelhorProgramaDeMilhasS1.ChkAgreement.Click(Location.CenterLeft, 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmiles' at 134;11.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmilesInfo, new RecordItemIndex(7));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_QueroSerClubeSmiles.Click("134;11", 1);
            Delay.Milliseconds(490);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
