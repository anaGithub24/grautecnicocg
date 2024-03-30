using System;

namespace Dominios {
	
	public class Avaliacao
	{
		public int nota;
		public string comentario;
		
		public Avaliacao 
		(
			int nota,
			string comentario
		)
		{
			this.nota = nota;
			this.comentario = comentario;
		}
	}
}
