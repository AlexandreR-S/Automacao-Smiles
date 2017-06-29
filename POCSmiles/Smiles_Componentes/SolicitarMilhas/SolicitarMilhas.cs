/*
 * Created by Ranorex
 * User: Alexandre Rodrigues
 * Date: 09/06/2017
 * Time: 15:38
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

namespace POCSmiles.Smiles_Componentes.SolicitarMilhas
{
	/// <summary>
	/// Description of SolicitarMilhas.
	/// </summary>
	[TestModule("A5D595B1-6A80-47AA-B21E-B5665C38ECB1", ModuleType.UserCode, 1)]
	public class SolicitarMilhas : ITestModule
	{
		
		public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

		static SolicitarMilhas instance = new SolicitarMilhas();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SolicitarMilhas()
		{
			// Do not delete - a parameterless constructor is required!
		}

		#region Variables

		string _NumeroVoo;

		/// <summary>
		/// Gets or sets the value of variable NumeroVoo.
		/// </summary>
		[TestVariable("22839aa7-63de-4b63-b4e0-749ffe7b83f0")]
		public string NumeroVoo
		{
			get { return _NumeroVoo; }
			set { _NumeroVoo = value; }
		}

		string _LocalizadorVoo;

		/// <summary>
		/// Gets or sets the value of variable LocalizadorVoo.
		/// </summary>
		[TestVariable("63806c28-a57c-403f-8cfc-6969e1d321b3")]
		public string LocalizadorVoo
		{
			get { return _LocalizadorVoo; }
			set { _LocalizadorVoo = value; }
		}

		string _DataVoo;

		/// <summary>
		/// Gets or sets the value of variable DataVoo.
		/// </summary>
		[TestVariable("edf14d15-da3a-49c1-a266-f24472e1c124")]
		public string DataVoo
		{
			get { return _DataVoo; }
			set { _DataVoo = value; }
		}

		string _CabineViagem;

		/// <summary>
		/// Gets or sets the value of variable CabineViagem.
		/// </summary>
		[TestVariable("7a125f71-7fcb-41b7-97db-29f123736231")]
		public string CabineViagem
		{
			get { return _CabineViagem; }
			set { _CabineViagem = value; }
		}

		string _ClasseReserva;

		/// <summary>
		/// Gets or sets the value of variable ClasseReserva.
		/// </summary>
		[TestVariable("2ac000e0-c5f4-4a67-8277-efbe6680fd09")]
		public string ClasseReserva
		{
			get { return _ClasseReserva; }
			set { _ClasseReserva = value; }
		}

		string _NomePassageiro;

		/// <summary>
		/// Gets or sets the value of variable NomePassageiro.
		/// </summary>
		[TestVariable("316ed9f9-2587-450a-a28b-60a89c43b682")]
		public string NomePassageiro
		{
			get { return _NomePassageiro; }
			set { _NomePassageiro = value; }
		}

		string _SobrenomePassageiro;

		/// <summary>
		/// Gets or sets the value of variable SobrenomePassageiro.
		/// </summary>
		[TestVariable("45b5f8f9-62be-4d7c-96ab-b3f1bf8e9daf")]
		public string SobrenomePassageiro
		{
			get { return _SobrenomePassageiro; }
			set { _SobrenomePassageiro = value; }
		}

		string _AeroportoOrigem;

		/// <summary>
		/// Gets or sets the value of variable AeroportoOrigem.
		/// </summary>
		[TestVariable("d51e8809-0e31-4fb3-8760-f56eb9ac7de7")]
		public string AeroportoOrigem
		{
			get { return _AeroportoOrigem; }
			set { _AeroportoOrigem = value; }
		}

		string _AeroportoDestino;

		/// <summary>
		/// Gets or sets the value of variable AeroportoDestino.
		/// </summary>
		[TestVariable("c6f56b2d-ca94-40ea-843c-82baf8dae56b")]
		public string AeroportoDestino
		{
			get { return _AeroportoDestino; }
			set { _AeroportoDestino = value; }
		}

		string _BilheteEletronico;

		/// <summary>
		/// Gets or sets the value of variable BilheteEletronico.
		/// </summary>
		[TestVariable("ea0f2948-1c08-4783-b88f-137d697b379c")]
		public string BilheteEletronico
		{
			get { return _BilheteEletronico; }
			set { _BilheteEletronico = value; }
		}

		string _AnexarBilheteEletronico;

		/// <summary>
		/// Gets or sets the value of variable AnexarBilheteEletronico.
		/// </summary>
		[TestVariable("30dbb512-6441-4770-9b50-13c9a393c858")]
		public string AnexarBilheteEletronico
		{
			get { return _AnexarBilheteEletronico; }
			set { _AnexarBilheteEletronico = value; }
		}

		string _AnexarCartaoEmbarque;

		/// <summary>
		/// Gets or sets the value of variable AnexarCartaoEmbarque.
		/// </summary>
		[TestVariable("9102357d-ff57-46f6-8de9-d098657b6b55")]
		public string AnexarCartaoEmbarque
		{
			get { return _AnexarCartaoEmbarque; }
			set { _AnexarCartaoEmbarque = value; }
		}

		string _CompanhiaAerea;

		/// <summary>
		/// Gets or sets the value of variable CompanhiaAerea.
		/// </summary>
		[TestVariable("bd78985c-90ec-4418-ac05-c8fa1834c734")]
		public string CompanhiaAerea
		{
			get { return _CompanhiaAerea; }
			set { _CompanhiaAerea = value; }
		}

		#endregion

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			var iComponentStatus = Program.startComponent();
			
			CompanhiaAerea = Program.getProtonValue("in_Companhia_Aerea");// "Delta";
			DataVoo = Program.getProtonValue("in_Data_Voo");//"26/05/2017";
			NumeroVoo = Program.getProtonValue("in_Numero_Voo");//"2371";
			LocalizadorVoo = Program.getProtonValue("in_Localizador_Voo");//"JAHSD";
			CabineViagem = Program.getProtonValue("in_Cabine_Viagem");//"Executiva";
			ClasseReserva = Program.getProtonValue("in_Classe_Reserva");//"I";
			NomePassageiro = Program.getProtonValue("in_Nome");//"Antonio Carlos Faria de";//
			SobrenomePassageiro = Program.getProtonValue("in_Sobrenome");//"Castro";//
			AeroportoOrigem = Program.getProtonValue("in_Aeroporto_Origem");//"GRU";
			AeroportoDestino = Program.getProtonValue("in_Aeroporto_Destino");//"AEP";
			BilheteEletronico = Program.getProtonValue("in_Bilhete_Eletronico");//"1221039821039";
			AnexarCartaoEmbarque  = Program.getProtonValue("in_Anexar_Cartao_Embarque");//"C:\\Automacao - Smiles\\doc\\comprovante_de_embarque.jpg";
			AnexarBilheteEletronico = Program.getProtonValue("in_Anexar_BIlhete_Eletronico");//"C:\\Automacao - Smiles\\doc\\cartao embarque.png";
			
			if(Convert.ToInt32(iComponentStatus) == 2){
				
//				Program.SelectItemListBox("//select[#'_smilescreditrequestportlet_WAR_smilesmemberportlet_airlines']", CompanhiaAerea);
//				Delay.Milliseconds(0);
				
				DivTag dtag = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToString() + "//div[@id='btn-partner-" + CompanhiaAerea.ToLower() + "']";
				dtag.PerformClick();
				
				//Program.SetCalendarDate2("//img[@title='...']", DataVoo);
				Program.SetCalendarDate2("//input[#'input-flight-day']", DataVoo);
				Delay.Milliseconds(0);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SelfInfo, new RecordItemIndex(2));
				repo.SmilesOMelhorProgramaDeMilhasS1.Self.Click(Location.CenterRight);
				Delay.Milliseconds(0);
				
				//Program.CheckVisible();
				//Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{TAB}'.", new RecordItemIndex(4));
				//Keyboard.Press("{TAB}{TAB}");
				//Delay.Milliseconds(0);
				
				//Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(5));
				//Keyboard.Press("{TAB}");
				//Delay.Milliseconds(0);
				
				if(!String.IsNullOrEmpty(NumeroVoo)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_flightNumber' and @visible='True']")){
						Program.TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_flightNumber' and @visible='True']", NumeroVoo);
						Delay.Milliseconds(0);
					}
				}
				
				Program.TypeKeys("//input[@name~'_smilescreditrequestportletv10_WAR_smilesmilesportlet_recordLocator' and @visible='True']", LocalizadorVoo);
				Delay.Milliseconds(0);
				
				if(!String.IsNullOrEmpty(CabineViagem)){
					if(Utils.Exists("//select[#'cabineTravel1']")){
						Program.SelectItemListBox("//select[#'cabineTravel1']", CabineViagem);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(ClasseReserva)){
					if(Utils.Exists("//select[#'cabineReserve1']")){
						Program.SelectItemListBox("//select[#'cabineReserve1']", ClasseReserva);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(NomePassageiro)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerFirstName' and @visible='True']")){
						repo.SmilesOMelhorProgramaDeMilhasS1.Self.PressKeys("{DOWN}",1500);
						Program.TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerFirstName' and @visible='True']", NomePassageiro);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(SobrenomePassageiro)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerLastName' and @visible='True']")){
						Program.TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerLastName' and @visible='True']", SobrenomePassageiro);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(AeroportoOrigem)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_originAirport' and @visible='True']")){
						Program.SelectItemFloatBox("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_originAirport' and @visible='True']", "//div[@class='searchFlightTab' and @Visible='True']", AeroportoOrigem);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(AeroportoDestino)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_destinyAirport' and @visible='True']")){
						Program.SelectItemFloatBox("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_destinyAirport' and @visible='True']", "//div[@class='searchFlightTab' and @Visible='True']", AeroportoDestino);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(BilheteEletronico)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_eticketNumber' and @visible='True']")){
						Program.TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_eticketNumber' and @visible='True']", BilheteEletronico);
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(AnexarBilheteEletronico)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileEticket' and @type='file' and @visible='True']")){
						Program.CheckVisible("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileEticket' and @type='file' and @visible='True']");
						Program.anexarArquivo(AnexarBilheteEletronico, "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileEticket' and @type='file' and @visible='True']");
						Delay.Milliseconds(0);
					}
				}
				if(!String.IsNullOrEmpty(AnexarCartaoEmbarque)){
					if(Utils.Exists("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileBoardingPass' and @type='file' and @visible='True']")){
						Program.CheckVisible("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileBoardingPass' and @type='file' and @visible='True']");
						Program.anexarArquivo(AnexarCartaoEmbarque, "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileBoardingPass' and @type='file' and @visible='True']");
						Delay.Milliseconds(0);
					}
				}
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SelfInfo, new RecordItemIndex(17));
				repo.SmilesOMelhorProgramaDeMilhasS1.Self.Click(Location.CenterRight);
				Delay.Milliseconds(490);
				
				Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}'.", new RecordItemIndex(18));
				Delay.Milliseconds(90);
				
				Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVoo' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVooInfo, new RecordItemIndex(19));
				
				repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVoo.Click();
				Delay.Milliseconds(490);
				//Program.ClickIfExist(repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_OK);
				//Delay.Milliseconds(0);
				
				Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(21));
			}
			iComponentStatus = Program.endComponent();
			
		}
	}
}
