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
using Ranorex.Core.Reporting;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace POCSmiles
{
    public partial class ErrorInspector
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void StartErrorVerifier()
        {
        	try {
				Thread tErrorV = new Thread(errorVerificator);
				tErrorV.IsBackground = true;
				tErrorV.SetApartmentState(ApartmentState.STA);
				tErrorV.Start();        		
        	} catch (Exception) {
        		throw;
        	}
        }
        
        public static void errorVerificator(){
    		while (true) {
        		if (repo.SmilesOMelhorProgramaDeMilhasS1.ErrorMessage_GenericInfo.Exists(Duration.FromMilliseconds(5000))) {
        			Report.Screenshot();
        			Report.Failure("An error message was showed until test execution.");
        			Keyboard.Press(System.Windows.Forms.Keys.Pause, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
		            Delay.Duration(Duration.FromMilliseconds(2000));
        			return;
        		}
    		}
        }
    }
}