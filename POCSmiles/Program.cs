/*
 * Created by Ranorex
 * User: welli
 * Date: 15/01/2016
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace POCSmiles
{
	class Program
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;
		
		[STAThread]
		public static int Main(string[] args)
		{
			// Uncomment the following 2 lines if you want to automate Windows apps
			// by starting the test executable directly
			Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
			int error = 0;

			try
			{
				error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
			}
			catch (Exception e)
			{
				Report.Error("Unexpected exception occurred: " + e.ToString());
				error = -1;
			}finally{
				if (IniciarEstimativa.tF.IsAlive == true) {
					FormProgresso.keepT = false;
					POCSmiles.IniciarEstimativa.formP.fecharForm();
				}

				if(error == -1){
					updateStatus("Failed");
				}else{
					updateStatus("Passed");
				}
				
				
			}
			return error;
		}
		
		//Funçoes do componente CadastrarUsuario
		
		public static string randomCPF = "";
		public static string randomEmail = "";
		
		public static void SelectGenderFlag(string element, string sexo){
			try {
				if (sexo.Equals("")) {
					return;
				}
				Report.Info("Selecting");
				Utils.ClickElementAsHuman(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + element,"InnerText",sexo,"1");
				Report.Info(sexo + " selected");
			} catch (Exception e) {
				Report.Error(Utils.GetComponentName() + "- Error selecting gender");
				throw new System.Exception(Utils.GetComponentName() + ".SeleclGenderFlag");
			}
		}
		
		public static void setCPF(){
			randomCPF = Utils.GerarCpf();
		}
		
		public static string setRandomEmail(){
			if (randomCPF.Equals("")) {
				randomCPF = Utils.GerarCpf();
			}
			return ("test" + randomCPF + "@email.com");
		}

		public static string setCpf(string cpf){
			try {
				Report.Log(ReportLevel.Info,"Inserting '" + cpf + "'");
				if (cpf.Trim().Equals("ALEATORIO")) {
					cpf = Utils.GerarCpf();
					repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CPF.PressKeys(cpf,Duration.FromMilliseconds(1));
				}else{
					repo.SmilesOMelhorProgramaDeMilhasS1.Cadastro_CPF.PressKeys(cpf,Duration.FromMilliseconds(1));
				}
				randomCPF = cpf;
				
				Report.Info(cpf + " inserted");
			} catch (Exception e) {
				Report.Error("CadastrarUsuario - Error waiting browser loading");
				throw new System.Exception("CadastrarUsuario.setCpf");
			}
			
			return cpf;
			
		}
		
		public static void setEmail(Ranorex.InputTag repoitem, string email){
			try {
				Report.Log(ReportLevel.Info,"Inserting '" + email + "'");
				repoitem.Click();
				if (email.Trim().Equals("ALEATORIO")) {
					email = setRandomEmail();
					
					repoitem.PressKeys("{END}{SHIFT DOWN}{HOME DOWN}{DELETE}{SHIFT UP}{HOME UP}" + email,Duration.FromMilliseconds(1));
					randomEmail = email;
				}
				else if (email.Trim().Equals("CONFIRMAR")) {
					repoitem.PressKeys("{END}{SHIFT DOWN}{HOME DOWN}{DELETE}{SHIFT UP}{HOME UP}" + setRandomEmail(),Duration.FromMilliseconds(1));
				}
				else{
					repoitem.PressKeys("{END}{SHIFT DOWN}{HOME DOWN}{DELETE}{SHIFT UP}{HOME UP}" + email,Duration.FromMilliseconds(1));
					randomEmail = email;
				}
				Report.Info(email + " inserted");
			} catch (Exception e) {
				Report.Error(Utils.GetComponentName() + "CadastrarUsuario - Error waiting browser loading");
				throw new System.Exception(Utils.GetComponentName() + "CadastrarUsuario.setEmail");
			}
		}
		
		public static void SelectCheckBox(string checkBoxPath, bool check)
		{
		}

		public static void TypeKeys(string element, string text)
		{
			string typ = "";
			int i;
			
			try
			{
				if (text.Equals("")) {
					return;
				}
				Report.Log(ReportLevel.Info,"Inserting text '" + text + "'");
				InputTag input = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + element;
				input.Focus();
				for (i=0; i <= 100 ; i++){
					typ = typ + "{BACK}";
				}
				input.PressKeys(typ,1);
				
				input.PressKeys("{END}{SHIFT DOWN}{HOME DOWN}{DELETE}{SHIFT UP}{HOME UP}" + text,Duration.FromMilliseconds(1));
				Report.Log(ReportLevel.Info,"Text inserted '" + text + "'");
			} catch (Exception e){
				
				Report.Error(Utils.GetComponentName() + " - Error launched trying to inserting text '" + text + "' on element '" + element + "'");
				throw new System.Exception(Utils.GetComponentName() + ".TypeKeys");
			}
		}
		
		public static void WaitLoad(SmilesRepository repo, int timeoutSec)
		{
			if(Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString(), 5000))
			{
				WebDocument smiles = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString();
				smiles.WaitForDocumentLoaded(Duration.FromMilliseconds(timeoutSec * 1000));
			}
		}
		
		public static void SelectItemListBoxAsHuman(string selectTagElement, string itemName, string elementIndex)
		{
			try
			{
				if(itemName.Equals("")){
					return;
				}
				Report.Log(ReportLevel.Info,"Selecting item '" + itemName + "'");
				Utils.SelectItemListBoxAsHuman(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + selectTagElement, itemName, elementIndex);
				Report.Log(ReportLevel.Info,"Item '" + itemName + "' selected");
			} catch (Exception e)
			{
				Report.Error(Utils.GetComponentName() + "- Error launched trying to inserting text '" + itemName + "' on element '" + selectTagElement + "'");
				throw new System.Exception(Utils.GetComponentName() + ".TypeKeys");
			}
		}
		
		//Funcoes do IniciaDesktop
		
		public static void Begin(string browser, string url)
		{
			try {
				Host.Local.OpenBrowser(url,browser,"",false,true,false,false,false);
				
			}
			catch (Exception e) {
				Report.Error("IniciarDesktop - Error starting system. Error:" + e.Message);
				throw new System.Exception("IniciarDesktop.Begin");
			}
		}
		
		
		//Funcoes do componente AdesaoCadastro
		public static void InserirCPF()
		{
			repo.SmilesOMelhorProgramaDeMilhasS1.Clube_CPF.PressKeys(Cadastro.CadastrarUsuario.randomCPF,Duration.FromMilliseconds(1));
		}

		public static void WaitSmilesLoad()
		{
			try {
				Report.Info("Waiting Smiles' loading GIF");
				Smiles_UserCode.WaitSmilesLoadGIF(repo,15);
				Report.Info("Smiles' loading GIF desapeared");
			} catch (Exception) {
				Report.Error("SelecionarVoo - Error waiting Smiles' loading GIF desapear");
				throw new System.Exception("SelecionarVoo.WaitSmilesLoad");
			}
		}

		public static void InvokeClick()
		{
			try {
				Report.Info("Invoking action 'click' on element 'ClubeSmiles_EntreJaEmissao'");
				ButtonTag b = repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_EntreJaEmissaoInfo.AbsolutePath.ToResolvedString();
				b.RaiseEvent("click");
			} catch (Exception) {
				
				throw;
			}
		}
		
		public static void WaitSystemLoad(string timeout)
		{
			try {
				Report.Info("Wainting system load");
				Smiles_UserCode.WaitLoad(repo, int.Parse(timeout));
				Report.Info("System loaded");
			} catch (Exception) {
				Report.Error("BuscarVoos - Error waiting system load. Timeout:" + timeout);
				throw new System.Exception("BuscarVoos.WaitSystemLoad");
			}
		}

		public static void ClickIfExist(Ranorex.Adapter Obj){
			if (Utils.CheckExist(Obj.GetPath().ToResolvedString(),10000)) {
				Obj.Click(Duration.FromMilliseconds(1));
				Report.Info("Passed","Objeto encontrado e clicado");
			}else{
				Report.Info("Não encontrado","Objeto não existe na tela");
			}
		}

		public static void SelectItemListBox(string selectTagElement, string itemName)
		{
			try
			{
				if(itemName.Equals("")){
					return;
				}
				Report.Log(ReportLevel.Info,"Selecting item '" + itemName + "'");
				Utils.SelectItemListBox(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + selectTagElement, itemName);
				Report.Log(ReportLevel.Info,"Item '" + itemName + "' selected");
			} catch (Exception)
			{
				Report.Error(Utils.GetComponentName() + "- Error launched trying to select item '" + itemName + "' on element '" + selectTagElement + "'");
				throw new System.Exception("CadastrarUsuario.SeletItemListBox");
			}
		}

		public static void ClickIfExist()
		{
			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmilesInfo.AbsolutePath.ToResolvedString(),1000)) {
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles.Click(Duration.FromMilliseconds(1));
			}
		}
		
		public static void AtualizarMilhasBD(string CPFSmilesID, string URL)
		{
			try {
				Smiles_UserCode.AtualizarMilhasBD(CPFSmilesID, URL, repo);
			}catch (Exception e) {


				Report.Error("Database query execution  exception- Error updating user in data base: " + e.Message);
			}
		}
		
		public static void VerificarTela()
		{

			bool flag = Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_BotaoFecharErrosInfo.AbsolutePath.ToResolvedString(), 5000);
			if(flag == true){
				repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_BotaoFecharErros.Click(Duration.FromMilliseconds(1));
				Delay.Duration(Duration.FromMilliseconds(1000));
			}
		}
		
		public static String getProtonValue(String sParameter){
			
			String returnValue = "";
			
			var iDatasetRunId = Environment.GetEnvironmentVariable("CST_DATASET_RUN", EnvironmentVariableTarget.User).ToString();
			
			var webReq = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/GetInParamValue");
			webReq.Method = "GET";
			webReq.Timeout = 12000;
			webReq.ContentType = "text/plain";
			webReq.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReq.Headers.Add("Dataset_Run", iDatasetRunId);
			webReq.Headers.Add("Parameter", sParameter);
			
			using (System.IO.Stream s = webReq.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					returnValue = sr.ReadToEnd().ToString();
				}
			}
			
			return returnValue;
			
		}
		public static void updateStatus(String sStatus){
			
			var iDatasetRunId = Environment.GetEnvironmentVariable("CST_DATASET_RUN", EnvironmentVariableTarget.User).ToString();
			
			var webReq = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/DatasetRun/UpdateStatus");
			webReq.Method = "PUT";
			webReq.Timeout = 12000;
			webReq.ContentType = "text/plain";
			webReq.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReq.Headers.Add("Id_Dataset_Run", iDatasetRunId);
			webReq.Headers.Add("Status", sStatus);
			
			using (System.IO.Stream s = webReq.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					var returnValue = sr.ReadToEnd().ToString();
				}
			}
			
		}
		
		public static String startComponent(){
			
			String returnValue = "";
			
			var iDatasetRunId = Environment.GetEnvironmentVariable("CST_DATASET_RUN", EnvironmentVariableTarget.User).ToString();
			
			var webReq = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/StartComponent");
			webReq.Method = "POST";
			webReq.Timeout = 12000;
			webReq.ContentType = "text/plain";
			webReq.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReq.Headers.Add("Dataset_Run", iDatasetRunId);
			
			using (System.IO.Stream s = webReq.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					returnValue = sr.ReadToEnd().ToString();
				}
			}
			
			return returnValue;
			
		}
		
		public static String endComponent(){
			
			String returnValue = "";
			
			var iDatasetRunId = Environment.GetEnvironmentVariable("CST_DATASET_RUN", EnvironmentVariableTarget.User).ToString();
			
			var webReq = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/EndComponent");
			webReq.Method = "POST";
			webReq.Timeout = 12000;
			webReq.ContentType = "text/plain";
			webReq.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReq.Headers.Add("Dataset_Run", iDatasetRunId);
			
			using (System.IO.Stream s = webReq.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					returnValue = sr.ReadToEnd().ToString();
				}
			}
			
			return returnValue;
		}
		public static String setProtonOutput(String sParameter, String sValue){
			
			String returnValue = "";
			
			var iDatasetRunId = Environment.GetEnvironmentVariable("CST_DATASET_RUN", EnvironmentVariableTarget.User).ToString();
			
			var webReq = System.Net.WebRequest.Create("http://10.2.3.110:8080/Gravity/rest/Proton/ProtonLib/SetOutParamValue");
			webReq.Method = "POST";
			webReq.Timeout = 12000;
			webReq.ContentType = "text/plain";
			webReq.Headers.Add("Authorization", "cmFub3JleDpzbWlsZXM=");
			webReq.Headers.Add("Dataset_Run", iDatasetRunId);
			webReq.Headers.Add("Parameter", sParameter);
			webReq.Headers.Add("Value", sValue);
			
			using (System.IO.Stream s = webReq.GetResponse().GetResponseStream())
			{
				using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
				{
					returnValue = sr.ReadToEnd().ToString();
				}
			}
			
			return returnValue;
			
		}
		public static void selectTrecho(string tipoTrajeto){
			try {
				Report.Log(ReportLevel.Info,"Selecting item '" + tipoTrajeto + "'");
				if (tipoTrajeto.Equals("")) {
					return;
				}
				switch (tipoTrajeto) {
					case "SOMENTE IDA":
						repo.SmilesOMelhorProgramaDeMilhasS1.TipoTrajeto_SomenteIda.Click();
						break;
					case "VÁRIOS TRECHOS":
						repo.SmilesOMelhorProgramaDeMilhasS1.TipoTrajeto_AdicionarTrecho.Click();
						break;
				}
			} catch (Exception e) {
				Report.Failure("Error launched in BuscarVoos. Error: " + e.Message);
			}
		}
		
		public static void SelectItemFloatBox(string inputTagElement, string floatBoxElement, string text){
			try {
				if (text.Equals(""))
				{
					return;
				}
				Report.Log(ReportLevel.Info,"Seleting item '" + text + "'");
				Utils.SelectItemFloatBox(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + inputTagElement,repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + floatBoxElement,text,"1");
				Report.Log(ReportLevel.Info,"Item '" + text + "' selected");
			} catch (Exception)
			{
				Report.Error(Utils.GetComponentName() + " - Error launched trying to select item '" + text + "'");
				throw new System.Exception(Utils.GetComponentName() + ".SelectItemFloatBox");
			}
		}
		
		public static void insertPassengers(string adultos, string criancas, string bebes){
			try {
				Report.Log(ReportLevel.Info, "Inserting passengers");
				if (!adultos.Equals("") && !adultos.Equals("0")) {
					int countMax = int.Parse(adultos);
					for (int count = 1; count < countMax; count++) {
						repo.SmilesOMelhorProgramaDeMilhasS1.BuscaVoo_AumentarAdultos.Click();
					}
				}
				if (!criancas.Equals("") && !criancas.Equals("0")) {
					int countMax = int.Parse(criancas);
					for (int count = 0; count < countMax; count++) {
						repo.SmilesOMelhorProgramaDeMilhasS1.BuscaVoo_AumentarCriancas.Click();
					}
				}
				if (!bebes.Equals("") && !bebes.Equals("0")) {
					int countMax = int.Parse(bebes);
					for (int count = 0; count < countMax; count++) {
						repo.SmilesOMelhorProgramaDeMilhasS1.BuscaVoo_AumentarBebes.Click();
					}
				}
			} catch (Exception e) {
				Report.Failure("BuscarVoos - Error launched trying to insert passengers");
			}
		}
		
		public static void SetCalendarDate(string calendarIcon, string date)
		{
			try
			{
				if(date.Equals(""))
				{
					return;
				}
				
				Report.Info("Selectiong date on calendar with date: " + date);
				InputTag calendar = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + calendarIcon;
				calendar.EnsureVisible();
				calendar.Click(Location.LowerCenter,Duration.FromMilliseconds(1));
				System.DateTime newDate;
				if (date.Contains("?")) {
					Random rnd = new Random();
					if (InitSetup.ida1 == 0) {
						InitSetup.ida1 = rnd.Next(int.Parse(Utils.getGlobalValue("MIN_DATE_RANGE")));
						date = date.Replace("?", InitSetup.ida1.ToString());
					}
					else if(InitSetup.ida1 != 0 && InitSetup.volta1 == 0){
						InitSetup.volta1 = rnd.Next(InitSetup.ida1 + 1, int.Parse(Utils.getGlobalValue("MAX_DATE_RANGE")));
						date = date.Replace("?", InitSetup.volta1.ToString());
					}
					else if(InitSetup.ida2 == 0){
						InitSetup.ida2 = rnd.Next(int.Parse(Utils.getGlobalValue("MIN_DATE_RANGE")));
						date = date.Replace("?", InitSetup.ida2.ToString());
					}
					else if(InitSetup.ida2 != 0 && InitSetup.volta2 == 0){
						InitSetup.volta2 = rnd.Next(InitSetup.ida2 + 1, int.Parse(Utils.getGlobalValue("MAX_DATE_RANGE")));
						date = date.Replace("?", InitSetup.volta2.ToString());
					}
				}
				if (date.Contains("d+"))
				{
					newDate = System.DateTime.Today.AddDays(int.Parse(date.Replace("d+","")));
				}else
				{
					newDate = System.DateTime.Parse(date);
				}
				Smiles_UserCode.SetCalendarDate(newDate.ToString(),repo);
				Report.Info("Date: " + date + " selected");
			} catch (Exception e) {
				Report.Error("BuscarVoos - Error launched trying to select date " + date + ". Message: " + e.Message);
				throw new System.Exception("BuscarVoos.SetCalendarDate");
			}
		}
		
		public static void ExpectedResult(string valor, string check){
			bool flag = Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//.[@innertext~'" + valor.Replace("'","") + "' and @visible='True'][1]", 60000);
			if(bool.Parse(check) != flag){
				Report.Error("ResultadoEsperado - Erro lançado em resultado esperado. Valor: " + valor + " Check: " + check);
				throw new System.Exception("RN_BuscarVoo.ExpectedResult");
			}
		}
		
		
		public static void SetCalendarDate2(string calendarIcon, string date)
		{
			try
			{
				if(date.Equals(""))
				{
					return;
				}
				var currCultureInfo = CultureInfo.CreateSpecificCulture("pt-br");
				Report.Info("Selectiong date on calendar with date: " + date);
				WebElement calendar = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + calendarIcon;
				calendar.Focus();
				calendar.EnsureVisible();
				calendar.Click(Duration.FromMilliseconds(1));
				System.DateTime newDate = System.DateTime.Parse(date, currCultureInfo);
				Smiles_UserCode.SetCalendarDate(newDate.ToString(),repo);
				Report.Info("Date: " + date + " selected");
			} catch (Exception) {
				Report.Error("SolicitarMilhas - Error launched trying to select date " + date);
				throw new System.Exception("SolicitarMilhas.SetCalendarDate");
			}
		}
		
		public static void anexarArquivo(string arquivo, string webElement){
			try {
				if(arquivo.Equals(""))
				{
					return;
				}
				Report.Log(ReportLevel.Info,"Attaching file '" + arquivo + "'");
				Smiles_UserCode.anexarArquivo(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + webElement, arquivo,repo);
				Report.Log(ReportLevel.Info,"File attached");
			} catch (Exception e) {
				Report.Error("SolicitarMilhas - Error launched trying to insert " + arquivo + ". Error: " + e.Message);
				throw new System.Exception("SolicitarMilhas.anexarArquivo");
			}
		}
		public static void CheckVisible(string element){
			if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + element, 5000)){
				Keyboard.Press("{NEXT}");
			}
		}
		public static string GetCompletePath(string descendants){
			return repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + descendants;
		}
		public static void CheckVisible()
		{
			int Tout = 8000;
			if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_flightNumber' and @visible='True']", Tout) && !Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@name~'_smilescreditrequestportlet_WAR_smilesmemberportlet_trackingNumber' and @visible='True']", Tout) && !Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_flightNumber' and @visible='True']", Tout) && !Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//input[@name~'_smilescreditrequestportlet_WAR_smilesmemberportlet_trackingNumberG31' and @visible='True']", Tout)) {
				Keyboard.Press("{NEXT}");
			}
		}
		
		public static void SelectFlyPayment(string type)
		{
			try {
				if (type.Equals("") || type.Equals("NA") || type.Equals("N/A"))
				{
					return;
				}
				Report.Info("Selecting payment type '" + type + "'");
				Smiles_UserCode.SelectFlyPaymentNew(repo,"",type,"");
				Report.Info("Payment selected");
			} catch (Exception) {
				Report.Error("Tooltip - Error selecting payment type '" + type + "'");
				throw new System.Exception("Tooltip.SelectFlyPayment");
			}
		}
		public static void FocusModalMenssage()
		{
			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_CaixaMensagemInfo.AbsolutePath.ToResolvedString(),1000)) {
				Report.Screenshot(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_CaixaMensagem);
			}
		}
		
		public static void CloseApplicationEmilia()
		{
			Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Emilia'.", repo.EmiliaInbenta.SelfInfo);
			if (Utils.CheckExist(repo.EmiliaInbenta.AbsoluteBasePath.ToResolvedString(), 2000))
			{
				repo.EmiliaInbenta.Self.Close();
				//            	Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, 62, Keyboard.DefaultKeyPressTime, 1, true);
				//            	Keyboard.Press("{ESCAPE}");
			}
		}
		public static void WaitPageLoad()
		{
			try {
				Report.Info("Waiting page load");
				Smiles_UserCode.WaitLoad(repo,30);
				Report.Info("Page loaded");
			} catch (Exception) {
				Report.Error("SelecionarVoo - Error waiting page load");
				throw new System.Exception("SelecionarVoo.WaitPageLoad");
			}
		}
		
		public static void InserirTecladoVirtual(string senha){
			try
			{
				Report.Log(ReportLevel.Info,"Inserting password '" + senha + "'");
				foreach(char c in senha.ToCharArray()){
					Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarVoo_SenhaPrimeiroDigitoInfo.AbsolutePath.ToResolvedString().Replace("0",c.ToString()));
				}
				Report.Log(ReportLevel.Info,"Password '" + senha + "' inserted");
			} catch (Exception)
			{
				Report.Error("TecladoVirtual - Error launched trying to insert '" + senha + "'");
				throw new System.Exception("ComprarMilhas.TecladoVirtual");
			}
		}
		
		public static void WaitLoad(){
			try {
				Report.Info("Waiting browser load");
				Smiles_UserCode.WaitLoad(repo,30);
				Report.Info("Browser loaded");
			} catch (Exception) {
				Report.Error("ComprarPassagem - Error waiting browser loading");
				throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
			}
		}
		
		public static void SeleclCreditCardFlag(string bandeira){
			try {
				if (bandeira.Equals("")) {
					return;
				}
				Report.Info("Select credit card's flag");
				Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarPassagem_BandeirasInfo.AbsolutePath.ToResolvedString(),"InnerText",bandeira,"1");
				Report.Info("Flag selected");
			} catch (Exception) {
				Report.Error("ComprarPassagem - Error waiting browser loading");
				throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
			}
		}

		public static void SelecionarDiaVencimentoClubeSmiles(string dia)
		{
			try {
				if (dia.Equals("")) {
					return;
				}
				Report.Info("Select credit card's flag");
				Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_DiaVencimentoInfo.AbsolutePath.ToResolvedString(),"TagValue",dia,"1");
				Report.Info("Flag selected");
			} catch (Exception) {
				Report.Error("ComprarPassagem - Error waiting browser loading");
				throw new System.Exception("ComprarComTecladoVirtualClubeSmiles.SelecionarDiaVencimentoClubeSmiles");
			}
		}

		public static void InserirCPF(Ranorex.InputTag repoitem, string cpf)
		{
			try {
				Report.Info("Inserting CPF");
				if (cpf.Equals("ALEATORIO")) {
					setCPF();
					repoitem.PressKeys(randomCPF,Duration.FromMilliseconds(1));
				}else{
					randomCPF = cpf;
					repoitem.PressKeys(cpf,Duration.FromMilliseconds(1));
				}
				Report.Info("CPF inserted");
			} catch (Exception e) {
				Report.Failure("Error launched inserting CPF. Error: " + e.Message);
			}
		}
		public static void SelecionarPlano()
		{
			try {
				Report.Info("Selecionando novo plano");
				repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ButtonMudeJa.Click(Duration.FromMilliseconds(1));
				Report.Info("Plano selecionado");
			} catch (Exception e) {
				Report.Failure("Error launched selecting new plan.");
			}
		}
		public static void SelectVoucher(string voucher)
		{
			try {
				if (voucher.Equals("") || voucher.Equals("N/A") || voucher.Equals("NA")) {
					return;
				}
				Report.Log(ReportLevel.Info, "Select", "Selecting the item " + voucher);
				repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_LinkConferirVouchers.Click(Duration.FromMilliseconds(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.CompraMilhas_Voucher.Click(Duration.FromMilliseconds(1));
				Report.Log(ReportLevel.Info,"Item '" + voucher + "' selected");
			} catch (Exception) {
				Report.Error("ComprarMilhas - Error launched trying to insert voucher '" + voucher + "'");
				throw new System.Exception("ComprarMilhas.SelectVoucher");
			}
		}
		public static void SelectListboxAsUser()
		{
		}
		public static void SelecionarVoo(string identificador)
		{
			try {
				int i = 1;
				Report.Info("Searching fly '" + identificador + "'");
				WebElement element = repo.SmilesOMelhorProgramaDeMilhasS1.ProximosVoos_BotaoExpandirInfo.AbsolutePath.ToResolvedString().Replace("XXX",identificador);
				element.Click(Duration.FromMilliseconds(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_AlterarAssento.Click(Duration.FromMilliseconds(1));
			} catch (Exception e) {
				Report.Error("SelecionarVoo - Error trying to select. Error:" + e.Message);
				throw new System.Exception("SelecionarVoo.SelecionarVoo");
			}
		}

		public static void SelecionarAssento(string tipoAssento, string tipoPagamento)
		{
			try {
				if (tipoAssento.Equals("")) {
					return;
				}
				Report.Info("Selecting chair(s)");
				string chair = "";
				int cont = 1;
				switch (tipoAssento) {
					case "CONFORT":
						chair = "@Class='chair chairComfort'";
						break;
					case "NORMAL":
						chair = "@Class='chair'";
						break;
					case "EMERGENCIA":
						chair = "@Class='chair chairExit'";
						break;
				}
				if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='client-details']",3000)) {
					while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='client-details']/div[@Class='client-info '][" + (cont) +"]",2000)){
						SpanTag e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@Class='client-info '][" + (cont) +"]//span";
						e.RaiseEvent("click");
						Delay.Duration(Duration.FromMilliseconds(1000));
						Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
						PTag p = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[" + chair + "][" + cont +"]//P";
						p.RaiseEvent("click");
						Delay.Duration(Duration.FromMilliseconds(1000));
						Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
						if (tipoPagamento.Equals("Money")) {
							if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[1]/Input",1500)) {
								Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[1]/Input", true);
								Delay.Duration(Duration.FromMilliseconds(1000));
								Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
							}else{
								Report.Warn("You selected '" + tipoPagamento + "', but any option was showed.");
							}
						}else{
							if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[2]/Input",1500)) {
								Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[2]/Input", true);
							}else{
								Report.Warn("You selected '" + tipoPagamento + "', but any option was showed.");
							}
						}
						cont++;
					}
					if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='btnInfoVoo ']",2000)) {
						cont = 1;
						Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='btnInfoVoo ']");
						Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
						if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@Class~'client-info'][" + (cont) +"]",10000)) {
							while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='client-details']/div[@Class='client-info '][" + (cont) +"]",2000)){
								SpanTag e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@Class='client-info '][" + (cont) +"]//span";
								e.RaiseEvent("click");
								Delay.Duration(Duration.FromMilliseconds(1000));
								Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
								PTag p = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[" + chair + "][" + cont +"]//P";
								p.RaiseEvent("click");
								Delay.Duration(Duration.FromMilliseconds(1000));
								Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
								if (tipoPagamento.Equals("Money")) {
									if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[1]/Input",1500)) {
										Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[1]/Input", true);
										Delay.Duration(Duration.FromMilliseconds(1000));
										Smiles_UserCode.WaitSmilesLoadGIF(repo,120);
									}else{
										Report.Warn("You selected '" + tipoPagamento + "', but any option was showed.");
									}
								}else{
									if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[2]/Input",1500)) {
										Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@id~'paymentOptionClient' and @visible='True']//p[2]/Input", true);
									}else{
										Report.Warn("You selected '" + tipoPagamento + "', but any option was showed.");
									}
								}
								cont++;
							}
						}
					}
				}
				Report.Info("Chair(s) selected");
			} catch (Exception e) {
				Report.Error("EscolherAssentos - Error selecting chairs:" + e.Message);
				throw new System.Exception("EscolherAssentos.SelecionarAssento");
			}
		}
		
		public static string taxasDinheiro = "";
		public static string taxasMilhas = "";
		public static void captureData(){
			Report.Info("Capturing data");
			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroInfo.AbsolutePath.ToResolvedString(),1000)) {
				taxasDinheiro = repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiro.Element.GetAttributeValueText("InnerText").Replace("R$","").Trim();
			}
			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasInfo.AbsolutePath.ToResolvedString(),1000)) {
				taxasMilhas = repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhas.Element.GetAttributeValueText("InnerText");
			}
			Report.Info("Data captured");
		}
		public static void SaveDataDB(string identifiacacaoVoo, string numSMiles, string url)
		{
			try {
				if (identifiacacaoVoo.Equals("")) {
					identifiacacaoVoo = POCSmiles.Resultado_Esperado.SalvarDadosExcel.codigoConfimacao;
				}
				Base_Dados.UtilsDB.updateChairSelected(identifiacacaoVoo,numSMiles,url,POCSmiles.Reserva_De_Voo.SelecionarVooAssento.taxasMilhas, POCSmiles.Reserva_De_Voo.SelecionarVooAssento.taxasDinheiro);
			}catch (Exception e) {
				Report.Failure("Database query execution  exception- Error updating user in data base: " + e.Message);
			}
		}
		
		public static void validarReembolso(string numSmiles, string identificacaoVoo, string tipoPagamentoAssento){
			try {
				Report.Info("Validating data on screen");
				//        		double taxasDinheiroReee = double.Parse(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroReembolsar.Element.GetAttributeValueText("InnerText").Replace("R$","").Trim());
				//        		double taxasMilhasRee = double.Parse(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasReembolsar.Element.GetAttributeValueText("InnerText"));
				double taxasDinheiroDB = double.Parse(Base_Dados.UtilsDB.getDataValuePNR(numSmiles,identificacaoVoo,"ASSENTO_TAXAS_DINHEIRO"));
				double taxasMilhasDB = double.Parse(Base_Dados.UtilsDB.getDataValuePNR(numSmiles,identificacaoVoo,"ASSENTO_TAXAS_MILHAS"));
				double valorAtual = double.Parse(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_ValorPagamento.Element.GetAttributeValueText("InnerText").Replace("milhas", "").Replace("R$", "").Trim());
				if (tipoPagamentoAssento.Equals("Smiles")) {
					if (valorAtual >= taxasMilhasDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasInfo.AbsolutePath.ToResolvedString(),"InnerText",(valorAtual - taxasMilhasDB).ToString("N",new CultureInfo("is-IS")).Replace(",00","").Replace(".", ""),1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText","0", 1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
					}
					else if(valorAtual < taxasMilhasDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText",(taxasMilhasDB - valorAtual).ToString("N",new CultureInfo("is-IS")).Replace(",00","").Replace(".", ""),1000)){
							Report.Failure("Error trying to find '" + (taxasMilhasDB - valorAtual) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasInfo.AbsolutePath.ToResolvedString(),"InnerText","0",1000)){
							Report.Failure("Error trying to find '" + (taxasMilhasDB - valorAtual) + "'");
						}
					}
					
					valorAtual = 0;
					
					if (valorAtual >= taxasDinheiroDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroInfo.AbsolutePath.ToResolvedString(),"InnerText",string.Format("{0:C}",(valorAtual - taxasDinheiroDB).ToString()),1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasDinheiroDB) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText","0,00",1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
					}
					else if(valorAtual < taxasDinheiroDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText",string.Format("{0:C}",(taxasDinheiroDB - valorAtual).ToString()),1000)){
							Report.Failure("Error trying to find '" + (taxasDinheiroDB - valorAtual) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroInfo.AbsolutePath.ToResolvedString(),"InnerText","0,00",1000)){
							Report.Failure("Error trying to find '" + (taxasDinheiroDB - valorAtual) + "'");
						}
					}
				}
				else {
					if (valorAtual >= taxasDinheiroDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroInfo.AbsolutePath.ToResolvedString(),"InnerText",string.Format("{0:C}",(valorAtual - taxasDinheiroDB).ToString()),1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasDinheiroDB) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText","0,00",1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
					}
					else if(valorAtual < taxasDinheiroDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText",string.Format("{0:C}",(taxasDinheiroDB - valorAtual).ToString()),1000)){
							Report.Failure("Error trying to find '" + (taxasDinheiroDB - valorAtual) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasDinheiroInfo.AbsolutePath.ToResolvedString(),"InnerText","0,00",1000)){
							Report.Failure("Error trying to find '" + (taxasDinheiroDB - valorAtual) + "'");
						}
					}
					
					valorAtual = 0;
					
					if (valorAtual >= taxasMilhasDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasInfo.AbsolutePath.ToResolvedString(),"InnerText",(valorAtual - taxasMilhasDB).ToString("N",new CultureInfo("is-IS")).Replace(",00","").Replace(".", ""),1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText","0",1000)){
							Report.Failure("Error trying to find '" + (valorAtual - taxasMilhasDB) + "'");
						}
					}
					else if(valorAtual < taxasMilhasDB) {
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasReembolsarInfo.AbsolutePath.ToResolvedString(),"InnerText",(taxasMilhasDB - valorAtual).ToString("N",new CultureInfo("is-IS")).Replace(",00","").Replace(".", ""),1000)){
							Report.Failure("Error trying to find '" + (taxasMilhasDB - valorAtual) + "'");
						}
						if(!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.SelecionarAssento_TaxasMilhasInfo.AbsolutePath.ToResolvedString(),"InnerText","0",1000)){
							Report.Failure("Error trying to find '" + (taxasMilhasDB - valorAtual) + "'");
						}
					}
					
				}
				
				Report.Info("Data on screen validated");
			} catch (Exception e) {
				Report.Failure("Exception launched validating data on screen. Erro: " + e.Message);
			}
		}


	}
	
}

