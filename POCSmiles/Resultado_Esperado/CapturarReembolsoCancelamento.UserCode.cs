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
    public partial class CapturarReembolsoCancelamento
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public static string milhasEmissaoBilhete;
        public static string milhasTaxaEmbarque;
        public static string milhasMarcacaoAssento;
        public static string milhasExpirarSuaConta;
        public static string milhasReembolsadas;

        public void CapturarDadosReembolso()
        {
        	try {
        		Report.Info("Checking Miles' sum");
        		milhasEmissaoBilhete = repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_EmissaoBilhete.Element.GetAttributeValueText("InnerText").Trim().Replace("Milhas","").Replace(".","").Replace(" ","");
				milhasTaxaEmbarque = repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_TaxaEmbarque.Element.GetAttributeValueText("InnerText").Trim().Replace("Milhas","").Replace(".","").Replace(" ","");
				milhasMarcacaoAssento = repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_MarcacaoAssentos.Element.GetAttributeValueText("InnerText").Trim().Replace("Milhas","").Replace(".","").Replace(" ","");
				milhasExpirarSuaConta = repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_NumeroMilhasExpirar.Element.GetAttributeValueText("InnerText").Trim().Replace("Milhas","").Replace(".","").Replace(" ","");
				milhasReembolsadas = repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_TotalMilhasReembolsar.Element.GetAttributeValueText("InnerText").Trim().Replace("Milhas","").Replace(".","").Replace(" ","");
				string teste = (double.Parse(milhasEmissaoBilhete) + double.Parse(milhasTaxaEmbarque) + double.Parse(milhasMarcacaoAssento) + double.Parse(milhasExpirarSuaConta)).ToString();
				if(!(double.Parse(milhasEmissaoBilhete) + double.Parse(milhasTaxaEmbarque) + double.Parse(milhasMarcacaoAssento) + double.Parse(milhasExpirarSuaConta)).ToString().Equals(milhasReembolsadas)){
					Report.Error("The Miles' sum is wrong '");
				}
				repo.SmilesOMelhorProgramaDeMilhasS1.ReembolsoMilhas_TotalMilhasReembolsar.Element.EnsureVisible();
				Report.Screenshot();
        		Report.Info("Miles sum ok");
        	} catch (Exception e) {
        		Report.Error("CapturarDadosReembolso - Error trying to select. Error:" + e.Message);
        		throw new System.Exception("SelecionarVooCancelamento.CapturarDadosReembolso");
        	}
        }

    }
}