using System.Collections.Generic;
using Enums;

namespace Dominios {
	
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
}