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

namespace POCSmiles.Comprar
{
    public partial class ComprarComTecladoVirtual
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

		private void SelectItemListBox(string selectTagElement, string itemName){
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
        		Report.Error("BuscarVoos - Error launched trying to select item '" + itemName + "' on element '" + selectTagElement + "'");
        		throw new System.Exception("BuscarVoos.SeletItemListBox");
        	}
        }
        
        private void InserirTecladoVirtual(string senha){
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
        
        private void TypeKeys(string element, string text){
        	try 
        	{
        		if (text.Equals("")) {
        			return;
        		}
        		Report.Log(ReportLevel.Info,"Inserting text '" + text + "'");
        		InputTag input = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + element;
        		input.PressKeys(text,Duration.FromMilliseconds(1));
        		Report.Log(ReportLevel.Info,"Text inserted '" + text + "'");
        	} catch (Exception) 
        	{
        		Report.Error("ComprarPassagem - Error launched trying to inserting text '" + text + "' on element '" + element + "'");
        		throw new System.Exception("ComprarPassagem.TypeKeys");
        	}
        }
        
         private void WaitSmilesLoad(){
        	try {
        		Report.Info("Waiting Smiles' loading GIF");
        		Smiles_UserCode.WaitSmilesLoadGIF(repo,6);
        		Report.Info("Smiles' loading GIF desapeared");
        	} catch (Exception) {
        		Report.Error("ComprarPassagem - Error waiting browser loading");
        		throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
        	}
        }
        
        private void WaitLoad(){
        	try {
        		Report.Info("Waiting browser load");
        		Smiles_UserCode.WaitLoad(repo,20);
        		Report.Info("Browser loaded");
        	} catch (Exception) {
        		Report.Error("ComprarPassagem - Error waiting browser loading");
        		throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
        	}
        }
        
        private void SeleclCreditCardFlag(string bandeira){
        	try {
        		if (bandeira.Equals("")) {
        			return;
        		}
        		Report.Info("Select credit card's flag");
        		Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarPassagem_BandeirasInfo.AbsolutePath.ToResolvedString(),"InnerText",bandeira,"1");
        		Report.Info("Flag selected");
        	} catch (Exception) {
        		Report.Screenshot();
        		Keyboard.Press("{NEXT}");
        		Report.Error("ComprarPassagem - Error selecting credit card's flag");
        		throw new System.Exception("CompraCOmTecladoVirtual.SeleclCreditCardFlag");
        	}
        }

    }
}