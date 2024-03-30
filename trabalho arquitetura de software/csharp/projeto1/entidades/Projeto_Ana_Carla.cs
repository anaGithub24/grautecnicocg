using System.Collections.Generic;

public enum Tipodedocumento { RG, CPF, CNPJ, CNH }
public enum Tipodepessoa { FISICA, JURIDICA }
public enum Meiodepagamento { DINHEIRO, CARTAODEDEBITO, CARTAODECREDITO, PIX }
public enum Quarto { SOLTEIRO, CASAL, FAMILIA, SUITE }

public class Conta 
	{ 
		//atributos
		public string email;
		public Perfil perfil; // 1:1
		public List<Meiodepagamento> carteira; // 1:n
		//construtor
		public Conta
		(
			string email,
			Perfil perfil,
			List<Meiodepagamento> carteira
		)
		{
			this.email=email;
			this.perfil=perfil;
			this.carteira=carteira;
		}
	}

public class Perfil 
	{ 
		//atributos
		public string nome;
		public string telefone;
		public string datanasc;
		public string numerodocumento;
		public Tipodedocumento tipodedocumento; 
		public string nomedousuario;
		public Tipodepessoa tipodepessoa;
		public List<string> enderecos; // 1:N
		
		
		//construtor
		public Perfil
		(
			string nome ,
			string telefone,
			string datanasc,
			string numerodocumento,
			Tipodedocumento tipodedocumento,	
			string nomedousuario,
			Tipodepessoa tipodepessoa,
			List<string> enderecos
		)
		{
			this.nome =nome;
			this.telefone=telefone;
			this.datanasc=datanasc;
			this.numerodocumento=numerodocumento;
			this.tipodedocumento=tipodedocumento;
			this.nomedousuario=nomedousuario;
			this.tipodepessoa=tipodepessoa;
			this.enderecos=enderecos;
		}
	}

public class Hotel 
	{
		// atributos primitivos adicionais
		public string nome;
		public string endereco;
				
		//atributos pedidos no projeto
		// 1:1
		public string cadeiadohotel;
		public Conta contadeparceiro;
		
		//1:N
		public List<Oferta> ofertas;
		public List<Acomodacao> acomodacoes;
		
		public Hotel
		(
			string nome,
			string endereco,
			string cadeiadohotel,
			List<Oferta> ofertas,
			List<Acomodacao> acomodacoes
		)
		{
			this.nome = nome;
			this.endereco = endereco;
			this.cadeiadohotel = cadeiadohotel;
			this.ofertas = ofertas;
			this.acomodacoes = acomodacoes;
		}
		
	}	
	
	
public class Oferta
	{
		public string descricao;
		public string ;
		public DateTime datainicio;
		public DateTime datafim;
		
		public Oferta 
		(
			string descricao,
			string cupompromocional,
			DateTime datainicio,
			DateTime datafim
		)
		{
			this.descricao = descricao;
			this.cupompromocional=cupompromocional;
			this.datainicio = datainicio;
			this.datafim = datafim;
		}
	}
	
public class Acomodacao 
	{
		public string descricao;
		public List<Quarto> quartos;
		 
		
		//1:1 com Oferta
		public Oferta oferta;
		
		public Acomodacao
		(
			string descricao,
			List<Quarto> quartos,
			Oferta oferta
		)
		{
			this.descricao = descricao;
			this.quartos = quartos;
			this.oferta = oferta;
			
		}
	}