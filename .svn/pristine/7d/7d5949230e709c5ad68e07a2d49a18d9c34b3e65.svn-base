/*
 * Created by Ranorex
 * User: welli
 * Date: 06/02/2016
 * Time: 10:10
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
    /// Description of DesktopWebFunctions.
    /// </summary>
    [TestModule("42947ACA-AB62-4222-815D-630274781752", ModuleType.UserCode, 1)]
    public class DesktopWebFunctions : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DesktopWebFunctions()
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
