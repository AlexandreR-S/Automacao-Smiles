/*
 * Created by Ranorex
 * User: welli
 * Date: 21/12/2016
 * Time: 09:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Description of SelecaoBrowser.
    /// </summary>
    [TestModule("4C6606EA-DA59-4C60-9A6D-FC1914891ED1", ModuleType.UserCode, 1)]
    public class SelecaoBrowser : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelecaoBrowser()
        {
            // Do not delete - a parameterless constructor is required!
            setBrowserEachTest();
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
        public static int contTests = 0;
        private void setBrowserEachTest(){
        	try {
        		if (!Utils.getGlobalValue("BROWSER").Equals("")) {
        			Report.Info("Setting browser to test: " + Utils.getGlobalValue("BROWSER"));
	        		var rconf = Ranorex.Core.Testing.TestSuite.Current.SelectedRunConfig.GetActiveTestCases();
	        		for (int i = 0; i< rconf.Count; i++){
						if (!rconf.ElementAt(i).DisplayName.Equals("Smiles - Test Suite") && !rconf.ElementAt(i).DisplayName.Equals("INIT_SMILES")) {
	        				string rows = "";
							rconf.ElementAt(i).DataContext.ReloadData();
							for(int z = 0; z <  rconf.ElementAt(i).DataContext.Source.Rows.Count; z++){
								if (rconf.ElementAt(i).DisplayName.StartsWith("M")) {
									if (rows.Equals("")) {
										rows += (z+1).ToString();
									}else{
										rows += "," + (z+1).ToString();
									}
									contTests++;
								}else{
									string browserExcel = rconf.ElementAt(i).DataContext.Source.Rows.ElementAt(z).Values.ElementAt(0).ToString();
									string browserGlobal = Utils.getGlobalValue("BROWSER");
									if (rconf.ElementAt(i).DataContext.Source.Rows.ElementAt(z).Values.ElementAt(0).ToString().ToUpper().Equals(Utils.getGlobalValue("BROWSER").ToUpper())) {
										if (rows.Equals("")) {
											rows += (z+1).ToString();
										}else{
											rows += "," + (z+1).ToString();
										}
										contTests++;
									}
								}
							}
							if (!rows.Equals("")) {
								rconf.ElementAt(i).DataContext.SetRange(DataRangeSet.Parse(rows));
								rconf.ElementAt(i).DataContext.ReloadData();
							}
						}
					}
	        		Report.Info("Browser setted");
        		}
        	} catch (Exception e) {
        		Report.Error("Error trying to set browser to test. Error:" + e.Message);
        	}
        }
    }
}
