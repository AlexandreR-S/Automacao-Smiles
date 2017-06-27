/*
 * Created by Ranorex
 * User: welli
 * Date: 01/02/2016
 * Time: 21:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using POCSmiles.AtendimentoOnline;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace POCSmiles
{
    /// <summary>
    /// Description of Smiles_UserCode.
    /// </summary>
    [TestModule("F01E8AEF-32BA-41A1-8926-FF2B6CC5D959", ModuleType.UserCode, 1)]
    public class Smiles_UserCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Smiles_UserCode()
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
        public static void SetCalendarDate(string date, SmilesRepository repo)
        {
           	var currCultureInfo = CultureInfo.CreateSpecificCulture("pt-br");
            WebElement calendarSmiles = repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_MesAtualInfo.AbsolutePath.ToResolvedString() + "//tbody[1]//td[@class!~'ui-state-disabled'][1]";
            System.DateTime dateParam = System.DateTime.Parse(date);
            System.DateTime dateToday = System.DateTime.Parse("01/" + (int.Parse(calendarSmiles.Element.GetAttributeValueText("data-month")) + 1) + "/" + calendarSmiles.Element.GetAttributeValueText("data-year") + " 00:00:00", currCultureInfo);
            System.TimeSpan hoursDif = dateParam.Subtract(dateToday);
            if (dateToday.Month + 1 == dateParam.Month) {
        		Utils.ClickTextDataTable(repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_MesPosteriorInfo.AbsolutePath.ToResolvedString(),dateParam.Day.ToString(),"1");
        		return;
        	}
            if (!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_MesAtualCabecalhoInfo.AbsolutePath.ToResolvedString(),"innertext",getMonthName(dateParam.Month - 1),1000)) 
            {
				int monthDif = dateParam.Month - dateToday.Month;
				int yearDif = dateParam.Year - dateToday.Year;
				if (yearDif > 0) {
					monthDif = hoursDif.Days/System.DateTime.DaysInMonth(dateToday.Year,dateToday.Month);
					for (int i = 0; i < monthDif; i++) 
		            {
		        		repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_Proximo.Click(Location.CenterLeft, Duration.FromMilliseconds(1));
		        	}
				}
				else{
					if (monthDif > 0)
			        {
			        	for (int i = 0; i < monthDif; i++) 
			            {
			        		repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_Proximo.Click(Location.CenterLeft, Duration.FromMilliseconds(1));
			        	}
			        }
			        if (monthDif < 0) 
			        {
		        		for (int i = 0; i > monthDif; i--) 
			            {
			            	repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_Anterior.Click(Location.CenterLeft, Duration.FromMilliseconds(1));
			        	}
			        }						
				}
            }
            if (dateToday.Month + 1 == dateParam.Month) {
        		Utils.ClickTextDataTable(repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_MesPosteriorInfo.AbsolutePath.ToResolvedString(),dateParam.Day.ToString(),"1");
        	}
            Utils.ClickTextDataTable(repo.SmilesOMelhorProgramaDeMilhasS1.Calendario_MesAtualInfo.AbsolutePath.ToResolvedString(),dateParam.Day.ToString(),"1");
        }
        
        public static Text SetCalendarDateMobile(string date, SmilesRepository repo)
        {
           	var currCultureInfo = CultureInfo.CreateSpecificCulture("pt-br");
            System.DateTime dateParam = System.DateTime.Parse(date);
            System.DateTime dateToday = System.DateTime.Parse("01/" + getMonthIndex(repo.AppSmiles.DateChoice.MesAtual.Element.GetAttributeValueText("Text").Split(" ".ToCharArray()[0])[0].Trim()).ToUpper() + "/" + repo.AppSmiles.DateChoice.MesAtual.Element.GetAttributeValueText("Text").Split(" ".ToCharArray()[0])[1].Trim() + " 00:00:00", currCultureInfo);
            System.TimeSpan hoursDif = dateParam.Subtract(dateToday);
            
			int monthDif;
			int yearDif = dateParam.Year - dateToday.Year;
			if (yearDif > 0) {
				monthDif = hoursDif.Days/System.DateTime.DaysInMonth(dateToday.Year,dateToday.Month);
			}
			else{
				monthDif = dateParam.Month - dateToday.Month;
			}
			
			Text t;
			if (dateParam.Day >= 15) {
				t = repo.AppSmiles.DateChoice.MesDesejadoInfo.AbsolutePath.ToResolvedString().Replace("'mes'",(monthDif + 1).ToString()).Replace("'dia'",dateParam.Day.ToString()).Replace("'index'","1");
			}else{
				if (Utils.CheckExist(repo.AppSmiles.DateChoice.MesDesejadoInfo.AbsolutePath.ToResolvedString().Replace("'mes'",(monthDif + 1).ToString()).Replace("'dia'",dateParam.Day.ToString()).Replace("'index'","2"),2000)) {
					t = repo.AppSmiles.DateChoice.MesDesejadoInfo.AbsolutePath.ToResolvedString().Replace("'mes'",(monthDif + 1).ToString()).Replace("'dia'",dateParam.Day.ToString()).Replace("'index'","2");
				}else{
					t = repo.AppSmiles.DateChoice.MesDesejadoInfo.AbsolutePath.ToResolvedString().Replace("'mes'",(monthDif + 1).ToString()).Replace("'dia'",dateParam.Day.ToString()).Replace("'index'","1");
				}
			}
			
			return t;
        }
        
        private static string getMonthName(int monthIndex){
   			 String[] monthNames = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", 
                      "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
    		return monthNames[monthIndex];
		}
        
        private static string getMonthIndex(string monthName){

        	Dictionary <string, string> myDic = new Dictionary<string, string>();
        	myDic.Add("Janeiro".ToUpper(),"01");
        	myDic.Add("Fevereiro".ToUpper(),"02");
        	myDic.Add("Março".ToUpper(),"03");
        	myDic.Add("Abril".ToUpper(),"04");
        	myDic.Add("Maio".ToUpper(),"05");
        	myDic.Add("Junho".ToUpper(),"06");
        	myDic.Add("Julho".ToUpper(),"07");
        	myDic.Add("Agosto".ToUpper(),"08");
        	myDic.Add("Setembro".ToUpper(),"09");
        	myDic.Add("Outubro".ToUpper(),"10");
        	myDic.Add("Novembro".ToUpper(),"11");
        	myDic.Add("Dezembro".ToUpper(),"12");
        	return myDic[monthName];
		}
        
        public static void WaitLoad(SmilesRepository repo, int timeoutSec)
        {
            if(Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString(),5000))
            {
            	WebDocument smiles = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString();
            	smiles.WaitForDocumentLoaded(Duration.FromMilliseconds(timeoutSec * 1000));
            }
        }
    
	    public static void SelectFlyPayment(SmilesRepository repo, string route,string type, string linha)
	    {
	            InputTag element;
	            
	            if (route.Equals("IDA")) 
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Smiles & Money":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		string t = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Clube Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaSmilesClubeInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Tooltip":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.IdaTooltipInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	}	
	            }
	            else if (route.Equals("VOLTA"))
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.VoltaSmilesPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Smiles & Money":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.VoltaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Clube Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.VoltaSmilesClubeInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Tooltip":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.VoltaTooltipInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	}	
	            }
	            else if (route.Equals(""))
	            {
	            	repo.SmilesOMelhorProgramaDeMilhasS1.FlightsArea.Tooltip.Click(Duration.FromMilliseconds(1));
	            }
	        }
	    public static void SelectFlyPaymentNew(SmilesRepository repo, string route,string type, string linha)
	    {
	            InputTag element;
	            
	            if (route.Equals("IDA")) 
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.IdaSmilesPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Smiles & Money":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.IdaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		string t = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.IdaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Clube Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.IdaSmilesClubeInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Tooltip":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.IdaTooltipInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	}	
	            }
	            else if (route.Equals("VOLTA"))
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.VoltaSmilesPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Smiles & Money":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.VoltaSmilesMoneyPaymentInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Clube Smiles":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.VoltaSmilesClubeInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	case "Tooltip":
	            		element = repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.VoltaTooltipInfo.AbsolutePath.ToResolvedString().Replace("xxx", linha);
	            		element.Click(Duration.FromMilliseconds(1));
	            		break;
	            	}	
	            }
	            else if (route.Equals(""))
	            {
	            	repo.SmilesOMelhorProgramaDeMilhasS1.FlightsAreaGateway.Tooltip.Click(Duration.FromMilliseconds(1));
	            }
	        }
	    
	    public static void SelectFlyPaymentMobile(SmilesRepository repo, string route,string type)
	    {
	            InputTag element;
	            
	            if (route.Equals("IDA")) 
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		repo.RxBrowser.Dom.Input_IdaOpcaoPagamentoSmiles.Touch();
	            		break;
	            	case "Smiles & Money":
	            		repo.RxBrowser.Dom.Input_IdaOpcaoPagamentoSmilesEMoney.Touch();
	            		break;
	            	case "Clube Smiles":
	            		repo.RxBrowser.Dom.Input_IdaOpcaoPagamentoToolTip.Touch();
	            		break;
	            	case "Tooltip":
	            		repo.RxBrowser.Dom.Input_IdaOpcaoPagamentoToolTip.Touch();
	            		break;
	            	}	
	            }
	            else if (route.Equals("VOLTA"))
	            {
	            	switch (type) 
	            	{
	            	case "Smiles":
	            		repo.RxBrowser.Dom.Input_VoltaOpcaoPagamentoSmiles.Touch();
	            		break;
	            	case "Smiles & Money":
	            		repo.RxBrowser.Dom.Input_VoltaOpcaoPagamentoSmilesEMoney.Touch();
	            		break;
	            	case "Clube Smiles":
	            		repo.RxBrowser.Dom.Input_VoltaOpcaoPagamentoToolTip.Touch();
	            		break;
	            	case "Tooltip":
	            		repo.RxBrowser.Dom.Input_VoltaOpcaoPagamentoToolTip.Touch();
	            		break;
	            	}
	            }
	            else if (route.Equals(""))
	            {
	            	repo.RxBrowser.Dom.Input_VoltaOpcaoPagamentoToolTip.Touch();
	            }
	    }
	    public static void WaitSmilesLoadGIF(SmilesRepository repo, int timeoutSec)
	    {
	    	int cont = 0;
	    	timeoutSec = timeoutSec * 1000;
	    	
	    	while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_LoadingGIFInfo.AbsolutePath.ToResolvedString(),350))
	    	{
	    		if (cont == timeoutSec) 
	    		{
	    			return;
	    		}
	    		cont++;
	    	}
	    	 cont = 0;
	    	while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_LoadingGIF2Info.AbsolutePath.ToResolvedString(),350))
	    	{
	    		if (cont == timeoutSec) 
	    		{
	    			return;
	    		}
	    		cont++;
	    	}
	    	 cont = 0;
	    	while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_AguardeInfo.AbsolutePath.ToResolvedString(),350))
	    	{
	    		if (cont == timeoutSec) 
	    		{
	    			return;
	    		}
	    		cont++;
	    	}
	    	

	    }
	    
	    public static void WaitSmilesLoadGIFMobile(SmilesRepository repo, int timeoutSec)
	    {
	    	int cont = 0;
	    	timeoutSec = timeoutSec * 1000;
	    	
	    	cont = 0;
	    	while (Utils.CheckExist(repo.RxBrowser.Dom.P_AguardeInfo.AbsolutePath.ToResolvedString(),1000))
	    	{
	    		if (cont == timeoutSec) 
	    		{
	    			return;
	    		}
	    		cont++;
	    	}
	    	

	    }
	    public static void AtualizarMilhasBD(string CPFSmilesID, string URL, SmilesRepository repo)
        {
	    	if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Login_MilhasInfo.AbsolutePath.ToResolvedString(),1000)) {
	    		if (!repo.SmilesOMelhorProgramaDeMilhasS1.Login_Milhas.Element.GetAttributeValueText("InnerText").Replace("milhas","").Replace(".","").Trim().Equals("0")) {
	    			Base_Dados.UtilsDB.updateMilhas(CPFSmilesID, URL, repo.SmilesOMelhorProgramaDeMilhasS1.Login_Milhas.Element.GetAttributeValueText("InnerText").Replace("milhas","").Replace(".","").Trim());
	    		}
    		}
        }
	    public static void AtualizarMilhasBDMobile(string CPFSmilesID, string URL, SmilesRepository repo)
        {
	    	if (Utils.CheckExist(repo.RxBrowser.Dom.Span_SaldoMilhasLoginInfo.AbsolutePath.ToResolvedString(),1000)) {
	    		if (!repo.RxBrowser.Dom.Span_SaldoMilhasLogin.Element.GetAttributeValueText("InnerText").Replace("milhas","").Replace(".","").Trim().Equals("0")) {
	    			Base_Dados.UtilsDB.updateMilhas(CPFSmilesID, URL, repo.RxBrowser.Dom.Span_SaldoMilhasLogin.Element.GetAttributeValueText("InnerText").Replace("milhas","").Replace(".","").Trim());
	    		}
    		}
        }
	    
	    public static string captureFlyCode(SmilesRepository repo){
	    	return repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_CodigoEmissao.Element.GetAttributeValueText("InnerText").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA:","").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA : ","").Replace("IDA:","").Replace("IDA :","").Trim();
	    }
	    public static string capturePedido(SmilesRepository repo){
	    	return repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_NPedido.Element.GetAttributeValueText("InnerText").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA:","").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA : ","").Replace("IDA:","").Replace("IDA :","").Trim();
	    }
	    public static string captureLocalizador(SmilesRepository repo){
	    	return repo.SmilesOMelhorProgramaDeMilhasS1.PValidacao_Localizador.Element.GetAttributeValueText("InnerText").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA:","").Replace("CÓDIGO DE CONFIRMAÇÃO DA RESERVA : ","").Replace("IDA:","").Replace("IDA :","").Trim();
	    }
	    
	    public static string captureOrderInURL(SmilesRepository repo){
	    	Regex rgx = new Regex(".*orderId=");
	    	return rgx.Replace(repo.SmilesOMelhorProgramaDeMilhasS1.Self.Element.GetAttributeValueText("PageUrl").Trim(),"");
	    }
	    
	    public static void anexarArquivo(string webElement, string diretorio, SmilesRepository repo){
	    	WebElement element = webElement;
	    	element.Focus();
	    	element.Click(Duration.FromMilliseconds(1));
	    	repo.Windows.DiretorioSelecaoArquivoInfo.WaitForExists(10000);
	    	repo.Windows.DiretorioSelecaoArquivo.PressKeys(diretorio,Duration.FromMilliseconds(1));
	    	Delay.Duration(Duration.FromMilliseconds(1000));
	    	Keyboard.Press("{RETURN}");
	    	if (Utils.CheckExist(repo.Windows.DiretorioSelecaoArquivoInfo.AbsolutePath.ToResolvedString(),1000)) {
	    		Keyboard.Press("{RETURN}");	
	    	}
	    	if (Utils.CheckExist(repo.Windows.DiretorioSelecaoArquivoInfo.AbsolutePath.ToResolvedString(),1000)) {
	    		Keyboard.Press("{RETURN}");	
	    	}
	    }
    }
}
