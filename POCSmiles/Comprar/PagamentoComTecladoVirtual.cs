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
    ///The PagamentoComTecladoVirtual recording.
    /// </summary>
    [TestModule("ce51cfc6-85f4-4df2-b40e-529739bab6d5", ModuleType.Recording, 1)]
    public partial class PagamentoComTecladoVirtual : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static PagamentoComTecladoVirtual instance = new PagamentoComTecladoVirtual();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PagamentoComTecladoVirtual()
        {
            NomeTitular = "WELLINGTON SANTANA";
            NumeroCartao = "4111111111111111";
            MesVencimento = "6";
            AnoVencimento = "2016";
            CodigoSeguranca = "737";
            Parcelas = "à vista";
            TecladoVirtual = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PagamentoComTecladoVirtual Instance
        {
            get { return instance; }
        }

#region Variables

        string _NomeTitular;

        /// <summary>
        /// Gets or sets the value of variable NomeTitular.
        /// </summary>
        [TestVariable("fc16fb03-5156-4007-b730-647942f38c09")]
        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        string _NumeroCartao;

        /// <summary>
        /// Gets or sets the value of variable NumeroCartao.
        /// </summary>
        [TestVariable("a6916ecb-effc-4712-99c4-a25af4b5b359")]
        public string NumeroCartao
        {
            get { return _NumeroCartao; }
            set { _NumeroCartao = value; }
        }

        string _MesVencimento;

        /// <summary>
        /// Gets or sets the value of variable MesVencimento.
        /// </summary>
        [TestVariable("f802c138-811f-4a8a-9712-1a29c1e2544a")]
        public string MesVencimento
        {
            get { return _MesVencimento; }
            set { _MesVencimento = value; }
        }

        string _AnoVencimento;

        /// <summary>
        /// Gets or sets the value of variable AnoVencimento.
        /// </summary>
        [TestVariable("12c3b37f-9ff4-449f-af58-c8921599d2ff")]
        public string AnoVencimento
        {
            get { return _AnoVencimento; }
            set { _AnoVencimento = value; }
        }

        string _CodigoSeguranca;

        /// <summary>
        /// Gets or sets the value of variable CodigoSeguranca.
        /// </summary>
        [TestVariable("b6b4c220-e203-400a-9aca-08f83502a1aa")]
        public string CodigoSeguranca
        {
            get { return _CodigoSeguranca; }
            set { _CodigoSeguranca = value; }
        }

        string _Parcelas;

        /// <summary>
        /// Gets or sets the value of variable Parcelas.
        /// </summary>
        [TestVariable("5f00993e-ef31-4245-bbbe-8f8ab9604bd8")]
        public string Parcelas
        {
            get { return _Parcelas; }
            set { _Parcelas = value; }
        }

        string _TecladoVirtual;

        /// <summary>
        /// Gets or sets the value of variable TecladoVirtual.
        /// </summary>
        [TestVariable("876f5bc4-e78f-4930-a337-e5706a44e943")]
        public string TecladoVirtual
        {
            get { return _TecladoVirtual; }
            set { _TecladoVirtual = value; }
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

            TypeKeys("//input[@id='creditCardNumber' or @id='cardNumber']", NumeroCartao);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@id='cardHolderName' or @id='creditCardHolderName']", NomeTitular);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[@id='cardDataMonth' or @id='expirationMonth']/../", MesVencimento);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[@id='cardDataYear' or @id='expirationYear']/../", AnoVencimento);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@id='cardCvc' or @id='secureCode']", CodigoSeguranca);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[@id='installmentSelect' or @id='installmentSelector']/../", Parcelas);
            Delay.Milliseconds(0);
            
            InserirTecladoVirtual(TecladoVirtual);
            Delay.Milliseconds(0);
            
            ClickIfExist();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamentoInfo, new RecordItemIndex(8));
            repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_ContinuarPagamento.Click(1);
            Delay.Milliseconds(490);
            
            WaitLoad();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}