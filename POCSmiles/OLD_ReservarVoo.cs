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

namespace POCSmiles
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OLD_ReservarVoo recording.
    /// </summary>
    [TestModule("4b98d912-a5c4-4472-a763-581630b0e88b", ModuleType.Recording, 1)]
    public partial class OLD_ReservarVoo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SmilesRepository repository.
        /// </summary>
        public static SmilesRepository repo = SmilesRepository.Instance;

        static OLD_ReservarVoo instance = new OLD_ReservarVoo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OLD_ReservarVoo()
        {
            Browser = "Firefox";
            CPF = "41031322809";
            Senha = "1010";
            NomeTitular = "WELLINGTON SANTANA";
            NumeroCartao = "4111111111111111";
            MesVencimento = "6";
            AnoVencimento = "2016";
            CodigoSeguranca = "737";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OLD_ReservarVoo Instance
        {
            get { return instance; }
        }

#region Variables

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("ad263516-f432-4177-8ffe-f34d01648362")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
        }

        string _CPF;

        /// <summary>
        /// Gets or sets the value of variable CPF.
        /// </summary>
        [TestVariable("326f2770-5f6c-4629-8e77-c5a8fcf4afc4")]
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        string _Senha;

        /// <summary>
        /// Gets or sets the value of variable Senha.
        /// </summary>
        [TestVariable("6484e51c-b8cd-4e31-8602-a2f496c60c3b")]
        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        string _NomeTitular;

        /// <summary>
        /// Gets or sets the value of variable NomeTitular.
        /// </summary>
        [TestVariable("1e19269b-4a4d-434a-be20-6271f775e73d")]
        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        string _NumeroCartao;

        /// <summary>
        /// Gets or sets the value of variable NumeroCartao.
        /// </summary>
        [TestVariable("82936507-9e19-411f-af97-369bf8910039")]
        public string NumeroCartao
        {
            get { return _NumeroCartao; }
            set { _NumeroCartao = value; }
        }

        string _MesVencimento;

        /// <summary>
        /// Gets or sets the value of variable MesVencimento.
        /// </summary>
        [TestVariable("631a0f5a-0e6a-4b4a-8639-9bc30e33638a")]
        public string MesVencimento
        {
            get { return _MesVencimento; }
            set { _MesVencimento = value; }
        }

        string _AnoVencimento;

        /// <summary>
        /// Gets or sets the value of variable AnoVencimento.
        /// </summary>
        [TestVariable("cde0cb19-c736-49cd-bb75-c716f4397725")]
        public string AnoVencimento
        {
            get { return _AnoVencimento; }
            set { _AnoVencimento = value; }
        }

        string _CodigoSeguranca;

        /// <summary>
        /// Gets or sets the value of variable CodigoSeguranca.
        /// </summary>
        [TestVariable("821e7282-6226-46e1-8794-3f2bf06ed3e1")]
        public string CodigoSeguranca
        {
            get { return _CodigoSeguranca; }
            set { _CodigoSeguranca = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesPayment' at 4;6.", repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesPaymentInfo, new RecordItemIndex(0));
            repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesPayment.Click("4;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_TaxasDinhero' at 6;6.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_TaxasDinheroInfo, new RecordItemIndex(1));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_TaxasDinhero.Click("6;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_AcordoContrato' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_AcordoContratoInfo, new RecordItemIndex(3));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_AcordoContrato.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1' at 63;15.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1Info, new RecordItemIndex(4));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar1.Click("63;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SouPassageiro2'.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SouPassageiro2Info, new RecordItemIndex(5));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SouPassageiro2Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Passageiro_SouPassageiro' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.Passageiro_SouPassageiroInfo, new RecordItemIndex(6));
            repo.SmilesOMelhorProgramaDeMilhasS1.Passageiro_SouPassageiro.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar2' at 61;40.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar2Info, new RecordItemIndex(7));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_Continuar2.Click("61;40");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s for item 'SmilesOMelhorProgramaDeMilhasS1.Mensagem_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_AguardeInfo, new ActionTimeout(20000), new RecordItemIndex(8));
            repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_AguardeInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SUA COMPRA') on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_SuaCompra'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_SuaCompraInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_SuaCompraInfo, "InnerText", "SUA COMPRA");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Visa' at 7;11.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_VisaInfo, new RecordItemIndex(10));
            repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Visa.Click("7;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(11));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NomeTitular' with focus on 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NomeTitular'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NomeTitularInfo, new RecordItemIndex(12));
            repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NomeTitular.PressKeys(NomeTitular, 25);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroCartao' with focus on 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NumeroCartao'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NumeroCartaoInfo, new RecordItemIndex(13));
            repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_NumeroCartao.PressKeys(NumeroCartao, 25);
            Delay.Milliseconds(0);
            
            SelectItemListBox("/dom[@domain='portal-uat.smiles.com.br']//select[#'expirationMonth']", MesVencimento);
            Delay.Milliseconds(0);
            
            SelectItemListBox("/dom[@domain='portal-uat.smiles.com.br']//select[#'expirationYear']", AnoVencimento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodigoSeguranca' with focus on 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_CodigoSeguranca'.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_CodigoSegurancaInfo, new RecordItemIndex(16));
            repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_CodigoSeguranca.PressKeys(CodigoSeguranca, 25);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigito' at 23;11.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigitoInfo, new RecordItemIndex(17));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigito.Click("23;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigito' at 19;22.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigitoInfo, new RecordItemIndex(18));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigito.Click("19;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigito' at 13;20.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigitoInfo, new RecordItemIndex(19));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaSegundoDigito.Click("13;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigito' at 23;25.", repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigitoInfo, new RecordItemIndex(20));
            repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigito.Click("23;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next down}'.", new RecordItemIndex(21));
            Keyboard.Press("{Next down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next up}'.", new RecordItemIndex(22));
            Keyboard.Press("{Next up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar' at 98;30.", repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ProcessarInfo, new RecordItemIndex(23));
            repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_Processar.Click("98;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(24));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s for item 'SmilesOMelhorProgramaDeMilhasS1.Mensagem_Aguarde' to not exist.", repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_AguardeInfo, new ActionTimeout(20000), new RecordItemIndex(25));
            repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_AguardeInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Sua passagem foi emitida com sucesso') on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucesso'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucessoInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucessoInfo, "InnerText", "Sua passagem foi emitida com sucesso");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucesso' at 75;9.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucessoInfo, new RecordItemIndex(28));
            repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EmissaoSucesso.Click("75;9", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next down}'.", new RecordItemIndex(29));
            Keyboard.Press("{Next down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next up}'.", new RecordItemIndex(30));
            Keyboard.Press("{Next up}");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next down}'.", new RecordItemIndex(32));
            Keyboard.Press("{Next down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next up}'.", new RecordItemIndex(33));
            Keyboard.Press("{Next up}");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(34));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
