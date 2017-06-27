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

namespace POCSmiles.Comprar
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConfirmarAlteracao recording.
    /// </summary>
    [TestModule("7d6e1883-0321-4054-af3f-d945a2b0b788", ModuleType.Recording, 1)]
    public partial class ConfirmarAlteracao : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static ConfirmarAlteracao instance = new ConfirmarAlteracao();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmarAlteracao()
        {
            BandeiraCartaoCredito = "";
            NomeTitular = "WELLINGTON SANTANA";
            NumeroCartao = "4111111111111111";
            MesVencimento = "6";
            CodigoSeguranca = "737";
            AnoVencimento = "2016";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmarAlteracao Instance
        {
            get { return instance; }
        }

#region Variables

        string _NomeTitular;

        /// <summary>
        /// Gets or sets the value of variable NomeTitular.
        /// </summary>
        [TestVariable("635b26d6-7ff3-4d4e-a8b6-77b2ea9439a3")]
        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        string _NumeroCartao;

        /// <summary>
        /// Gets or sets the value of variable NumeroCartao.
        /// </summary>
        [TestVariable("63b33648-4d6d-4c15-ab38-4816af89efca")]
        public string NumeroCartao
        {
            get { return _NumeroCartao; }
            set { _NumeroCartao = value; }
        }

        string _MesVencimento;

        /// <summary>
        /// Gets or sets the value of variable MesVencimento.
        /// </summary>
        [TestVariable("21e11c9f-894e-4686-8cbe-cbcdccff8c01")]
        public string MesVencimento
        {
            get { return _MesVencimento; }
            set { _MesVencimento = value; }
        }

        string _CodigoSeguranca;

        /// <summary>
        /// Gets or sets the value of variable CodigoSeguranca.
        /// </summary>
        [TestVariable("e3064ffe-fc7e-4c28-8912-ccef1977cc21")]
        public string CodigoSeguranca
        {
            get { return _CodigoSeguranca; }
            set { _CodigoSeguranca = value; }
        }

        string _AnoVencimento;

        /// <summary>
        /// Gets or sets the value of variable AnoVencimento.
        /// </summary>
        [TestVariable("46a84c9b-3a06-4362-ab60-3ec6a0214452")]
        public string AnoVencimento
        {
            get { return _AnoVencimento; }
            set { _AnoVencimento = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BandeiraCartaoCredito.
        /// </summary>
        [TestVariable("cc5edbd5-8cf9-48ab-a09f-6cd2db17ce7b")]
        public string BandeiraCartaoCredito
        {
            get { return repo.BandeiraCartaoCredito; }
            set { repo.BandeiraCartaoCredito = value; }
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

            SeleclCreditCardFlag(BandeiraCartaoCredito);
            Delay.Milliseconds(0);
            
            WaitSmilesLoad();
            Delay.Milliseconds(0);
            
            TypeKeys("//input[#'_smilesclubportlet_WAR_smilesclubportlet_creditCardHolderName']", NomeTitular);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[#'_smilesclubportlet_WAR_smilesclubportlet_creditCardNumber']", NumeroCartao);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'expirationMonth']", MesVencimento);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'expirationYear']", AnoVencimento);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[#'_smilesclubportlet_WAR_smilesclubportlet_secureCode']", CodigoSeguranca);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfirmarAlteracao' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfirmarAlteracaoInfo, new RecordItemIndex(7));
            repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ConfirmarAlteracao.Click(1);
            Delay.Milliseconds(490);
            
            WaitLoad();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(9));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
