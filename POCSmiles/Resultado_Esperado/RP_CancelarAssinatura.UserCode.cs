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
using POCSmiles.Base_Dados;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace POCSmiles.Resultado_Esperado
{
    public partial class RP_CancelarAssinatura
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void AtualizarDB(string numSmiles, string url)
        {
        	try {
        		Report.Info("Atualizando banco de dados");
        		UtilsDB.updateClube(numSmiles, url, false);
        		Report.Info("Banco de dados atualizado");
        	} catch (Exception e) {
        		Report.Error("Error launched trying to update data base. Error: " + e.Message);
        	}
        }

    }
}