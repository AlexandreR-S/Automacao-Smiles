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

namespace POCSmiles.Compra_De_Milhas
{
    public partial class ComprarMilhas
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SelectItemListBox(string selectTagElement, string itemName)
        {
            try 
        	{
        		if(itemName.Equals("")){
        			return;
        		}
        		Report.Log(ReportLevel.Info, "Select", "Selecting the item " + itemName);
        		Utils.SelectItemListBox(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + selectTagElement, itemName);	
        		Report.Log(ReportLevel.Info,"Item '" + itemName + "' selected");
        	} catch (Exception) 
        	{
        		Report.Error("CadastrarUsuario - Error launched trying to select item '" + itemName + "' on element '" + selectTagElement + "'");
        		throw new System.Exception("CadastrarUsuario.SeletItemListBox");
            }
        }

        public void SelectVoucher(string voucher)
        {
        	try {
        		if (voucher.Equals("") || voucher.Equals("N/A") || voucher.Equals("NA")) {
        			return;
        		}
        		Report.Log(ReportLevel.Info, "Select", "Selecting the item " + voucher);
        		repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_LinkConferirVouchers.Click(Duration.FromMilliseconds(1));
        		int i = 1;
        		while(Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ListaVouchersInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]"),1000) == true)
        		{
        			if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ListaVouchersInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]//li[@InnerText~'" + voucher + "']"),2000))
        			{
        				ButtonTag button = repo.SmilesOMelhorProgramaDeMilhasS1.ComprarMilhas_ListaVouchersInfo.AbsolutePath.ToResolvedString().Replace("['xxx']", "[" + i + "]//button[1]");
        				button.EnsureVisible();
        				button.Click(Duration.FromMilliseconds(1));
        				break;
        			}
        			i++;
        		}
        		Report.Log(ReportLevel.Info,"Item '" + voucher + "' selected");
        	} catch (Exception) {
        		Report.Error("ComprarMilhas - Error launched trying to insert voucher '" + voucher + "'");
        		throw new System.Exception("ComprarMilhas.SelectVoucher");
        	}
        }

    }
}