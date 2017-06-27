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

namespace POCSmiles.Mobile.RxBrowser.Pagamento
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PagamentoSemTecladoVirtual recording.
    /// </summary>
    [TestModule("d624f10f-b026-4de5-a32e-255ce2ca86fd", ModuleType.Recording, 1)]
    public partial class PagamentoSemTecladoVirtual : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static PagamentoSemTecladoVirtual instance = new PagamentoSemTecladoVirtual();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PagamentoSemTecladoVirtual()
        {
            NumeroCartao = "4111111111111111";
            NomeTitular = "WELLINGTON SANTANA";
            MesVencimento = "6";
            AnoVencimento = "2016";
            CodigoSeguranca = "737";
            Parcelas = "à vista";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PagamentoSemTecladoVirtual Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumeroCartao;

        /// <summary>
        /// Gets or sets the value of variable NumeroCartao.
        /// </summary>
        [TestVariable("c1cd3684-0c13-4488-97fe-3eb60386e2dd")]
        public string NumeroCartao
        {
            get { return _NumeroCartao; }
            set { _NumeroCartao = value; }
        }

        string _NomeTitular;

        /// <summary>
        /// Gets or sets the value of variable NomeTitular.
        /// </summary>
        [TestVariable("b340db65-4bb4-4f1b-9c75-b7040940f44a")]
        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        string _MesVencimento;

        /// <summary>
        /// Gets or sets the value of variable MesVencimento.
        /// </summary>
        [TestVariable("d04e8e6a-76f4-41e4-93b2-3d1b3dfaf232")]
        public string MesVencimento
        {
            get { return _MesVencimento; }
            set { _MesVencimento = value; }
        }

        string _AnoVencimento;

        /// <summary>
        /// Gets or sets the value of variable AnoVencimento.
        /// </summary>
        [TestVariable("2fa86925-40fc-499b-9307-5763a2394d36")]
        public string AnoVencimento
        {
            get { return _AnoVencimento; }
            set { _AnoVencimento = value; }
        }

        string _CodigoSeguranca;

        /// <summary>
        /// Gets or sets the value of variable CodigoSeguranca.
        /// </summary>
        [TestVariable("275724bf-f152-4694-a48b-40a1af7d8c1a")]
        public string CodigoSeguranca
        {
            get { return _CodigoSeguranca; }
            set { _CodigoSeguranca = value; }
        }

        string _Parcelas;

        /// <summary>
        /// Gets or sets the value of variable Parcelas.
        /// </summary>
        [TestVariable("a2719824-0793-42c2-aa77-66971877cde7")]
        public string Parcelas
        {
            get { return _Parcelas; }
            set { _Parcelas = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dispositivo.
        /// </summary>
        [TestVariable("da3e43bb-7e4d-42d3-af80-4010368868c5")]
        public string Dispositivo
        {
            get { return repo.Dispositivo; }
            set { repo.Dispositivo = value; }
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RxBrowser.Dom.Input_NumeroCartao' at Center", repo.RxBrowser.Dom.Input_NumeroCartaoInfo, new RecordItemIndex(0));
            repo.RxBrowser.Dom.Input_NumeroCartao.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$NumeroCartao' on item 'RxBrowser.Dom.Input_NumeroCartao'.", repo.RxBrowser.Dom.Input_NumeroCartaoInfo, new RecordItemIndex(1));
            repo.RxBrowser.Dom.Input_NumeroCartao.Element.SetAttributeValue("Value", NumeroCartao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RxBrowser.Dom.Input_NumeroCartao' at Center", repo.RxBrowser.Dom.Input_NumeroCartaoInfo, new RecordItemIndex(2));
            repo.RxBrowser.Dom.Input_NumeroCartao.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'RxBrowser.Dom'.", repo.RxBrowser.Dom.SelfInfo, new RecordItemIndex(3));
            repo.RxBrowser.Dom.Self.PressKeys("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$NomeTitular' on item 'RxBrowser.Dom.Input_NomeNoCartao'.", repo.RxBrowser.Dom.Input_NomeNoCartaoInfo, new RecordItemIndex(4));
            repo.RxBrowser.Dom.Input_NomeNoCartao.Element.SetAttributeValue("Value", NomeTitular);
            Delay.Milliseconds(0);
            
            selectList(MesVencimento, "//select[#'cardDataMonth']");
            Delay.Milliseconds(0);
            
            selectList(AnoVencimento, "//select[#'cardDataYear']");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$CodigoSeguranca' on item 'RxBrowser.Dom.Input_CodigoSeguranca'.", repo.RxBrowser.Dom.Input_CodigoSegurancaInfo, new RecordItemIndex(7));
            repo.RxBrowser.Dom.Input_CodigoSeguranca.Element.SetAttributeValue("Value", CodigoSeguranca);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Self, false, new RecordItemIndex(8));
            
            selectListAsHuman(Parcelas, "//div[#'installmentSelectDiv']//span[@innertext='Número de parcelas' or @innertext~'(?i)à vista(?-i)'][1]");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RxBrowser.Dom.BtnCheckout' at Center", repo.RxBrowser.Dom.BtnCheckoutInfo, new RecordItemIndex(11));
            repo.RxBrowser.Dom.BtnCheckout.Touch();
            Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Self, false, new RecordItemIndex(12));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
