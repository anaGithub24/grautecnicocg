using System;
using Enums;


public class Hospede
{
	public string nome;
	public string telefone;
	public DataTime datanasc;
	public string numerododocumento;
	public Tipododocumento tipododocumento;
		
	public Hospede
	(
		string nome,
		string telefone,
		DataTime datanasc,
		string numerododocumento,
		Tipododocumento tipododocumento
	)
	{
		this.nome =nome;
		this.telefone =telefone;
		this.datanasc =datanasc;
		this.numerododocumento =numerododocumento;
		this.tipododocumento =tipododocumento;
	}
}


public class Conta
{
	public string email;
	public Perfil perfil;
	public List<meiosdepagamento> carteira;
	
	public Conta
	(
		string email,
		Perfil perfil,
		List<meiosdepagamento> carteira,
	)
	{
		this.email = email;
		this.perfil = perfil;
		this.carteira = carteira;
	}
}


public class Hotel
{
	public string nome;
	public string endereco;
	public string cadeiadohotel;
	public Conta contadeparceiro;
	public List<oferta> oferta;
	public List<Acomodacao> acomodacoes;
	
	public Hotel
	(
		string nome,
		string endereco,
		string cadeiadohotel,
		List<oferta> oferta,
		LIst<acomodacao> acomodacoes,
	)
	{
		this.nome = nome;
		this.endereco = endereco;
		this.cadeiadohotel = cadeiadohotel;
		this.oferta = oferta;
		this.acomodacoes = acomodacoes;
	}
}

class Programa {

	public static void Main(string[] args) {
		List<string> enderecosdohotel = new List<string>();
		enderecosdohotel.Add("Rua Joao, 1 - Areia/PB");
		enderecosdohotel.Add("Rua Maria, 2 - Natal/RN");	

		List<string> enderecosdogael = new List<string>();
		enderecosdogael.Add("Rua Jose, 3 - Campina Grande/PB");
	
		Perfil perfil1 = new Perfil
		(
			"Trivago",
			"85332244",
			"28/11/2022",
			"23.345.65",
			Tipodedocumento.CNPJ,
			"trivago.hotel",
			Tipodepessoa.JURIDICA,
			enderecosdohotel
		);
		
		Perfil perfil2 = new Perfil
		(
			"gael",
			"9853749416",
			"16/03/2020",
			"23.345.65",
			Tipodedocumento.RG,
			"gael.777",
			Tipodepessoa.FISICA,
			enderecosdogael
		);
		
		Console.WriteLine("informacoes do perfil do hotel");
		Console.WriteLine("*******************************");
		Console.WriteLine(perfil1.nome);
		Console.WriteLine(perfil1.telefone);
		Console.WriteLine(perfil1.tipodepessoa);
		Console.WriteLine("*******************************");
		
		Console.WriteLine("informacoes do perfil do cliente");
		Console.WriteLine("*******************************");
		Console.WriteLine(perfil2.nome);
		Console.WriteLine(perfil2.telefone);
		Console.WriteLine(perfil2.tipodepessoa);
		Console.WriteLine("*******************************");
		
		List<Meiodepagamento> carteiradogael = new List<Meiodepagamento>();
		carteiradogael.Add(Meiodepagamento.PIX);
		carteiradogael.Add(Meiodepagamento.DINHEIRO);
		carteiradogael.Add(Meiodepagamento.CARTAODEDEBITO);
		
		List<Meiodepagamento> carteiradohotel = new List<Meiodepagamento>();
		carteiradohotel.Add(Meiodepagamento.PIX);
		carteiradohotel.Add(Meiodepagamento.CARTAODECREDITO);
		carteiradohotel.Add(Meiodepagamento.CARTAODEDEBITO);
		
		Conta conta1 = new Conta("trivago@gmail.com",perfil1, carteiradohotel);
		Console.WriteLine("informacoes da conta do hotel");
		Console.WriteLine("*******************************");
		Console.WriteLine(conta1.perfil.nome);
		Console.WriteLine(conta1.perfil.tipodepessoa);
		Console.WriteLine(conta1.email);
		conta1.perfil.enderecos.ForEach(Console.WriteLine);
		
		Conta conta2 = new Conta("gael@gmail.com",perfil2,carteiradogael);
		Console.WriteLine("informacoes da conta do cliente");
		Console.WriteLine("*******************************");
		Console.WriteLine(conta2.perfil.nome);
		Console.WriteLine(conta2.perfil.tipodepessoa);
		Console.WriteLine(conta2.email);
		conta2.perfil.enderecos.ForEach(Console.WriteLine);
	}
}

