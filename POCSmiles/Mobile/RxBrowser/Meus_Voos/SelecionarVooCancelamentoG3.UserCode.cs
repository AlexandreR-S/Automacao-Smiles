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

namespace POCSmiles.Mobile.RxBrowser.Meus_Voos
{
    public partial class SelecionarVooCancelamentoG3
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SelecionarQuantosVoosCancelar(string quantidade)
        {
        	try {
        		Report.Info("Selecting flyes to cancel");
        		if(Utils.CheckExist(repo.RxBrowser.Dom.Input_CheckBoxesCancelarVoosInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[1]"),1500)){
					for (int i = 0; i < int.Parse(quantidade);i++ ) {
	        			InputTag input = repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_CheckBoxesCancelarVoosInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + (i + 1) + "]");
	        			input.Click(Duration.FromMilliseconds(1));
	        		}        			
        		}
        		Report.Info("Flyes selected");
        	} catch (Exception e) {
        		Report.Error("SelecionarVooCancelamento - Error trying to select. Error:" + e.Message);
        		throw new System.Exception("SelecionarVooCancelamento.CancelarVoo");
        	}
        }

        public void CancelarVoo(string identificador)
        {
        	try {
        		int i = 1;
        		Report.Info("Searching fly '" + identificador + "'");
        		while(Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_DIvVooInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]"),1000) == true)
        		{
        			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_DIvVooInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]//b[@InnerText='" + identificador.ToUpper() + "']"),1000))
        			{
        				ButtonTag button = repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_DIvVooInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]//button[@innertext~'Cancelar']");
        				button.Click(Duration.FromMilliseconds(1));
        				break;
        			}
        			i++;
        		}
        		Report.Info("Fly '" + identificador + "' identified");
        	} catch (Exception e) {
        		Report.Error("SelecionarVooCancelamento - Error trying to select. Error:" + e.Message);
        		throw new System.Exception("SelecionarVooCancelamento.CancelarVoo");
        	}
        }

    }
}
