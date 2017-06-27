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

namespace POCSmiles.Transferencia_De_Milhas
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TransferirMilhas recording.
    /// </summary>
    [TestModule("3ea1fb1c-44bc-4aa3-a1cc-9e96cedfdc83", ModuleType.Recording, 1)]
    public partial class TransferirMilhas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static TransferirMilhas instance = new TransferirMilhas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TransferirMilhas()
        {
            NumSmiles = "";
            CPF = "";
            Milhas = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TransferirMilhas Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumSmiles;

        /// <summary>
        /// Gets or sets the value of variable NumSmiles.
        /// </summary>
        [TestVariable("18d1f9a4-3dab-4ac6-8bef-488cfe65cf2b")]
        public string NumSmiles
        {
            get { return _NumSmiles; }
            set { _NumSmiles = value; }
        }

        string _CPF;

        /// <summary>
        /// Gets or sets the value of variable CPF.
        /// </summary>
        [TestVariable("a79b09ba-a912-4639-aea7-f3cf6e2f4fdd")]
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        string _Milhas;

        /// <summary>
        /// Gets or sets the value of variable Milhas.
        /// </summary>
        [TestVariable("0b3f5518-4870-4d74-af0f-01780a3cc1e2")]
        public string Milhas
        {
            get { return _Milhas; }
            set { _Milhas = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumSmiles' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmilesInfo, new RecordItemIndex(1));
            repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_NumeroSmiles.PressKeys(NumSmiles, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CPF' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPF'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPFInfo, new RecordItemIndex(2));
            repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_CPF.PressKeys(CPF, 1);
            Delay.Milliseconds(80);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Consultar' at 67;11.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_ConsultarInfo, new RecordItemIndex(3));
            //repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Consultar.Click("67;11", 1);
            //Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(4));
            Keyboard.Press("{TAB}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SmilesOMelhorProgramaDeMilhasS1.PValidacao_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_AguardeInfo.WaitForNotExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Milhas' with focus on 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas'.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_MilhasInfo, new RecordItemIndex(7));
            repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Milhas.PressKeys(Milhas, 1);
            Delay.Milliseconds(90);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            //Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{NEXT}'.", new RecordItemIndex(9));
            Keyboard.Press("{TAB}{NEXT}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Continuar' at UpperLeft.", repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_ContinuarInfo, new RecordItemIndex(10));
            repo.SmilesOMelhorProgramaDeMilhasS1.TransferirMilhas_Continuar.Click(Location.UpperLeft, 1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            WaitLoad();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
