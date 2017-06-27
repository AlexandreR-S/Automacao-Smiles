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

namespace POCSmiles.Selecao_De_Voos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AdesaoClubeSmiles recording.
    /// </summary>
    [TestModule("af287c87-6d8c-4ccb-9ef3-0cdd9688dcfb", ModuleType.Recording, 1)]
    public partial class AdesaoClubeSmiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static AdesaoClubeSmiles instance = new AdesaoClubeSmiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdesaoClubeSmiles()
        {
            CPF = "";
            URL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AdesaoClubeSmiles Instance
        {
            get { return instance; }
        }

#region Variables

        string _CPF;

        /// <summary>
        /// Gets or sets the value of variable CPF.
        /// </summary>
        [TestVariable("521b08ad-a3f8-4596-a55c-ca9ec4721804")]
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("986966b4-dc7a-4831-9fca-928c6e5c3ac9")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordo' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordoInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_LiEConcordo.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ContinuarEntrarClube' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ContinuarEntrarClubeInfo, new RecordItemIndex(1));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ContinuarEntrarClube.Click(1);
            Delay.Milliseconds(490);
            
            WaitLoad();
            Delay.Milliseconds(0);
            
            UpdateUserDB(CPF, URL);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}