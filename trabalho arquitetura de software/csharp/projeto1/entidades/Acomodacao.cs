using System;

namespace Dominios { 

	public class Acomodacao 
	{
		public string descricao;
		
		//1:1 com Oferta
		public Oferta oferta;
		
		public Acomodacao
		(
			string descricao, 
			Oferta oferta
		)
		{
			this.descricao = descricao;
			this.oferta = oferta;
		}
	}
}
