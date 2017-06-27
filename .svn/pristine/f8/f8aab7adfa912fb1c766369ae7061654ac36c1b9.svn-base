/*
 * Created by Ranorex
 * User: welli
 * Date: 23/11/2016
 * Time: 15:41
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
    /// Description of IniciarEstimativa.
    /// </summary>
    [TestModule("D666C2A7-ACFC-46F2-B030-013BC7625C88", ModuleType.UserCode, 1)]
    public class IniciarEstimativa : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IniciarEstimativa()
        {
            // Do not delete - a parameterless constructor is required!
            Report.Info("Initiazing test estimation");
            iniciarFormProgresso();
            Report.Info("Test estimation finished");
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
        
        public static POCSmiles.FormProgresso formP = new POCSmiles.FormProgresso();
        public static Thread tF = new Thread(ApplicationRunProc);
		[STAThread]
		private void iniciarFormProgresso(){
			tF.Start(formP);
			formP.initForm();
			formP.processarEstimativa();
//			tF.Start();
		}
        private static void ApplicationRunProc(object state)
        {
           WinForms.Application.Run(state as WinForms.Form);
        }

    }
}
