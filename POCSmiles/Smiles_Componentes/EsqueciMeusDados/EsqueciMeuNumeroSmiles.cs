/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 05/06/2017
 * Time: 08:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace POCSmiles.Smiles_Componentes.EsqueciMeusDados
{
	/// <summary>
	/// Description of EsqueciMeuNumeroSmiles.
	/// </summary>
	/// 
	[TestModule("448DED53-C755-416D-8E40-2694FE33860C", ModuleType.UserCode, 1)]
	public class EsqueciMeuNumeroSmiles : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static EsqueciMeuNumeroSmiles instance = new EsqueciMeuNumeroSmiles();
		
		public static EsqueciMeuNumeroSmiles Instance
		{
			get { return instance; }
		}

		
		#region parameter
		string _Documento;
		[TestVariable("d9d7e78c-09c5-4aa9-86b0-fe3072c44e72")]
		public string Documento
		{
			get { return _Documento; }
			set { _Documento = value; }
		}
		
		string _TipoDocumento;
		[TestVariable("a2268dba-3083-45d7-9460-83b618ebdad1")]
		public string TipoDocumento
		{
			get { return _TipoDocumento; }
			set { _TipoDocumento = value; }
		}
		
		string _DataNascimentoDia;
		[TestVariable("345a7c13-dfea-4acc-bb0e-adaeac9dc29a")]
		public string DataNascimentoDia
		{
			get { return _DataNascimentoDia; }
			set { _DataNascimentoDia = value; }
		}
		
		string _DataNascimentoMes;
		[TestVariable("308dd60e-28a2-4002-b316-6a73c6267ca9")]
		public string DataNascimentoMes
		{
			get { return _DataNascimentoMes; }
			set { _DataNascimentoMes = value; }
		}
		
		string _DataNascimentoAno;
		[TestVariable("48b2ea41-2b9b-493a-9f37-8d05a6e2d263")]
		public string DataNascimentoAno
		{
			get { return _DataNascimentoAno; }
			set { _DataNascimentoAno = value; }
		}
		
		#endregion
			/// <summary>
			/// Constructs a new instance.
			/// </summary>

			/// <summary>
			/// Performs the playback of actions in this module.
			/// </summary>
			/// <remarks>You should not call this method directly, instead pass the module
			/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
			/// that will in turn invoke this method.</remarks>
			
			public static void Start()
		{
			TestModuleRunner.Run(Instance);
		}
		
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.00;

			var iComponentStatus = Program.startComponent();
		
			DataNascimentoAno = Program.getProtonValue("in_Data_Nascimento_Ano");
			DataNascimentoMes = Program.getProtonValue("in_Data_Nascimento_Mes");
			DataNascimentoDia = Program.getProtonValue("in_Data_Nascimento_Dia");
			TipoDocumento = Program.getProtonValue("in_Tipo_Documento");
			Documento = Program.getProtonValue("in_Numero_Documento");
			
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone'.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(0));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(1));
				repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone.Click(Location.LowerCenter, 1);
				Delay.Milliseconds(300);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhone'.", repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo, new RecordItemIndex(2));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.BrandWrapperHiddenPhoneInfo);
				Delay.Milliseconds(300);
				
				//Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles' at 61;11.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmilesInfo, new RecordItemIndex(3));
				//repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles.Click("61;11", 1);
				//Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{TAB}'.", new RecordItemIndex(4));
				Keyboard.Press("{TAB}{TAB}");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
				Delay.Duration(1000, false);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles' at 61;11.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmilesInfo, new RecordItemIndex(6));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EsqueciNumeroSmiles.Click("61;11", 1);
				Delay.Milliseconds(1000);
				
				Program.SelectItemListBox("//select[#'inputDocumentType']", TipoDocumento);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumento'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumentoInfo, new RecordItemIndex(8));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_NumeroDocumento.PressKeys(Documento, 1);
				Delay.Milliseconds(300);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoDia' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDia'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDiaInfo, new RecordItemIndex(9));
				Program.TypeKeys(Utils.GetPath(repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoDiaInfo) , DataNascimentoDia);
				Delay.Milliseconds(300);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoMes' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMes'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMesInfo, new RecordItemIndex(10));
				Program.TypeKeys(Utils.GetPath(repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoMesInfo),DataNascimentoMes);
				Delay.Milliseconds(300);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataNascimentoAno' with focus on 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAno'.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAnoInfo, new RecordItemIndex(11));
				Program.TypeKeys(Utils.GetPath(repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_DataNascimentoAnoInfo), DataNascimentoAno);
				Delay.Milliseconds(300);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar' at 69;23.", repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_EnviarInfo, new RecordItemIndex(12));
				repo.SmilesOMelhorProgramaDeMilhasS1.Esqueci_Enviar.Click("69;23", 1);
				Delay.Milliseconds(490);
				
				Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(13));
			}
			iComponentStatus = Program.endComponent();
			
		}
	}
}
