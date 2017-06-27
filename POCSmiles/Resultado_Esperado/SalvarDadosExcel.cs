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
    ///The SalvarDadosExcel recording.
    /// </summary>
    [TestModule("5ce8aaaf-43fb-4512-bd6e-6c1198e5ed56", ModuleType.Recording, 1)]
    public partial class SalvarDadosExcel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SalvarDadosExcel instance = new SalvarDadosExcel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SalvarDadosExcel()
        {
            excelPath = "";
            CPFSmilesID = "";
            Senha = "";
            DataPartida1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SalvarDadosExcel Instance
        {
            get { return instance; }
        }

#region Variables

        string _excelPath;

        /// <summary>
        /// Gets or sets the value of variable excelPath.
        /// </summary>
        [TestVariable("b088c5e4-21d3-41bf-b277-392312d87282")]
        public string excelPath
        {
            get { return _excelPath; }
            set { _excelPath = value; }
        }

        string _CPFSmilesID;

        /// <summary>
        /// Gets or sets the value of variable CPFSmilesID.
        /// </summary>
        [TestVariable("7bda2b96-34d5-4130-9a80-5405c3046f0d")]
        public string CPFSmilesID
        {
            get { return _CPFSmilesID; }
            set { _CPFSmilesID = value; }
        }

        string _Senha;

        /// <summary>
        /// Gets or sets the value of variable Senha.
        /// </summary>
        [TestVariable("86cb6c09-39ad-4af3-9c2b-34fd2d9c404e")]
        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        string _DataPartida1;

        /// <summary>
        /// Gets or sets the value of variable DataPartida1.
        /// </summary>
        [TestVariable("08ac6c0a-bc52-4c9e-9fdf-d7a8a01c88ad")]
        public string DataPartida1
        {
            get { return _DataPartida1; }
            set { _DataPartida1 = value; }
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

            //SaveUserData(excelPath, CPFSmilesID, Senha);
            //Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}