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

namespace POCSmiles.Resultado_Esperado
{
    public partial class RP_InserirPassageirosGateway
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
		private void FocusModalMenssage()
        {
			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_CaixaMensagemInfo.AbsolutePath.ToResolvedString(),1000)) {
        	    	Report.Screenshot(repo.SmilesOMelhorProgramaDeMilhasS1.Mensagem_CaixaMensagem);
        	}
        }

        public void CaptureFlyDetails()
        {
        	try {
        		Report.Info("Capturing fly details");
        		if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.DetalhesVoo_Expandir2Info.AbsolutePath.ToResolvedString(),3000)) {
        			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][1]",3000)) {
        				int i = 1;
        				while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][1]/div[@class='plane'][" + i +"]",2000)) {
        					WebElement e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][1]/div[@class='flying-company'][" + i +"]/p/span[1]";	
        					InitSetup.detalhesVooIda += 	e.Element.GetAttributeValueText("InnerText");
        					
        					e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() +  "//div[@class='flight-details'][1]/p[@class='smls-txt-right'][" + i +"]/span[1]";
        					InitSetup.detalhesVooIda += "(" + e.Element.GetAttributeValueText("InnerText") + " - ";
        					
        					e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() +  "//div[@class='flight-details'][1]/p[@class='smls-txt-left'][" + i +"]/span[1]";
        					InitSetup.detalhesVooIda += e.Element.GetAttributeValueText("InnerText") + ")";
        					
        					i++;
        				}
        			}
        			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][2]",3000)) {
        				int i = 1;
        				while (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][2]/div[@class='plane'][" + i +"]",2000)) {
        					WebElement e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + "//div[@class='flight-details'][2]/div[@class='flying-company'][" + i +"]/p/span[1]";	
        					InitSetup.detalhesVooVolta += 	e.Element.GetAttributeValueText("InnerText");
        					
        					e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() +  "//div[@class='flight-details'][2]/p[@class='smls-txt-right'][" + i +"]/span[1]";
        					InitSetup.detalhesVooVolta += "(" + e.Element.GetAttributeValueText("InnerText") + " - ";
        					
        					e = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() +  "//div[@class='flight-details'][2]/p[@class='smls-txt-left'][" + i +"]/span[1]";
        					InitSetup.detalhesVooVolta += e.Element.GetAttributeValueText("InnerText") + ")";
        					
        					i++;
        				}
        			}
        		}
        		Report.Info("Fly details captured");
        	} catch (Exception) {
        		Report.Error("Erro trying to capture fly details");
        	}
        }
    }
}