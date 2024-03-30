using System;
using System.Collections.Generic;

namespace Dominios {
	
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
}