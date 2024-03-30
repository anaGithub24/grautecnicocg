using System.Collections.Generic;
using Enums;

namespace Dominios {
	
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
		
		public Perfil () {}
		
		public Perfil
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
}