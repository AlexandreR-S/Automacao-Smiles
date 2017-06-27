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

namespace POCSmiles.Reserva_De_Voo
{
    public partial class ReservarVooSemCobrancaGateway
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void WaitLoad()
        {
        	try {
        		Report.Info("Waiting browser load");
        		Smiles_UserCode.WaitLoad(repo,20);
        		Report.Info("Browser loaded");
        	} catch (Exception) {
        		Report.Error("ComprarPassagem - Error waiting browser loading");
        		throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
        	}
        }

        public void setReserva()
        {
        	POCSmiles.Resultado_Esperado.SalvarDadosExcel.vooReservado = "true";
        }

        public void WaitSmilesLoad()
        {
        	try {
        		Report.Info("Waiting Smiles' loading GIF");
        		Smiles_UserCode.WaitSmilesLoadGIF(repo,90);
        		Report.Info("Smiles' loading GIF desapeared");
        	} catch (Exception) {
        		Report.Error("ComprarPassagem - Error waiting browser loading");
        		throw new System.Exception("ComprarPassagem.WaitSmilesLoad");
        	}
        }

        public void InserirTecladoVirtual(string senha)
        {
        	try 
        	{
        		Report.Log(ReportLevel.Info,"Inserting password '" + senha + "'");
        		foreach(char c in senha.ToCharArray()){
        			Utils.ClickElement(repo.SmilesOMelhorProgramaDeMilhasS1.Pagamento_SenhaPrimeiroDigitoInfo.AbsolutePath.ToResolvedString().Replace("0",c.ToString()));
        		}
        		Report.Log(ReportLevel.Info,"Password '" + senha + "' inserted");
        	} catch (Exception) 
        	{
        		Report.Error("TecladoVirtual - Error launched trying to insert '" + senha + "'");
        		throw new System.Exception("PagamentoComTecladoVirtual.TecladoVirtual");
        	}
        }

    }
}