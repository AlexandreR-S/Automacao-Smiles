/*
 * Created by Ranorex
 * User: welli
 * Date: 18/11/2016
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POCSmiles.Base_Dados;
using System.Reflection;
using Word;

namespace POCSmiles
{
	/// <summary>
	/// Description of FormProgress.
	/// </summary>
	 public partial class FormProgresso : Form
    {
        public FormProgresso()
        {
            InitializeComponent();
        }
        [STAThread]
        public void initForm(){
        	
			SetControlPropertyValue(textBoxTermino,"Text","Processando...");
			SetControlPropertyValue(textBoxinicio,"Text",System.DateTime.Now.ToString());
			SetControlPropertyValue(textBoxSuitesTeste,"Text","Processando...");
			SetControlPropertyValue(textBoxCasosTeste,"Text","Processando...");
        }
        
        public static bool keepT = true;
        
        public void fecharForm(){
			this.Invoke(new MethodInvoker(delegate { this.Close(); }));
        }
        public void incrementProgress(int valueToIncrement){
			progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.Increment(valueToIncrement); }));
			SetControlPropertyValue(labelProgressBar,"Text",((int)(100*progressBar1.Value)/progressBar1.Maximum) + "%");
			SetControlPropertyValue(textBoxCasosTeste,"Text",(progressBar1.Value + 1) + " / " + progressBar1.Maximum);
        }
        
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
        
        public void processarEstimativa(){
            List<string> tcases = new List<string>();      //all testcases in this testsuite
			int i = 0;
			int allRows = 0;
			int tempoTotal = 0;
			var rconf = Ranorex.Core.Testing.TestSuite.Current.SelectedRunConfig.GetActiveTestCases();
			for (i =0; i< rconf.Count; i++){
				if (!rconf.ElementAt(i).DisplayName.Equals("Smiles - Test Suite") && !rconf.ElementAt(i).DisplayName.Equals("INIT_SMILES")) {
					rconf.ElementAt(i).DataContext.ReloadData();
					tcases.Add(rconf.ElementAt(i).DisplayName);
					if (!rconf.ElementAt(i).IsDataRangeActive) {
						allRows = allRows + rconf.ElementAt(i).DataContext.Source.Rows.Count;
						if (UtilsDB.checkExist("SELECT * FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE'" + rconf.ElementAt(i).DisplayName.Trim() + "'")) {
							if (!Utils.getGlobalValue("BROWSER").Equals("")) {
								tempoTotal = tempoTotal + (UtilsDB.getMediaTempo(rconf.ElementAt(i).DisplayName.Trim()));
							}else{
								tempoTotal = tempoTotal + (UtilsDB.getMediaTempo(rconf.ElementAt(i).DisplayName.Trim()) * rconf.ElementAt(i).DataContext.Source.Rows.Count);
							}
						}
						else{
							if (!Utils.getGlobalValue("BROWSER").Equals("")) {
								tempoTotal = tempoTotal + 180000;
							}else{
								tempoTotal = tempoTotal + (180000 * rconf.ElementAt(i).DataContext.Source.Rows.Count);
							}
						}
					}else{
						allRows = allRows + rconf.ElementAt(i).GetRangedDataRowCount();
						if (UtilsDB.checkExist("SELECT * FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE'" + rconf.ElementAt(i).DisplayName.Trim() + "'")) {
							tempoTotal = tempoTotal + (UtilsDB.getMediaTempo(rconf.ElementAt(i).DisplayName.Trim()) * rconf.ElementAt(i).GetRangedDataRowCount());
						}else{
							tempoTotal = tempoTotal + (180000 * rconf.ElementAt(i).GetRangedDataRowCount());
						}
					}
				}
			}
			SetControlPropertyValue(textBoxSuitesTeste,"Text",(tcases.Count).ToString());
			if (!Utils.getGlobalValue("BROWSER").Equals("")) {
				SetControlPropertyValue(textBoxCasosTeste,"Text","1 / " + (SelecaoBrowser.contTests).ToString());
				SetControlPropertyValue(progressBar1,"Maximum",SelecaoBrowser.contTests);
			}
			else{
				SetControlPropertyValue(textBoxCasosTeste,"Text","1 / " + allRows.ToString());
				SetControlPropertyValue(progressBar1,"Maximum",allRows);
			}
				SetControlPropertyValue(textBoxTermino,"Text",System.DateTime.Now.AddMilliseconds(tempoTotal).ToString());
        }
        
        public void recalcEstimativa(string casoTeste, int tempoAtual){
        	int media = UtilsDB.getMediaTempo(casoTeste);
        	DateTime termino = DateTime.Parse(textBoxTermino.Text);
        	var rconf = ((Ranorex.Core.Testing.TestCaseNode)Ranorex.Core.Testing.TestSuite.Current.GetTestCase(casoTeste));
        	int rows = 0;	
        		
        	if (!rconf.IsDataRangeActive) {
        		rows = rconf.DataContext.Source.Rows.Count() - rconf.DataContext.CurrentRowIndex;
			}else{
				rows = rconf.GetRangedDataRowCount() - rconf.DataContext.CurrentRowIndex;
			}	
        	if (media > tempoAtual) {
        		SetControlPropertyValue(textBoxTermino,"Text",termino.Subtract(TimeSpan.FromMilliseconds(((media - tempoAtual) * rows) + (media - tempoAtual))).ToString());
        	}else{
        		SetControlPropertyValue(textBoxTermino,"Text",termino.AddMilliseconds(((tempoAtual - media) * rows) + (tempoAtual - media)).ToString());
        	}
        }
        
        public void aumentarTempoTermino(double milliseconds){
        	DateTime termino = DateTime.Parse(textBoxTermino.Text);
        	SetControlPropertyValue(textBoxTermino,"Text",termino.AddMilliseconds(milliseconds).ToString());
        }
        public void diminuirTempoTermino(double milliseconds){
        	DateTime termino = DateTime.Parse(textBoxTermino.Text);
        	SetControlPropertyValue(textBoxTermino,"Text",termino.Subtract(TimeSpan.FromMilliseconds(milliseconds)).ToString());
        }
        
    }
}
