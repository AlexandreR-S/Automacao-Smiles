/*
 * Created by Ranorex
 * User: welli
 * Date: 23/11/2016
 * Time: 15:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace POCSmiles
{
    /// <summary>
    /// Description of VerificarAgenda.
    /// </summary>
    [TestModule("B7CD24BA-16F8-4B5C-8704-632F179A0555", ModuleType.UserCode, 1)]
    public class VerificarAgenda : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerificarAgenda()
        {
            if (!Utils.getGlobalValue("AGENDAR").Equals("")) {
            	Report.Info("Verifying test schedule");
				System.DateTime scheduled = System.DateTime.Parse(Utils.getGlobalValue("AGENDAR"));
				if (System.DateTime.Now.CompareTo(scheduled) < 0) {
					Report.Log(ReportLevel.Info, "Wainting to execute: " + Utils.getGlobalValue("AGENDAR"));
				}
				while (System.DateTime.Now.CompareTo(scheduled) < 0) {
					Delay.Seconds(1);
				}
				Report.Info("Schedule checked");
			}
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
