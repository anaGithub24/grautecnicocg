using System.Collections.Generic;
using System;

public enum Tipodedocumento { RG, CPF, CNPJ, CNH }
public enum Tipodepessoa { FISICA, JURIDICA }
public enum Tipodeproduto { MEDICAMENTO, ARMAMENTO, ECOMMERCE }

public class Produto
{
	public string nome;
	public string id;
	public string marca;
	public Estoque Estoque;
	public Cliente comprador;
	public Vendedor vendedor;
	public DateTime dataretirada;
	public Tipodeproduto tipodeproduto;
	
	public Produto
	(
		string nome,
		string id,
		string marca,
		Estoque estoque,
		Cliente comprador,
		Vendedor vendedor,
		DateTime dataretirada,
		Tipodeproduto tipodeproduto
	)
	{
		this.nome=nome;
		this.id=id;
		this.marca;
		this.estoque=estoque;
		this.emedicamento=emedicamento;
		this.earmamento=earmamento;
		this.comprador=comprador;
		this.vendedor=vendedor;
		this.dataretirada=dataretirada;
		this.tipodeproduto=tipodeproduto;
	}
	
}

public class Estoque
{
	public string id;
	public List<Produto> produtos;
	public string endereco;
	
	public Estoque
	(
		string id,
		List<Produto> produtos,
		string endereco
	)
	{
		this.id=id;
		this.produtos=produtos;
		this.endereco=endereco;
	}
}

public class Usuario 
{ 
		//atributos
	public string codigo;
	public string nome;
	public string telefone;
	public string datanasc;
	public string numerodocumento;
	public Tipodedocumento tipodedocumento; 
	public string nomedousuario;
	public Tipodepessoa tipodepessoa;
	public List<string> enderecos; // 1:N
		
		
	//construtor
	
	public Usuario () {}
	
	public Usuario
	(
		string nome ,
		string telefone,
		string numerodocumento,
		Tipodedocumento tipodedocumento,	
		Tipodepessoa tipodepessoa,
	)
	{
		this.nome =nome;
		this.telefone=telefone;
		this.numerodocumento=numerodocumento;
		this.tipodedocumento=tipodedocumento;
		this.tipodepessoa=tipodepessoa;
	}
	
	public Usuario
	(
		string codigo,
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
		this.codigo=codigo;
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

public class Entrega
{
	public string codigoderastreio;
	public List<Produto> produtos;
	public Condutor condutor;
	
    public Entrega 
	(
		string codigoderastreio,
		List<Produto> produtos,
		Condutor condutor
	)
	{
		this.codigoderastreio=codigoderastreio;
		this.produtos=produtos;
		this.condutor=condutor;
	}
}

public class Cliente : Usuario {}

public class Empresa : Usuario
{
	public List<Vendedor> vendedores;
}

public class Condutor : Usuario 
{
	public Transportadora transportadora;
	public List<Produto> produtostransportados;
}

public class Transportadora : Usuario 
{
	public List<Vendedor> vendedores;
}

public class Vendedor : Usuario 
{
	public Empresa empresa;
	public List<Produto> produtosvendidos;
}

public class Funcionario : Usuario {}

public class Armadefogo : Produto 
{
	public string serial;
} 


