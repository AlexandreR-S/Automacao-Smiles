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

namespace POCSmiles.Base_Dados
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RandomValues recording.
    /// </summary>
    [TestModule("3a96fb6d-ac7d-4a9a-9248-103c28597ef2", ModuleType.Recording, 1)]
    public partial class RandomValues : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RandomValues instance = new RandomValues();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RandomValues()
        {
            URL = "";
            CPFSmilesID = "";
            IdentificacaoVoo = "";
            Senha = "";
            TecladoVirtual = "";
            NumeroDocumentoGrid = "";
            De1 = "";
            Para1 = "";
            De2 = "";
            TipoVoo = "";
            Para2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RandomValues Instance
        {
            get { return instance; }
        }

#region Variables

        string _CPFSmilesID;

        /// <summary>
        /// Gets or sets the value of variable CPFSmilesID.
        /// </summary>
        [TestVariable("953e0d00-3c2d-45ef-942a-ebd3c05bb481")]
        public string CPFSmilesID
        {
            get { return _CPFSmilesID; }
            set { _CPFSmilesID = value; }
        }

        string _IdentificacaoVoo;

        /// <summary>
        /// Gets or sets the value of variable IdentificacaoVoo.
        /// </summary>
        [TestVariable("4df2f3b1-9c95-4844-96a4-e3e281819adf")]
        public string IdentificacaoVoo
        {
            get { return _IdentificacaoVoo; }
            set { _IdentificacaoVoo = value; }
        }

        string _Senha;

        /// <summary>
        /// Gets or sets the value of variable Senha.
        /// </summary>
        [TestVariable("6e265de0-88dd-4e60-bfc4-e176efabfde1")]
        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        string _TecladoVirtual;

        /// <summary>
        /// Gets or sets the value of variable TecladoVirtual.
        /// </summary>
        [TestVariable("1a157687-3b81-4654-925e-3df76b699311")]
        public string TecladoVirtual
        {
            get { return _TecladoVirtual; }
            set { _TecladoVirtual = value; }
        }

        string _TipoVoo;

        /// <summary>
        /// Gets or sets the value of variable TipoVoo.
        /// </summary>
        [TestVariable("01b19051-999a-4a64-89d3-b77c069872e0")]
        public string TipoVoo
        {
            get { return _TipoVoo; }
            set { _TipoVoo = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("f34ff773-0fba-4770-ad1a-24c08c679e56")]
        public string URL
        {
            get { return repo.URL; }
            set { repo.URL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumeroDocumentoGrid.
        /// </summary>
        [TestVariable("a2c5d41c-a6ac-4fee-b338-274398ffc2b1")]
        public string NumeroDocumentoGrid
        {
            get { return repo.NumeroDocumentoGrid; }
            set { repo.NumeroDocumentoGrid = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De1.
        /// </summary>
        [TestVariable("7f540c73-987d-4ba5-834d-7ff02d9dd8e4")]
        public string De1
        {
            get { return repo.De1; }
            set { repo.De1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para1.
        /// </summary>
        [TestVariable("9f5d680d-bbc2-448d-81e0-8560bfe24148")]
        public string Para1
        {
            get { return repo.Para1; }
            set { repo.Para1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable De2.
        /// </summary>
        [TestVariable("075b302f-c5ef-4d5c-8fb4-2339b6a3c4ca")]
        public string De2
        {
            get { return repo.De2; }
            set { repo.De2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Para2.
        /// </summary>
        [TestVariable("f6ca1b3e-edbd-49c9-90b0-522b972e26a4")]
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

            ReplaceRandomValues(URL, CPFSmilesID, Senha, De1, Para1, De2, TipoVoo, Para2);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}