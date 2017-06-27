/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 27/06/2017
 * Time: 16:28
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

namespace POCSmiles.TESTE_GIT
{
    /// <summary>
    /// Description of TESTE_GIT.
    /// </summary>
    [TestModule("167CA95B-341A-490C-B119-0C5269F51FA7", ModuleType.UserCode, 1)]
    public class TESTE_GIT : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TESTE_GIT()
        {
            // Do not delete - a parameterless constructor is required!
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
