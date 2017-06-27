/*
 * Created by Ranorex
 * User: welli
 * Date: 18/01/2017
 * Time: 11:10
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
    /// Ranorex User Code collection. A collection is used to publish User Code methods to the User Code library.
    /// </summary>
    [UserCodeCollection]
    public class UtilsMobile
    {
        public static void SelectItemFloatBox(string divTagElement, string floatBoxElement, string text, string index)
        {
            InputTag element = divTagElement;
            element.Element.SetAttributeValue("Value", text);
        }
        
        public static void TouchElementAsHuman(string webElement, string property, string value, string index)
        {
        	WebElement element = webElement + "//.[@" + property + "~'" + value + "'][" + index + "]";
        	element.Touch();
        }
        
        public static void SelectItemListBox(string selectTagElement, string itemName){
	        OptionTag option = selectTagElement + "//option[@innertext~'" + itemName + "']";
	        option.Selected = true;
        }
        
        public static void SetDate(System.DateTime date, string inputDateElement, string uiDatePicker)
        {
    		InputTag webElement = inputDateElement;
    		if (Utils.CheckExist(uiDatePicker,3000) == true) {
        		webElement.Touch();
        		Ranorex.DateTime dateTimePicker = uiDatePicker;
        		dateTimePicker.Element.SetAttributeValue("Value", date.Year + "-" + date.Month + "-" + date.Day + "T00:00:00-0200");
        		dateTimePicker.PressKeys("{ENTER}");
    		}else{
    			string formatedDate = (date.Year + "-" + (date.Month<10?"0" + date.Month:date.Month.ToString()) + "-" + (date.Day<10?"0" + date.Day:date.Day.ToString())).ToString();
    			webElement.Element.SetAttributeValue("Value", formatedDate);
    		}
        }
        public static void insertText(string inputElement, string text, bool touchBefore){
        	InputTag input = inputElement;
        	if (touchBefore) {
        		input.Touch();
        	}
        	input.Element.SetAttributeValue("Value", text);
        }
    }
}
