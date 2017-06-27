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

namespace POCSmiles.Menu_Usuario
{
    public partial class Menu_ClubeSmiles
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void WaitPageLoad()
        {
        	try {
        		Report.Info("Waiting page load");
        		Smiles_UserCode.WaitLoad(repo,30);
        		Report.Info("Page loaded");
        	} catch (Exception) {
        		Report.Error("SelecionarVoo - Error waiting page load");
        		throw new System.Exception("SelecionarVoo.WaitPageLoad");
        	}
        }

    }
}