using System;

namespace Dominios {
	
	public class Oferta
	{
		public string descricao;
		public DateTime datainicio;
		public DateTime datafim;
		
		public Oferta 
		(
			string descricao, 
			DateTime datainicio,
			DateTime datafim
		)
		{
			this.descricao = descricao;
			this.datainicio = datainicio;
			this.datafim = datafim;
		}
	}
}
