/*
 * Created by Ranorex
 * User: QASmiles
 * Date: 06/06/2017
 * Time: 09:54
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
using Ranorex.Core.Repository;

namespace POCSmiles.Smiles_Componentes.Generico
{
	/// <summary>
	/// Description of StartScript.
	/// </summary>
	[TestModule("13EC580C-0A06-47DA-A998-B3CBD4EB5338", ModuleType.UserCode, 1)]
	public class StartScript : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public StartScript()
		{
			// Do not delete - a parameterless constructor is required!
		}
		
		#region Variables
		#endregion

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
			
			
			var Id_Dataset_Scenario = "";
			var Id_Dataset_Run = "";
			
			var sScenario = TestCaseNode.Current.Name;
			
			var sCountry = TestCaseNode.Current.Parameters["Country"].ToString();
			var sCompanyCode = TestCaseNode.Current.Parameters["Company_Code"].ToString();
			var iDatasetVersion = TestCaseNode.Current.Parameters["Dataset_Version"].ToString();
			
			var webReqDatasetScenario = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/GetDatasetScenario");
			webReqDatasetScenario.Method = "GET";
			webReqDatasetScenario.Timeout = 12000;
			webReqDatasetScenario.ContentType = "text/plain";
			webReqDatasetScenario.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReqDatasetScenario.Headers.Add("Scenario", sScenario);
			webReqDatasetScenario.Headers.Add("Country", sCountry);
			webReqDatasetScenario.Headers.Add("Company_Code", sCompanyCode);
			webReqDatasetScenario.Headers.Add("Dataset_Version", iDatasetVersion);
			
			using (System.IO.Stream s = webReqDatasetScenario.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					Id_Dataset_Scenario = sr.ReadToEnd().ToString();
				}
			}
			
			
			var webReqDatasetRun = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/CreateDatasetRun");
			webReqDatasetRun.Method = "POST";
			webReqDatasetRun.Timeout = 12000;
			webReqDatasetRun.ContentType = "text/plain";
			webReqDatasetRun.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReqDatasetRun.Headers.Add("Id_Dataset_Scenario", Id_Dataset_Scenario);
			webReqDatasetRun.Headers.Add("Username", "ranorex");
			webReqDatasetRun.Headers.Add("System", sCompanyCode);
			webReqDatasetRun.Headers.Add("Status", "Running");
			webReqDatasetRun.Headers.Add("Cycle", "1");
			
			using (System.IO.Stream s = webReqDatasetRun.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					Id_Dataset_Run = sr.ReadToEnd().ToString();
				}
			}
			
			Environment.SetEnvironmentVariable("CST_DATASET_RUN", Id_Dataset_Run.ToString(), EnvironmentVariableTarget.User);
		}
	}
}