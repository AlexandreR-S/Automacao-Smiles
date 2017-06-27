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
    ///The RP_NavegacaoLinksFooter recording.
    /// </summary>
    [TestModule("dcc432e2-6aa5-4649-ad54-ed16bfc27384", ModuleType.Recording, 1)]
    public partial class RP_NavegacaoLinksFooter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_NavegacaoLinksFooter instance = new RP_NavegacaoLinksFooter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_NavegacaoLinksFooter()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RP_NavegacaoLinksFooter Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("aa7b91c3-8944-44bc-a709-ada666e82f1a")]
        public string URL
        {
            get { return repo.URL; }
            set { repo.URL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LinksFooter.
        /// </summary>
        [TestVariable("e91c8fcf-d1b8-4183-b32b-bb9200e00387")]
        public string LinksFooter
        {
            get { return repo.LinksFooter; }
            set { repo.LinksFooter = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.ProgramaSmiles'.", repo.Windows.ProgramaSmilesInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Windows.ProgramaSmilesInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
