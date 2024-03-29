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
    public partial class RP_ReservaVoo
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ExpectedResult()
        {
        	bool flag = Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.MeusVoos_ListaVoosReservadosInfo.AbsolutePath.ToResolvedString(),"InnerText",SalvarDadosExcel.codigoConfimacao,10000, true);
        	if(!flag){
        		Report.Error("RP_ReservaVoo - Erro lançado em resultado esperado. Não foi possível localizar a reserva:" + SalvarDadosExcel.codigoConfimacao);
        		throw new System.Exception("RP_ReservaVoo.ExpectedResult");
        	}
        }

        public void AtualizarDadosBD(string numSmiles, string url)
        {
        	try {
        		Base_Dados.UtilsDB.updateNumReserva(numSmiles, url);
        	}catch (Exception e) {
        		Report.Error("Database query execution  exception- Error updating user in data base: " + e.Message);	
        	}
        }

    }
}