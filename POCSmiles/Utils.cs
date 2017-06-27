/*
 * Created by Ranorex
 * User: welli
 * Date: 01/02/2016
 * Time: 21:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace POCSmiles
{
	/// <summary>
	/// Description of Utils.
	/// </summary>
	[TestModule("38949839-CB67-4077-8D55-7D53E3DC2C67", ModuleType.UserCode, 1)]
	public class Utils : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Utils()
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
			
		}
		
		public static void SelectItemListBoxAsHuman(string element, string itemName, string elementIndex){
			WebElement list = element;
			list.Click(Duration.FromMilliseconds(1));
			string s = list.GetPath().ToResolvedString() + "//span[@innertext~'(?i).*" + itemName +".*(?-i)'][" + elementIndex + "]";
			ClickElement(list.GetPath().ToResolvedString() + "//span[@innertext~'(?i).*" + itemName +".*(?-i)'][" + elementIndex + "]", true);
		}
		
		public static void SelectItemListBox(string selectTagElement, string itemName){
			SelectTag list = selectTagElement;
			OptionTag option = list.FindSingle(".//option[@innertext~'^" + itemName + "$|^ " + itemName + " $']");
			option.Selected = true;
		}
		
		public static void SelectItemListBoxContains(string selectTagElement, string itemName){
			SelectTag list = selectTagElement;
			OptionTag option = list.FindSingle(".//option[@innertext~'" + itemName + "']");
			option.Selected = true;
		}
		
		public static void SelectItemListBoxContainsAsHuman(string elementBase, string element, string itemName){
			WebElement list = elementBase + element;
			list.Touch();
			SpanTag span = elementBase + "//span[@innertext~'(?i).*" + itemName +".*(?-i)'][1]";
			span.Touch();
		}

		public static void SelectOptionComboBox(string referenceName, SmilesRepository repo){
			string a = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString();
			InputTag radio = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//label[@innertext~'^.*?" + referenceName + "?.*$']//input[@Type='radio']";
			radio.Click(Duration.FromMilliseconds(1));
		}
		
		public static void SelectOptionComboBox(string comboBoxPath, string referenceName){
			try {
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
		
		public static void SelectCheckBox(String checkBoxPath, bool check){
			InputTag checkBox = checkBoxPath;
			if (bool.Parse(checkBox.Checked) != check) {
				checkBox.Checked = check.ToString();
			}
		}
		
		public static void ClickElement(string webElement, string property, string value, string index)
		{
			//WebElement element = webElement + "//.[@" + property + "~'" + value + "'][" + index + "]";
			//element.EnsureVisible();
			//element.PerformClick();
			WebElement element = webElement + "//p[@" + property + "~'" + value + "'][" + index + "]";
			element.EnsureVisible();
			element.PerformClick();
		}
		
		public static void ClickElementAsHuman(string webElement, string property, string value, string index)
		{
			WebElement element = webElement + "//.[@" + property + "~'" + value + "'][" + index + "]";
			element.Click(Location.Center, Duration.FromMilliseconds(1));
		}
		
		public static void ClickElement(string webElement)
		{
			WebElement element = webElement;
			element.PerformClick();
		}
		public static void ClickElement(string webElement, bool ensureVisible)
		{
			WebElement element = webElement;
			if (ensureVisible == true) {
				element.EnsureVisible();
			}
			element.PerformClick();
		}
		
		public static void TouchElement(string webElement, bool ensureVisible)
		{
			WebElement element = webElement;
			if (ensureVisible == true) {
				element.EnsureVisible();
			}
			element.Touch();
		}
		
		public static void SelectItemFloatBox(string inputTagElement, string floatBoxElement, string text, string index)
		{
			string typ="";
			int i;
			InputTag inputElement = inputTagElement;
			inputElement.Focus();
			for (i=0; i <= 100 ; i++){
				typ = typ + "{BACK}";
			}
			inputElement.PressKeys(typ,1);
			inputElement.PressKeys(text,Duration.FromMilliseconds(1));
			Utils.ClickElementAsHuman(floatBoxElement,"InnerText",text,index);
		}
		
		public static void ClickTextDataTable(string dataTableTag, string text, string index)
		{
			TableTag dateTable = dataTableTag;
			ATag cell = dateTable.FindSingle(".//a[@innertext='" + text + "'][" + index + "]");
			cell.Click("10;10",Duration.FromMilliseconds(1));
		}
		
		public static bool CheckExist(string webElementFather, string property, string value, int timeout)
		{
			try{
				Ranorex.Validate.Exists(webElementFather + "//.[@" + property + "~'" + value + "']",timeout,"{0}",new Ranorex.Validate.Options(true,ReportLevel.None));
				return true;
			}catch(Exception)
			{
				return false;
			}
		}
		
		public static bool CheckExist(string webElementFather, string property, string value, int timeout, bool ensureVisible)
		{
			try{
				Ranorex.Validate.Exists(webElementFather + "//.[@" + property + "~'.*" + value + ".*']",timeout,"{0}",new Ranorex.Validate.Options(true,ReportLevel.None));
				WebElement we = webElementFather + "//.[@" + property + "~'.*" + value + ".*']";
				we.EnsureVisible();
				return true;
			}catch(Exception)
			{
				return false;
			}
		}
		
		public static bool CheckExist(string xPath, int timeout)
		{
			try{
				Ranorex.Validate.Exists(xPath,Duration.FromMilliseconds(timeout),"{0}",new Ranorex.Validate.Options(true,ReportLevel.None));
				return true;
			}catch(Exception e)
			{
				return false;
			}
		}
		public static bool Exists(string elementPath){
			try {
				Ranorex.Validate.Exists(Program.GetCompletePath(elementPath), Duration.FromMilliseconds(5000),"{0}",new Ranorex.Validate.Options(true,ReportLevel.None));
				return true;
			} catch (Exception e) {
				return false;
			}
		}
		
		public static void SelectOptionComboBox(string comboBoxPath){
			LabelTag label = comboBoxPath;
			InputTag radio = label.FindSingle(".//input[@Type='radio']");
			radio.Click(Duration.FromMilliseconds(1));
		}
		
		public static void WaitDomState(string domIdentifier, bool state, int timeoutSec){
			WebDocument dom = domIdentifier;
		}
		public static string RndNumber(double length){
			double min, max;
		
			min = Math.Pow(10, length-1);
			max = (min*10)-1;
 			Random rnd = new Random();
 			string RndNum = rnd.Next(int.Parse(min.ToString()), int.Parse(max.ToString())).ToString();
			
			return RndNum;
		}
		public static String GerarCpf()
		{
			int soma = 0, resto = 0;
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			
			Random rnd = new Random();
			string semente = rnd.Next(100000000, 999999999).ToString();
			for (int i = 0; i < 9; i++)
				soma += int.Parse(semente[i].ToString()) * multiplicador1[i];
			
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			
			semente = semente + resto;
			soma = 0;
			
			for (int i = 0; i < 10; i++)
				soma += int.Parse(semente[i].ToString()) * multiplicador2[i];
			
			resto = soma % 11;
			
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			
			semente = semente + resto;
			return semente;
		}
		public static string getGlobalValue(string param){
			IDictionary<string, string> idict = TestSuite.Current.Parameters;
			return idict[param];
		}
		public static string GetComponentName(){
			string ComponentName;
			try{
				if (TestReport.CurrentTestModuleActivity != null){
					ComponentName = TestReport.CurrentTestModuleActivity.TestModuleName;
					return ComponentName;
				}else{
					return "";
				}
			}catch(Exception e){
				return "";
			}
		}
		public static string GetAttrValue(Ranorex.Adapter obj, string attr){
			string innerText;
			innerText = obj.Element.GetAttributeValueText(attr);
			return (innerText);
		}
		/// <summary>
		/// Gets element path. Usually used as parameter for TypeKeys method
		/// </summary>
		/// <param name="obj">Repository item info</param>
		/// <returns>The path of the element withou its parents path</returns>
		public static string GetPath(Ranorex.Core.Repository.RepoItemInfo obj) {
			string path;
			path = obj.Path.ToString();
			if (path.StartsWith(".")) {
				path = path.Remove(0,1);
			}
			return (path);
		}
		
	}
}