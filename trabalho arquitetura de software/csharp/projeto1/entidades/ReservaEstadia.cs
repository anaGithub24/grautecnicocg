using System;
using System.Collections.Generic;

namespace Dominios { 

	public class ReservaEstadia 
	{
		public string descricao;
		public DateTime datainicio;
		public DateTime datafim;
		
		//1:1 com Conta
		public Conta conta;
		
		//1:N com Acomodacao, Hospede e Avaliacao
		public List<Acomodacao> acomodacoes;
		public List<Hospede> hospedes;
		public List<Avaliacao> avaliacoes;
		
		public ReservaEstadia
		(
			string descricao, 
			DateTime datainicio,
			DateTime datafim,
			Conta conta,
			List<Acomodacao> acomodacoes,
			List<Hospede> hospedes,
			List<Avaliacao> avaliacoes
		)
		{
			this.descricao = descricao;
			this.datainicio = datainicio;
			this.datafim = datafim;
			this.conta = conta;
			this.acomodacoes = acomodacoes;
			this.hospedes = hospedes;
			this.avaliacoes = avaliacoes;
		}
	}
}
