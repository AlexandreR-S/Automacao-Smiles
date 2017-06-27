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
    public partial class RP_PainelMinhaConta
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidacaoMinhaConta()
        {
        	try {
        		Report.Info("Validating account details");
				if (Utils.CheckExist(repo.SmilesOMelhorProgramaDeMilhasS1.ClubeSmiles_ValidacaoMinhaContaInfo.AbsolutePath.ToResolvedString(), 3000)) {
        			Validate.CompareImage(repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo,MinhaConta_BotaoImprimirCartao_PainelClube,MinhaConta_BotaoImprimirCartao_PainelClube_Options);
        		}
        		else{
        			Validate.CompareImage(repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo, MinhaConta_BotaoImprimirCartao_PainelNaoClube, MinhaConta_BotaoImprimirCartao_PainelNaoClube_Options);
        		}
        		Report.Info("Account validated");
        	} catch (Exception e) {
        		Report.Failure("Error launched validating account details. Error: " + e.Message);
        	}
        }
        
        #region Image Feature Data
        CompressedImage MinhaConta_BotaoImprimirCartao_PainelClube
        { get { return repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo.GetPainelClube(new Rectangle(0, 0, 97, 152)); } }

        Imaging.FindOptions MinhaConta_BotaoImprimirCartao_PainelClube_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,97,152;True;10000000;0ms"); } }

        CompressedImage MinhaConta_BotaoImprimirCartao_PainelNaoClube
        { get { return repo.SmilesOMelhorProgramaDeMilhasS1.MinhaConta_BotaoImprimirCartaoInfo.GetPainelNaoClube(new Rectangle(0, 0, 97, 152)); } }

        Imaging.FindOptions MinhaConta_BotaoImprimirCartao_PainelNaoClube_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,97,152;True;10000000;0ms"); } }

#endregion

    }
}