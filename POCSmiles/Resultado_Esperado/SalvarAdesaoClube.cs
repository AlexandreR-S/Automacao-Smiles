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
    ///The SalvarAdesaoClube recording.
    /// </summary>
    [TestModule("a42d1e31-ab7d-471f-a9da-51f093d8fdc9", ModuleType.Recording, 1)]
    public partial class SalvarAdesaoClube : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SalvarAdesaoClube instance = new SalvarAdesaoClube();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SalvarAdesaoClube()
        {
            CadastroUsuarios = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SalvarAdesaoClube Instance
        {
            get { return instance; }
        }

#region Variables

        string _CadastroUsuarios;

        /// <summary>
        /// Gets or sets the value of variable CadastroUsuarios.
        /// </summary>
        [TestVariable("95fbc22d-3835-4dd9-bc54-c08d9cb2f943")]
        public string CadastroUsuarios
        {
            get { return _CadastroUsuarios; }
            set { _CadastroUsuarios = value; }
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

            SalvarAdesao(CadastroUsuarios);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}