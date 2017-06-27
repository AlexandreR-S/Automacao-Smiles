﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace POCSmiles.Resultado_Esperado
{
    public partial class RP_ValidacaoReembolso
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CheckMilhas()
        {
        	try {
        		Report.Info("Checking  Miles");
        		if (!repo.SmilesOMelhorProgramaDeMilhasS1.Login_Milhas.Element.GetAttributeValueText("InnerText").Replace("milhas","").Replace(".","").Trim().Equals((double.Parse(CapturarReembolsoCancelamento.milhasReembolsadas) + double.Parse(CapturarMilhasLogin.totalMilhas)).ToString())) {
        			Report.Screenshot(repo.SmilesOMelhorProgramaDeMilhasS1.Login_Milhas,true);
        			Report.Failure("Miles wasn't repayed");
        		}
        		Report.Info("Miles checked");
        	} catch (Exception e) {
        		Report.Error("CapturarMilhas - Error trying to select. Error:" + e.Message);
        		throw new System.Exception("CapturarMilhas.CapturarMilhas");
        	}
        }

    }
}