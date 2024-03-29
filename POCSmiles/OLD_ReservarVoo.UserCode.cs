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

namespace POCSmiles
{
    public partial class OLD_ReservarVoo
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
             
        public void SelectItemListBox(string selectTagElement, string itemName){
            try {
            	Report.Log(ReportLevel.Info, "Select", "Selecting the item " + itemName);
            	SelectTag list = selectTagElement;
	        	OptionTag option = list.FindSingle(".//option[@innertext~'^" + itemName + "$|^ " + itemName + " $']");
//            	OptionTag option = list.FindSingle(".//option[@Label='" + itemName + "']");
	        	option.Selected = true;
            } catch (Exception e) {
				Report.Error("Error selecting the item" + itemName + " from element: " + selectTagElement + "");
                Console.WriteLine(e.ToString());
                Report.Screenshot();            	
            }
        }
        
        public void SelectOptionComboBox(string comboBoxPath, string referenceName){
            try {
            	Report.Log(ReportLevel.Info, "Select radio", "Selecting the item " + referenceName);
				comboBoxPath = comboBoxPath.Replace("XXX",referenceName);
            	LabelTag label = "/dom[@domain='portal-uat.smiles.com.br']//label[@innertext~'^.*?" + referenceName + "?.*$']";
            	InputTag radio = label.FindSingle(".//input[@Type='radio']");
            	radio.Click(Duration.FromMilliseconds(1));
            } catch (Exception e) {
            	Report.Error("Error selecting the item" + referenceName + " from element: " + comboBoxPath);
                Console.WriteLine(e.ToString());
                Report.Screenshot();            	
            }
        }
        
        public void SelectCheckBox(String checkBoxPath, bool check){
            try {
            	Report.Log(ReportLevel.Info, "Check", "Checking the checkbox " + check);
            	InputTag checkBox = checkBoxPath;
            	
            	if (bool.Parse(checkBox.Checked) != check) {
            		checkBox.Checked = check.ToString();
            	}
            	
            } catch (Exception e) {
            	Report.Error("Error checking the checkbox to " + check + " from element: " + checkBoxPath);
                Console.WriteLine(e.ToString());
                Report.Screenshot();            	
            }
        }

        private void Init()
        {
        }
        
    }
}