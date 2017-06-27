/*
 * Created by Ranorex
 * User: welli
 * Date: 02/02/2016
 * Time: 21:47
 * 
 * To change FormProgesso template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace POCSmiles.Base_Dados
{
    /// <summary>
    /// Description of UtilsDB.
    /// </summary>
    [TestModule("E5394AB4-9461-428D-8863-8B688C43579C", ModuleType.UserCode, 1)]
    public class UtilsDB : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UtilsDB()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in FormProgesso module.
        /// </summary>
        /// <remarks>You should not call FormProgesso method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke FormProgesso method.</remarks>
        void ITestModule.Run()
        {
        }
        
        private static OleDbConnection getConn(){
        	try {
        		string strAccessConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Utils.getGlobalValue("Database_Location");
				return  new OleDbConnection(strAccessConn);
        	} catch (Exception) {
        		Report.Error("Database connection  exception- Error databa connecting");
        		throw new System.Exception("Database connection exception");
        	}
        }
        public static string getRandomUser(string query){
        		Random rnd = new Random();
        		DataTable data = new DataTable();
	    		data.Load(executeQuery(@query));
	    		DataRow[] row = data.Select();
	    		int num = rnd.Next(data.Rows.Count);
	    		return String.Format("{0:00000000000}", double.Parse(row[num]["CPF"].ToString()));
        }
        
        public static string getRandomGIFT(string query){
        		Random rnd = new Random();
        		DataTable data = new DataTable();
	    		data.Load(executeQuery(@query));
	    		DataRow[] row = data.Select();
	    		int num = rnd.Next(data.Rows.Count);
	    		return row[num]["NOME"].ToString();
        }
        
        public static bool checkExist(string query){
    		DataTable data = new DataTable();
    		data.Load(executeQuery(query));
    		DataRow[] row = data.Select();
    		return row.Count() > 0 ? true : false;
        }
        
        public static string getRandomFly(string query){
        		Random rnd = new Random();
        		DataTable data = new DataTable();
	    		data.Load(executeQuery(query));
	    		DataRow[] row = data.Select();
	    		return row[rnd.Next(data.Rows.Count)]["NUM_RESERVA"].ToString();
        }
        
        public static string getRandomFavorite(string query){
        		Random rnd = new Random();
        		DataTable data = new DataTable();
	    		data.Load(executeQuery(query));
	    		DataRow[] row = data.Select();
	    		return row[rnd.Next(data.Rows.Count)]["NUM_DOCUMENTO"].ToString();
        }
        public static string getRandomDestiny(string condition){
        		Random rnd = new Random();
        		DataTable data = new DataTable();
        		data.Load(executeQuery("SELECT DESTINO FROM DESTINOS " + (condition.Equals("")?"":("WHERE " + condition))));
	    		DataRow[] row = data.Select();
	    		return row[rnd.Next(data.Rows.Count)]["DESTINO"].ToString();
        }
         public static string getDataValue(string cpf, string url,string field){
        		DataTable data = new DataTable();
				data.Load(executeQuery("SELECT * FROM SMILES WHERE CPF = " + cpf));
	    		DataRow[] row = data.Select();
	    		return row[0][field].ToString();
        }
        
        public static string getDataValuePNR(string cpf, string numReserva,string field){
    		DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT * FROM PNR WHERE CPF = " + cpf + " AND NUM_RESERVA = '" + numReserva + "'"));
    		DataRow[] row = data.Select();
    		return row[0][field].ToString();
        }
        
        public static void insertUser(string cpf, string senha, string url){
        		executeQuery("INSERT INTO SMILES(CPF, SENHA, URL, CLUBE, SALDO_MILHAS, SALDO_COMPRA, DATA_MODIFICACAO, OBS_MODIFICACAO) VALUES(" + cpf + ",'" + senha + "','" + url + "', FALSE, 0, 0, '" + System.DateTime.Now.ToShortDateString() + "','NOVO USUARIO ADICIONADO')");
        }
        
        public static void updateMilhas(string cpf, string url, string milhas){
        		executeQuery("UPDATE SMILES SET SALDO_MILHAS = " + milhas + ", OBS_MODIFICACAO = 'MILHAS ATUALIZADAS', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf);
        }
        
         public static void deleteUser(string cpf, string url){
        		executeQuery("DELETE FROM SMILES WHERE CPF = " + cpf);
        }
        
        public static void updateSaldoCompraMilhas(string cpf, string url, string milhas){
			executeQuery("UPDATE SMILES SET SALDO_COMPRA = " + (double.Parse(getDataValue(cpf, url, "SALDO_COMPRA")) + double.Parse(milhas)) + ", OBS_MODIFICACAO = 'MILHAS ATUALIZADAS', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf);
        }
        
        public static void updatePnrTaxasDinheiro(string cpf, string identificacaoVoo, string valor){
			executeQuery("UPDATE PNR SET TAXAS_DINHEIRO = " + valor + ", TAXAS_MILHAS = 0, DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf + " AND NUM_RESERVA = '" + identificacaoVoo + "'");
        }
        
        public static void updatePnrTaxasMilhas(string cpf, string identificacaoVoo, string milhas){
			executeQuery("UPDATE PNR SET TAXAS_MILHAS = " + milhas + ", TAXAS_DINHEIRO = 0, DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf + " AND NUM_RESERVA ='" + identificacaoVoo + "'");
        }
        
        public static void updatePnrVooReservado(string cpf, string identificacaoVoo, bool flag){
			executeQuery("UPDATE PNR SET VOO_RESERVADO = " + flag + ", DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf + " AND NUM_RESERVA ='" + identificacaoVoo + "'");
        }
        
        public static void updateClube(string cpf, string url, bool clube){
        		executeQuery("UPDATE SMILES SET CLUBE = " + clube.ToString() + ", OBS_MODIFICACAO = 'CLUBE ATUALIZADO', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf);
        }
         public static void updateChairSelected(string identificacaoVoo, string cpf, string url, string taxasMilhas, string taxasDinheiro){
				executeQuery("UPDATE SMILES AS A INNER JOIN PNR AS B ON A.CPF = B.CPF SET  B.DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "', B.ASSENTO_SELECIONADO = TRUE, B.ASSENTO_TAXAS_MILHAS = " + taxasMilhas.Replace(".", "").Replace(",", ".") + ", B.ASSENTO_TAXAS_DINHEIRO = " + taxasDinheiro.Replace(".", "").Replace(",", ".") + " WHERE B.CPF = " + cpf + " AND B.NUM_RESERVA = '" + identificacaoVoo + "'");
        }
        
        public static void updateSenha(string cpf, string url, string senha){
        	executeQuery("UPDATE SMILES SET DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "', SENHA = " + senha + " WHERE CPF = " + cpf);
        }
        
        public static void updateGIFTFinalizado(string cpf, bool finalizado){
        	executeQuery("UPDATE GIFT SET FINALIZADO = " + finalizado + " WHERE CPF = " + cpf);
        }
        
         public static void updateFlyCancel(string identificacaoVoo, string cpf, string url){
        		executeQuery("UPDATE SMILES AS A INNER JOIN PNR AS B ON A.CPF = B.CPF SET  B.DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "', B.VOO_CANCELADO = TRUE WHERE B.CPF = " + cpf + " AND B.NUM_RESERVA = '" + identificacaoVoo + "'");
        }
               
        public static void insertNewPnr(string cpf, string numReserva, string voo1, string voo2, string tarifasPorAdultoDinheiro, string tarifasPorAdultoMilhas, string taxasDinheiro, string taxasMilhas, string dataPartida, string reserva, string qntPassageiros, string observacoesPNR, string detalhesVoo1, string detalhesVoo2, string tipoTrajeto){
				executeQuery("INSERT INTO PNR (CPF,NUM_RESERVA,VOO_1,VOO_2,TARIFAS_POR_ADULTO_DINHEIRO,TARIFAS_POR_ADULTO_MILHAS,TAXAS_DINHEIRO,TAXAS_MILHAS,DATA_MODIFICACAO, DATA_PARTIDA,VOO_RESERVADO, QNT_PASSAGEIROS, OBSERVACOES_PNR, DETALHES_VOO1, DETALHES_VOO2, TIPO_TRAJETO) VALUES(" + cpf + ",'" + numReserva + "','" + voo1 + "','" + voo2 + "', " + tarifasPorAdultoDinheiro.Replace(".", "").Replace(",", ".") + ", " + tarifasPorAdultoMilhas.Replace(".", "").Replace(",", ".") + ", " + taxasDinheiro.Replace(".", "").Replace(",", ".") + ", " + taxasMilhas.Replace(".", "").Replace(",", ".") + ", '" + System.DateTime.Now.ToShortDateString() + "', '" + dataPartida + "', " + reserva + ", " + qntPassageiros + ", '" + observacoesPNR + "', '" + detalhesVoo1 +"', '" + detalhesVoo2 + "', '"+ tipoTrajeto +"')");
        }
        
        public static void insertNewGIFT(string cpf, string linkEvento, string dataFimEvento, string nome){
				executeQuery("INSERT INTO GIFT (CPF,NOME,LINK_EVENTO,DATA_CRIACAO,DATA_FIM_EVENTO) VALUES(" + cpf + ",'" + nome + "', '" + linkEvento + "','" + System.DateTime.Now.ToShortDateString() + "', '" + dataFimEvento + "')");
        }
         public static void updateNumReserva(string cpf, string url){
				executeQuery("UPDATE SMILES SET NUM_RESERVAS = " + (double.Parse(getDataValue(cpf, url,"NUM_RESERVAS")) + 1).ToString() + ", OBS_MODIFICACAO = 'NUM RESERVAS ATUALIZADO', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF = " + cpf);
        }
        
        private static OleDbDataReader executeQuery(string query){
        	try {
	    		OleDbConnection conn = getConn();
	    		conn.Open();
	    		OleDbCommand cmd = conn.CreateCommand();
	    		cmd.CommandText = query;
	    		OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
	    		return reader;
        	} catch (Exception e) {
        		throw new System.Exception("Database query execution  exception. Query: " + query + ". Message: " + e.Message);
        	}
        }
        
        public static void insertNewFavorito(string cpf, string numDocumento){
			executeQuery("INSERT INTO FAVORITOS (CPF,NUM_DOCUMENTO,DATA_MODIFICACAO) VALUES(" + cpf + ",'" + numDocumento + "','" + System.DateTime.Now.ToShortDateString() + "')");
        }
        
        public static void updateFavorito(string cpf, string numDocumento){
        	executeQuery("UPDATE FAVORITOS SET NUM_DOCUMENTO = '" + numDocumento + "', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + "' WHERE CPF =" + cpf);
        }
        
        public static void deleteFavorito(string cpf, string numDocumento){
        	executeQuery("DELETE FROM FAVORITOS WHERE NUM_DOCUMENTO = '" + numDocumento + "' AND CPF =" + cpf);
        }
        public static void updateControleExecucao(string browser, string nomeCasoTeste,string status, string pathEvicencia){
        	executeQuery("UPDATE CONTROLE_EXECUCAO SET " + browser + " = '" + status + "', DATA_MODIFICACAO = '" + System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString() + "', EVIDENCIA = '" + pathEvicencia + "' WHERE NOME_CASO_TESTE LIKE'" + nomeCasoTeste + "'");
        }
        public static void insertControleExecucao(string nomeCasoTeste){
        	executeQuery("INSERT INTO CONTROLE_EXECUCAO (NOME_CASO_TESTE, IE, FIREFOX, CHROME, DATA_MODIFICACAO, EVIDENCIA) VALUES('" + nomeCasoTeste + "', '', '', '','" + System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString() + "', '')");
        }
        public static int getMenorTempoSucesso(string nomeCaso){
        	DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT MENOR_TEMPO_SUCESSO FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'"));
    		DataRow[] row = data.Select();
    		return int.Parse(row[0]["MENOR_TEMPO_SUCESSO"].ToString());
        }
        public static int getMaiorSucesso(string nomeCaso){
        	DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT MAIOR_TEMPO_SUCESSO FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'"));
    		DataRow[] row = data.Select();
    		return int.Parse(row[0]["MAIOR_TEMPO_SUCESSO"].ToString());
        }
        public static int getMenorTempoErro(string nomeCaso){
        	DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT MENOR_TEMPO_ERRO FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'"));
    		DataRow[] row = data.Select();
    		return int.Parse(row[0]["MENOR_TEMPO_ERRO"].ToString());
        }
        public static int getMaiorErro(string nomeCaso){
        	DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT MAIOR_TEMPO_ERRO FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'"));
    		DataRow[] row = data.Select();
    		return int.Parse(row[0]["MAIOR_TEMPO_ERRO"].ToString());
        }
        public static void salvarTempoExecucao(string nomeCaso, int tempoExecucao, Ranorex.Core.Reporting.ActivityStatus status){
        	if (checkExist("SELECT * FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'")) {
        		switch (status) {
        			case Ranorex.Core.Reporting.ActivityStatus.Success:
        				if (tempoExecucao < getMenorTempoSucesso(nomeCaso)) {
		        			executeQuery("UPDATE ESTIMATIVA_EXECUCAO SET MENOR_TEMPO_SUCESSO = " + tempoExecucao + " WHERE NOME_CASO LIKE '"	 + nomeCaso + "'");
		    		    }else{
		    		    	executeQuery("UPDATE ESTIMATIVA_EXECUCAO SET MAIOR_TEMPO_SUCESSO = " + tempoExecucao + " WHERE NOME_CASO LIKE '"	 + nomeCaso + "'");
		    		    }
        				break;
        			case Ranorex.Core.Reporting.ActivityStatus.Failed:
        				if (tempoExecucao < getMenorTempoErro(nomeCaso)) {
		        			executeQuery("UPDATE ESTIMATIVA_EXECUCAO SET MENOR_TEMPO_ERRO = " + tempoExecucao + " WHERE NOME_CASO LIKE '"	 + nomeCaso + "'");
		    		    }else{
		    		    	executeQuery("UPDATE ESTIMATIVA_EXECUCAO SET MAIOR_TEMPO_ERRO = " + tempoExecucao + " WHERE NOME_CASO LIKE '"	 + nomeCaso + "'");
		    		    }
        				break;
        		}
        	}else{
        		executeQuery("INSERT INTO ESTIMATIVA_EXECUCAO (NOME_CASO,MAIOR_TEMPO_SUCESSO, MENOR_TEMPO_SUCESSO,MAIOR_TEMPO_ERRO, MENOR_TEMPO_ERRO) VALUES ('" + nomeCaso + "'," + tempoExecucao + "," + tempoExecucao + "," + tempoExecucao + "," + tempoExecucao + ")");
        	}
        	          
        }
        public static int getMediaTempo(string nomeCaso){
    		DataTable data = new DataTable();
    		data.Load(executeQuery("SELECT (MAIOR_TEMPO_SUCESSO + MENOR_TEMPO_SUCESSO + MAIOR_TEMPO_ERRO + MENOR_TEMPO_ERRO)/4 AS MEDIA FROM ESTIMATIVA_EXECUCAO WHERE NOME_CASO LIKE '" + nomeCaso + "'"));
    		DataRow[] row = data.Select();
    		return (int) double.Parse(row[0]["MEDIA"].ToString());
        }
    }
}
