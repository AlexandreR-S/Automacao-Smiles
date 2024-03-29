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

namespace POCSmiles.Reativar_Milhas
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Menu_ReativarMilhas recording.
    /// </summary>
    [TestModule("33e7d159-946f-4047-bff5-a36eb15c1e5d", ModuleType.Recording, 1)]
    public partial class Menu_ReativarMilhas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static Menu_ReativarMilhas instance = new Menu_ReativarMilhas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Menu_ReativarMilhas()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Menu_ReativarMilhas Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhas' at 72;7.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhasInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_JuntarEUsarMilhas.Click("72;7", 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhas' at 143;16.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhasInfo, new RecordItemIndex(2));
            repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_TelaReativarMilhas.Click("143;16", 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhasInfo, new RecordItemIndex(3));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.ReativarMilhas_BotaoReativarMilhasInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
