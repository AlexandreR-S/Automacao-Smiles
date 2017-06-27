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
    ///The RP_ValidacaoEmissao recording.
    /// </summary>
    [TestModule("b63cf50e-1383-4586-8dae-f55af4ea5bd5", ModuleType.Recording, 1)]
    public partial class RP_ValidacaoEmissao : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_ValidacaoEmissao instance = new RP_ValidacaoEmissao();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_ValidacaoEmissao()
        {
            QuantidadeAdultos = "";
            De1 = "";
            Para1 = "";
            NomeTitular = "";
            BandeiraCartaoCredito = "";
            De2 = "";
            Para2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RP_ValidacaoEmissao Instance
        {
            get { return instance; }
        }

#region Variables

        string _QuantidadeAdultos;

        /// <summary>
        /// Gets or sets the value of variable QuantidadeAdultos.
        /// </summary>
        [TestVariable("1e9a6f50-c3da-43fa-94e5-2ea1028a9ab3")]
        public string QuantidadeAdultos
        {
            get { return _QuantidadeAdultos; }
            set { _QuantidadeAdultos = value; }
        }

        string _NomeTitular;

        /// <summary>
        /// Gets or sets the value of variable NomeTitular.
        /// </summary>
        [TestVariable("605d735c-12d8-400c-bd8e-184b38de9f3f")]
        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De1.
        /// </summary>
        [TestVariable("6f941747-683b-438a-8975-ab2afc90bcb2")]
        public string De1
        {
            get { return repo.De1; }
            set { repo.De1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para1.
        /// </summary>
        [TestVariable("5737ad98-66e1-4749-9004-254c01626755")]
        public string Para1
        {
            get { return repo.Para1; }
            set { repo.Para1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BandeiraCartaoCredito.
        /// </summary>
        [TestVariable("53559c8d-6af1-4bec-98ae-3c57cbf92e7a")]
        public string BandeiraCartaoCredito
        {
            get { return repo.BandeiraCartaoCredito; }
            set { repo.BandeiraCartaoCredito = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De2.
        /// </summary>
        [TestVariable("30e8f1c1-8269-471b-8886-4ce4208608d7")]
        public string De2
        {
            get { return repo.De2; }
            set { repo.De2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para2.
        /// </summary>
        [TestVariable("2ecc4d57-1478-49cf-b3e0-b1a2b5bc8352")]
        public string Para2
        {
            get { return repo.Para2; }
            set { repo.Para2 = value; }
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

            //ValidateResult(QuantidadeAdultos, De1, Para1, De2, Para2, NomeTitular, BandeiraCartaoCredito);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}