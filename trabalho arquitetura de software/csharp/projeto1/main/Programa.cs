using System;
using System.Collections.Generic;
using Dominios;
using Enums;

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
		
		// Criar objeto que guarda informacoes da conta de um hotel
		Conta conta1 = new Conta("trivago@gmail.com",perfil1, carteiradohotel);
		Console.WriteLine("informacoes da conta do hotel");
		Console.WriteLine("*******************************");
		Console.WriteLine(conta1.perfil.nome);
		Console.WriteLine(conta1.perfil.tipodepessoa);
		Console.WriteLine(conta1.email);
		conta1.perfil.enderecos.ForEach(Console.WriteLine);
		
		// Criar objeto que guarda informacoes da conta de um cliente
		Conta conta2 = new Conta("gael@gmail.com",perfil2,carteiradogael);
		Console.WriteLine("informacoes da conta do cliente");
		Console.WriteLine("*******************************");
		Console.WriteLine(conta2.perfil.nome);
		Console.WriteLine(conta2.perfil.tipodepessoa);
		Console.WriteLine(conta2.email);
		conta2.perfil.enderecos.ForEach(Console.WriteLine);
	}
}
