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
    public partial class IniciarDesktop
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void Begin(string browser, string url)
        {
        	try {
        		bool inc = bool.Parse(Utils.getGlobalValue("INCOGNITION_MODE"));
        		InitSetup.inicioExecucao = System.DateTime.Now;
	        			Report.Log(ReportLevel.Info,"Ending session and starting '" + url + "' on browser '" + browser + "'");
	        			if (Utils.CheckExist(repo.Windows.ModalDialogInfo.AbsolutePath.ToResolvedString(),1000)) {
	        				repo.Windows.ModalDialog.Click(Location.Center,Duration.FromMilliseconds(1));
	        			}
	        			if (!Utils.getGlobalValue("AMBIENTE_TESTE").ToUpper().Equals("")) {
							url = Utils.getGlobalValue("AMBIENTE_TESTE");
							URL = Utils.getGlobalValue("AMBIENTE_TESTE").Replace("www.","").Replace("http://","").Replace("https://","");//.Replace("/login","");
						}
	        			End(true, url);
	        			Host.Local.OpenBrowser(url,browser,"",false,true,false,inc,false);
	        			while (!Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Smiles_logoInfo.AbsolutePath.ToResolvedString(),20000)) {
	        				InitSetup.gravarTempo = false;
	        				Report.Log(ReportLevel.Info, "Waiting", "Waiting system returns.");
	        				Report.Info("Aguaradando sistema normalizar. 10 segundos para nova tentativa.");
	        				Delay.Duration(Duration.FromMilliseconds(10000));
	        				Report.Log(ReportLevel.Info,"Ending session and starting '" + url + "' on browser '" + browser + "'");
		        			if (Utils.CheckExist(repo.Windows.ModalDialogInfo.AbsolutePath.ToResolvedString(),1000)) {
		        				repo.Windows.ModalDialog.Click(Location.Center,Duration.FromMilliseconds(1));
		        			}
		        			End(true, url);
		        			Host.Local.OpenBrowser(url,browser,"",false,true,false,inc,false);
	        			}
	        			return;
        	} 
        	catch (Exception e) {
        		Report.Error("IniciarDesktop - Error starting system. Error:" + e.Message);
        		throw new System.Exception("IniciarDesktop.Begin");
        	}
        }
        
        public void End(bool closeBrowser, string url)
        {
        	try {
	        	if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_BotaoFecharErrosInfo.AbsolutePath.ToResolvedString(),500)) 
	        	{
	        		repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_BotaoFecharErros.Click(Duration.FromMilliseconds(1));
	        	}
	        	if(Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_ExpandirOpcoesUsuarioInfo.AbsolutePath.ToResolvedString(),500))
	        	{
	        		repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_ExpandirOpcoesUsuario.Click(Duration.FromMilliseconds(1));
	        		repo.SmilesOMelhorProgramaDeMilhasS1.MenuUsuario_Logout.Click(Duration.FromMilliseconds(1));
		        	Smiles_UserCode.WaitLoad(repo,30);
	        	}
	        	if (closeBrowser == true) 
	        	{
	        		
	        		if (Utils.CheckExist("/form[@title>'Smiles']",750)) {
	        			Host.Local.CloseApplication("/form[@title>'Smiles']",Duration.FromMilliseconds(3000));
	        			Delay.Seconds(1);
	        		}
	        		if (Utils.CheckExist("/form[@title>'Smiles']",750)) {
	        			Host.Local.CloseApplication("/form[@title>'Smiles']",Duration.FromMilliseconds(3000));
	        			Delay.Seconds(1);
	        		}
	        		if (Utils.CheckExist("/form[@title>'Smiles']",750)){
	        			Host.Local.CloseApplication("/form[@title>'Smiles']",Duration.FromMilliseconds(3000));
	        			Delay.Seconds(1);
	        		}
	        		if (Utils.CheckExist("/form[@ProcessName='chrome' or @ProcessName='iexplore' or @ProcessName='firefox'and @Visible='true'][1]",750)) {
	        			Host.Local.CloseApplication("/form[@ProcessName='chrome' or @ProcessName='iexplore' or @ProcessName='firefox'and @Visible='true'][1]",Duration.FromMilliseconds(3000));
	        			Delay.Seconds(1);
	        		}
	        	}	
        	} catch (Exception) {
        		throw new System.Exception("IniciarDesktop.End");
        	}
        }

        public void StartErrorVerifier()
        {
        	Thread tErrorV = new Thread(errorVerificator);
			tErrorV.IsBackground = true;
			tErrorV.SetApartmentState(ApartmentState.STA);
			tErrorV.Start();
        }
        
        public static void errorVerificator(){
    		while (true) {
        		if (repo.SmilesOMelhorProgramaDeMilhasS1.ErrorMessage_GenericInfo.Exists(Duration.FromMilliseconds(5000))) {
        			Report.Screenshot();
        			Ranorex.Validate.Fail("An error message was showed until test execution.");
        		}
    		}
        }

        public void ClickIfExist()
        {
        	if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Home_BannerInfo.AbsolutePath.ToResolvedString(),3000)) {
        		repo.SmilesOMelhorProgramaDeMilhasS1.Home_CloseBanner.Click(Duration.FromMilliseconds(1));
        	}
        }

    }
}