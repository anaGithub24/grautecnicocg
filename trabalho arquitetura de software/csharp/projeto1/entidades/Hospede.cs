using System;
using Enums;

namespace Dominios {
	
	public class Hospede
	{
		public string nome;
		public string telefone;
		public DateTime datanasc;
		public string numerodocumento;
		public Tipodedocumento tipodedocumento; 
		
		public Hospede 
		(
			string nome, 
			string telefone,
			DateTime datanasc,
			string numerodocumento,
			Tipodedocumento tipodedocumento
		)
		{
			this.nome =nome;
			this.telefone=telefone;
			this.datanasc=datanasc;
			this.numerodocumento=numerodocumento;
			this.tipodedocumento=tipodedocumento;
		}
	}
}
