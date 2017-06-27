/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 07/06/2017
 * Time: 17:56
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
using RestSharp.Extensions;

namespace POCSmiles.Smiles_Componentes.Busca_De_Voos
{
	[TestModule("62C059E2-EC78-466E-B364-A0C626B9B4E1", ModuleType.UserCode, 1)]
	public class NBV_BuscarVoos : ITestModule
	{
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static NBV_BuscarVoos instance = new NBV_BuscarVoos();

		public NBV_BuscarVoos()
		{
			// Do not delete - a parameterless constructor is required!
		}

		
		#region Variables

		
		string _Origem1 = "";
		[TestVariable("598e45f6-5007-4342-9d46-747c21e41bf5")]
		public string Origem1
		{
			get { return _Origem1; }
			set { _Origem1 = value; }
		}
		
		string _Destino1 = "";
		[TestVariable("5ff51254-8edd-4f8d-8e0d-26a273cafc1d")]
		public string Destino1
		{
			get { return _Destino1; }
			set { _Destino1 = value; }
		}
		
		string _TipoTrajeto = "";
		[TestVariable("2a576830-45a1-441a-8af4-7c69553f51da")]
		public string TipoTrajeto
		{
			get { return _TipoTrajeto; }
			set { _TipoTrajeto = value; }
		}
		
		string _Destino2 = "";
		[TestVariable("07dc295d-f182-4e42-9726-30116171b5b8")]
		public string Destino2
		{
			get { return _Destino2; }
			set { _Destino2 = value; }
		}
		
		string _Origem2 = "";
		[TestVariable("be723f8e-7e3e-4e01-9d13-67b1d4c8d0d4")]
		public string Origem2
		{
			get { return _Origem2; }
			set { _Origem2 = value; }
		}
		

		string _DataPartida1 = "";
		[TestVariable("df78cca3-a268-46db-a470-bda21edc650a")]
		public string DataPartida1
		{
			get { return _DataPartida1; }
			set { _DataPartida1 = value; }
		}

		
		
		string _DataRetorno1 = "";
		[TestVariable("a30b2612-026b-44e0-87e6-72b45cc1dc1a")]
		public string DataRetorno1
		{
			get { return _DataRetorno1; }
			set { _DataRetorno1 = value; }
		}
		
		
		
		string _DataPartida2 = "";
		[TestVariable("101f42c0-ee1b-4183-84aa-9ea4c53ae0b2")]
		public string DataPartida2
		{
			get { return _DataPartida2; }
			set { _DataPartida2 = value; }
		}
		
		
		string _QuantidadeBebes = "";
		[TestVariable("5f8b7774-73aa-41a9-8d7a-571264bd87df")]
		public string QuantidadeBebes
		{
			get { return _QuantidadeBebes; }
			set { _QuantidadeBebes = value; }
		}
		
		string _QuantidadeCriancas = "";
		[TestVariable("d317a96b-9e7c-46d4-b120-a3579656b4c7")]
		public string QuantidadeCriancas
		{
			get { return _QuantidadeCriancas; }
			set { _QuantidadeCriancas = value; }
		}
		
		
		string _QuantidadeAdultos = "";
		[TestVariable("55ba3ed8-88f6-46c0-a0cc-888c85bec338")]
		public string QuantidadeAdultos
		{
			get { return _QuantidadeAdultos; }
			set { _QuantidadeAdultos = value; }
		}
		
		#endregion

		void ITestModule.Run()
		{
			
			var iComponentStatus = Program.startComponent();
			
			#region parameter
			Origem1 = Program.getProtonValue("in_Origem_1"); //"TYO";
			Destino1 = Program.getProtonValue("in_Destino_1"); //"SHA";
			Origem2 = Program.getProtonValue("in_Origem_1"); //"SHA";
			Destino2 = Program.getProtonValue("in_Destino_1"); //"ICN";
			TipoTrajeto = Program.getProtonValue("in_Tipo_Trajeto"); //"SOMENTE IDA"; //or VÁRIOS TRECHOS
			DataPartida1 = Program.getProtonValue("in_Data_Partida_1"); //"08/06/2017";
			DataRetorno1 = Program.getProtonValue("in_Data_Retorno_1"); //"14/06/2017";
			DataPartida2 = Program.getProtonValue("in_Data_Partida_2"); //"17/06/2017";
			QuantidadeAdultos = Program.getProtonValue("in_Quantidade_Adultos"); //"3";
			QuantidadeBebes = Program.getProtonValue("in_Quantidade_Bebes"); //"1";
			QuantidadeCriancas = Program.getProtonValue("in_Quantidade_Criancas"); //"2";
			#endregion
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
				Mouse.DefaultMoveTime = 300;
				Keyboard.DefaultKeyPressTime = 100;
				Delay.SpeedFactor = 1.0;
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVoo' at LowerCenter.", repo.SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVooInfo, new RecordItemIndex(0));
				repo.SmilesOMelhorProgramaDeMilhasS1.MenuPrincipal_BuscarVoo.Click(Location.LowerCenter, 1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
				Delay.Duration(2000, false);
				
				Program.WaitSystemLoad("45");
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVoo2'.", repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVoo2Info, new RecordItemIndex(3));
				Validate.Exists(repo.SmilesOMelhorProgramaDeMilhasS1.Validacao_EncontreSeuVoo2Info);
				Delay.Milliseconds(100);
				
				Program.SelectItemFloatBox("//input[#'inputOrigin']", "//div[#'searchFlightTab']", Origem1);
				Delay.Milliseconds(100);
				
				Program.SelectItemFloatBox("//input[#'inputDestination']", "//div[#'searchFlightTabBack']", Destino1);
				Delay.Milliseconds(100);
				
				Program.selectTrecho(TipoTrajeto);
				Delay.Milliseconds(0);
				
				
				if(TipoTrajeto.Equals("VÁRIOS TRECHOS")){
					Program.SelectItemFloatBox("//input[#'inputOriginMs2']", "//div[#'searchFlightTabMs']", Origem2);
					Delay.Milliseconds(100);
					
					Program.SelectItemFloatBox("//input[#'inputDestinationMs2']", "//div[#'searchFlightTabBackMs']", Destino2);
					Delay.Milliseconds(10);
				}
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_De1' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_De1Info, new RecordItemIndex(9));
				repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_De1.Click(1);
				Delay.Milliseconds(490);
				
				Program.SetCalendarDate("//input[@class~'date-picker-search' and @visible='True'][1]", DataPartida1);
				Delay.Milliseconds(0);
				if(!TipoTrajeto.Equals("VÁRIOS TRECHOS") && !TipoTrajeto.Equals("SOMENTE IDA")){
					Program.SetCalendarDate("//input[@class~'date-picker-search' and @visible='True'][2]", DataRetorno1);
					Delay.Milliseconds(0);
				}else if(TipoTrajeto.Equals("VÁRIOS TRECHOS")){
					Program.SetCalendarDate("//input[@class~'date-picker-search' and @visible='True'][2]", DataPartida2);
					Delay.Milliseconds(0);
				}
				
				Report.Log(ReportLevel.Info, "Sits", "Selecting the number of sits for adults, childs and babies.", new RecordItemIndex(15));
				Program.insertPassengers(QuantidadeAdultos, QuantidadeCriancas, QuantidadeBebes);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BotaoBuscarVoo' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BotaoBuscarVooInfo, new RecordItemIndex(14));
				repo.SmilesOMelhorProgramaDeMilhasS1.BuscarVoo_BotaoBuscarVoo.Click(1);
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
				Delay.Duration(1000, false);
				
				if (repo.SmilesOMelhorProgramaDeMilhasS1.BuscaVoo_MensagemMesmoDiaInfo.Exists(7000)){
					Report.Log(ReportLevel.Info, "Mensagem mesmo dia", "Clicking the item 'OK'", new RecordItemIndex(15));
					repo.SmilesOMelhorProgramaDeMilhasS1.OK.Click();
				}
				
				Report.Log(ReportLevel.Info, "Load", "Waiting page load.", new RecordItemIndex(15));
				Program.WaitLoad();
				
				if (repo.SmilesOMelhorProgramaDeMilhasS1.MsgBilheteBebesInfo.Exists(7000)){
					Report.Log(ReportLevel.Info, "Close Box", "Closing the message 'Aviso'", new RecordItemIndex(15));
					repo.SmilesOMelhorProgramaDeMilhasS1.FecharMsg.Click();
				}
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Load", "Waiting page load.", new RecordItemIndex(15));
				Program.WaitSystemLoad("60");
				Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(18));
			}
			iComponentStatus = Program.endComponent();
		}
	}
}
