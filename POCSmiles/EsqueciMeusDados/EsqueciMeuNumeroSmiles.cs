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

namespace POCSmiles.EsqueciMeusDados
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EsqueciMeuNumeroSmiles recording.
    /// </summary>
    [TestModule("cc2a1626-14de-47b3-86d8-49f140e0530d", ModuleType.Recording, 1)]
    public partial class EsqueciMeuNumeroSmiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static EsqueciMeuNumeroSmiles instance = new EsqueciMeuNumeroSmiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EsqueciMeuNumeroSmiles()
        {
            TipoDocumento = "";
            Documento = "yourtext";
            DataNascimentoDia = "yourtext";
            DataNascimentoMes = "yourtext";
            DataNascimentoAno = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EsqueciMeuNumeroSmiles Instance
        {
            get { return instance; }
        }

#region Variables

        string _Documento;

        /// <summary>
        /// Gets or sets the value of variable Documento.
        /// </summary>
        [TestVariable("58cfe4b9-63c6-4b86-9864-4d91d7a51208")]
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        string _DataNascimentoDia;

        /// <summary>
        /// Gets or sets the value of variable DataNascimentoDia.
        /// </summary>
        [TestVariable("9b63f572-34bb-416c-b7e8-219dafd199ca")]
        public string DataNascimentoDia
        {
            get { return _DataNascimentoDia; }
            set { _DataNascimentoDia = value; }
        }

        string _DataNascimentoMes;

        /// <summary>
        /// Gets or sets the value of variable DataNascimentoMes.
        /// </summary>
        [TestVariable("a73bd89d-8922-4d2b-bb2c-0b097c9ed36d")]
        public string DataNascimentoMes
        {
            get { return _DataNascimentoMes; }
            set { _DataNascimentoMes = value; }
        }

        string _DataNascimentoAno;

        /// <summary>
        /// Gets or sets the value of variable DataNascimentoAno.
        /// </summary>
        [TestVariable("76554adb-2b3a-411c-a1c4-1ee05ca67178")]
        public string DataNascimentoAno
        {
            get { return _DataNascimentoAno; }
            set { _DataNascimentoAno = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoDocumento.
        /// </summary>
        [TestVariable("351b4d7d-dd10-4fa5-99cc-5a3e96176189")]
        public string TipoDocumento
        {
            get { return repo.TipoDocumento; }
            set { repo.TipoDocumento = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone'.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(1));
            repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone.Click(Location.LowerCenter, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone'.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(2));
            Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles' at 61;11.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmilesInfo, new RecordItemIndex(3));
            //repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles.Click("61;11", 1);
            //Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{TAB}'.", new RecordItemIndex(4));
            Keyboard.Press("{TAB}{TAB}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles' at 61;11.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmilesInfo, new RecordItemIndex(6));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles.Click("61;11", 1);
            Delay.Milliseconds(490);
            
            SelectItemListBox("//select[#'inputDocumentType']", TipoDocumento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumentoInfo, new RecordItemIndex(8));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumento.PressKeys(Documento, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoDia' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDia'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDiaInfo, new RecordItemIndex(9));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDia.PressKeys(DataNascimentoDia, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoMes' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMes'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMesInfo, new RecordItemIndex(10));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMes.PressKeys(DataNascimentoMes, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoAno' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAno'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAnoInfo, new RecordItemIndex(11));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAno.PressKeys(DataNascimentoAno, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar' at 69;23.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarInfo, new RecordItemIndex(12));
            repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar.Click("69;23", 1);
            Delay.Milliseconds(490);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
