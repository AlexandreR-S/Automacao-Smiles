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
    ///The RP_EditarFavorito recording.
    /// </summary>
    [TestModule("6e40a9d1-28ca-4f2f-9df4-eda14cc6c71c", ModuleType.Recording, 1)]
    public partial class RP_EditarFavorito : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_EditarFavorito instance = new RP_EditarFavorito();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_EditarFavorito()
        {
            CPFSmilesID = "";
            NumeroDocumento = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RP_EditarFavorito Instance
        {
            get { return instance; }
        }

#region Variables

        string _CPFSmilesID;

        /// <summary>
        /// Gets or sets the value of variable CPFSmilesID.
        /// </summary>
        [TestVariable("ed02074d-8998-4039-b523-427c4f55adc6")]
        public string CPFSmilesID
        {
            get { return _CPFSmilesID; }
            set { _CPFSmilesID = value; }
        }

        string _NumeroDocumento;

        /// <summary>
        /// Gets or sets the value of variable NumeroDocumento.
        /// </summary>
        [TestVariable("a439dc66-f43a-4eaa-ab7b-0b31e72aa37b")]
        public string NumeroDocumento
        {
            get { return _NumeroDocumento; }
            set { _NumeroDocumento = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortito'.", repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortitoInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Favorito_ValidacaoCadastroFavortitoInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
            
            SaveDB(CPFSmilesID, NumeroDocumento);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}