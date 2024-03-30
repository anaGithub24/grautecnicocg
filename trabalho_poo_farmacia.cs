using System;
using System.Collections.Generic;

public class produto
{
	public int codigo;
	public string nome;
	public int preco;
	
	public produto (int codigo, string nome, int preco)
	{ 
		this.codigo = codigo;
		this.nome = nome ;
		this.preco = preco;
	}
	
}

public class farmacia
{
	public string nome ;
	public string endereco;
	public string telefone ;
	public List<produto> listadeprodutos;
	
	public farmacia(string nome ,string endereco,string telefone, List<produto> listadeprodutos)
	{
		this.nome=nome ;
		this.endereco=endereco;
		this.telefone=telefone;
		this.listadeprodutos=listadeprodutos;
	}

}
					
public class Program
{
	public static void Main()
	{
		// criando os produtos da farmacia
		produto prod1 = new produto(1,"vitamina c" ,10);
		produto prod2 = new produto(2,"vitamina c" ,10);
		produto prod3 = new produto(3,"vitamina c" ,10);
		produto prod4 = new produto(4,"vitamina c" ,10);
		produto prod5 = new produto(5,"vitamina c" ,10);
		produto prod6 = new produto(6,"vitamina c" ,10);
		produto prod7 = new produto(7,"vitamina c" ,10);
		produto prod8 = new produto(8,"vitamina c" ,10);
		produto prod9 = new produto(9,"vitamina c" ,10);
		produto prod10 = new produto(10,"vitamina c" ,10);
		produto prod11 = new produto(11,"vitamina c" ,10);
		produto prod12 = new produto(12,"vitamina c" ,10);
		produto prod13 = new produto(13,"vitamina c" ,10);
		produto prod14 = new produto(14,"vitamina c" ,10);
		produto prod15 = new produto(15,"vitamina c" ,10);
		produto prod16 = new produto(16,"vitamina c" ,10);
		produto prod17 = new produto(17,"vitamina c" ,10);
		produto prod18 = new produto(18,"vitamina c" ,10);
		produto prod19 = new produto(19,"vitamina c" ,10);
		produto prod20 = new produto(20,"vitamina c" ,10);
		produto prod21 = new produto(21,"vitamina c" ,10);
		produto prod22 = new produto(22,"vitamina c" ,10);
		produto prod23 = new produto(23,"vitamina c" ,10);
		produto prod24 = new produto(24,"vitamina c" ,10);
		produto prod25 = new produto(25,"vitamina c" ,10);
		produto prod26 = new produto(26,"vitamina c" ,10);
		produto prod27 = new produto(27,"doril" ,6);		
		produto prod28 = new produto(28,"doril" ,6);
		produto prod29 = new produto(29,"doril" ,6);	 
		produto prod30 = new produto(30,"doril" ,6);		
		produto prod31 = new produto(31,"doril" ,6);   
		produto prod32 = new produto(32,"doril" ,6);		
		produto prod33 = new produto(33,"doril" ,6);
		produto prod34 = new produto(34,"doril" ,6);
		produto prod35 = new produto(35,"doril" ,6);
		produto prod36 = new produto(36,"doril"  ,6);
		produto prod37 = new produto(37,"doril" ,6);
		produto prod38 = new produto(38,"doril" ,6);
		produto prod39 = new produto(39,"doril" ,6);
		produto prod40 = new produto(40,"doril" ,6);	
		produto prod41 = new produto(41,"doril" ,6);
		produto prod42 = new produto(42,"doril" ,6);
		produto prod43 = new produto(43,"doril" ,6);
		produto prod44 = new produto(44,"doril" ,6);
		produto prod45 = new produto(45,"doril" ,6);
		produto prod46 = new produto(46,"doril" ,6);
		produto prod47 = new produto(47,"doril" ,6);
		produto prod48 = new produto(48,"doril" ,6);
		produto prod49 = new produto(49,"doril" ,6);
		produto prod50 = new produto(50,"doril" ,6);
		produto prod51 = new produto(51,"doril" ,6);
		produto prod52 = new produto(52,"doril" ,6);
		produto prod53 = new produto(53,"doril" ,6);
		produto prod54 = new produto(54,"doril" ,6);
		produto prod55 = new produto(55,"doril" ,6);
		produto prod56 = new produto(56,"doril" ,6);
		produto prod57 = new produto(57,"doril" ,6);
		produto prod58 = new produto(58,"doril" ,6);
		produto prod59 = new produto(59,"doril" ,6);
		produto prod60 = new produto(60,"doril" ,6);
		produto prod61 = new produto(61,"doril" ,6);
		produto prod62 = new produto(62,"doril" ,6);
		produto prod63 = new produto(63,"doril" ,6);
		produto prod64 = new produto(64,"doril" ,6);
		produto prod65 = new produto(65,"doril" ,6);
		produto prod66 = new produto(66,"doril" ,6);
		produto prod67 = new produto(67,"doril" ,6);
		produto prod68 = new produto(68,"doril" ,6);		
		produto prod69 = new produto(69,"doril" ,6);		
		produto prod70 = new produto(70,"doril" ,6);
		produto prod71 = new produto(71,"doril" ,6);
		produto prod72 = new produto(72,"doril" ,6);
		produto prod73 = new produto(73,"doril" ,6);
		produto prod74 = new produto(74,"doril" ,6);
		produto prod75 = new produto(75,"doril" ,6);
		produto prod76 = new produto(76,"doril" ,6);
		produto prod77 = new produto(77,"doril" ,6);
		produto prod78 = new produto(78,"doril" ,6);
		produto prod79 = new produto(79,"doril" ,6);
		produto prod80 = new produto(80,"koide"  ,35);
		produto prod81 = new produto(81,"koide"  ,35);
		produto prod82 = new produto(82,"koide"  ,35);
		produto prod83 = new produto(83,"koide"  ,35);
		produto prod84 = new produto(84,"koide"  ,35);
		produto prod85 = new produto(85,"koide"  ,35);
		produto prod86 = new produto(86,"koide"  ,35);
		produto prod87 = new produto(87,"koide"  ,35);
		produto prod88 = new produto(88,"koide"  ,35);
		produto prod89 = new produto(89,"koide"  ,35);
		produto prod90 = new produto(90,"koide"  ,35);
		produto prod91 = new produto(91,"koide"  ,35);
		produto prod92 = new produto(92,"koide"  ,35);
		produto prod93 = new produto(93,"koide"  ,35);
		produto prod94 = new produto(94,"koide"  ,35);
		produto prod95 = new produto(95,"koide"  ,35);
		produto prod96 = new produto(96,"koide"  ,35);
		produto prod97 = new produto(97,"koide"  ,35);
		produto prod98 = new produto(98,"koide"  ,35);
		produto prod99 = new produto(99,"koide"  ,35);
		produto prod100 = new produto(100,"koide"  ,35);
		
		//criando lista de produtos
		List<produto> listadeprodutos = new List<produto>();
		listadeprodutos.Add(prod1);
		listadeprodutos.Add(prod2);
		listadeprodutos.Add(prod3);
		listadeprodutos.Add(prod4);
		listadeprodutos.Add(prod5);
		listadeprodutos.Add(prod6);
		listadeprodutos.Add(prod7);
		listadeprodutos.Add(prod8);
		listadeprodutos.Add(prod9);
		listadeprodutos.Add(prod10);
		listadeprodutos.Add(prod11);
		listadeprodutos.Add(prod12);
		listadeprodutos.Add(prod13);
		listadeprodutos.Add(prod14);
		listadeprodutos.Add(prod15);
		listadeprodutos.Add(prod16);
		listadeprodutos.Add(prod17);
		listadeprodutos.Add(prod18);
		listadeprodutos.Add(prod19);
		listadeprodutos.Add(prod20);
		listadeprodutos.Add(prod21);
		listadeprodutos.Add(prod22);
		listadeprodutos.Add(prod23);
		listadeprodutos.Add(prod24);
		listadeprodutos.Add(prod25);
		listadeprodutos.Add(prod26);
		listadeprodutos.Add(prod27);
		listadeprodutos.Add(prod28);
		listadeprodutos.Add(prod29);
		listadeprodutos.Add(prod30);
		listadeprodutos.Add(prod31);
		listadeprodutos.Add(prod32);
		listadeprodutos.Add(prod33);
		listadeprodutos.Add(prod34);
		listadeprodutos.Add(prod35);
		listadeprodutos.Add(prod36);
		listadeprodutos.Add(prod37);
		listadeprodutos.Add(prod38);
		listadeprodutos.Add(prod39);
		listadeprodutos.Add(prod40);
		listadeprodutos.Add(prod41);
		listadeprodutos.Add(prod42);
		listadeprodutos.Add(prod43);
		listadeprodutos.Add(prod44);
		listadeprodutos.Add(prod45);
		listadeprodutos.Add(prod46);
		listadeprodutos.Add(prod47);
		listadeprodutos.Add(prod48);
		listadeprodutos.Add(prod49);
		listadeprodutos.Add(prod50);
		listadeprodutos.Add(prod51);
		listadeprodutos.Add(prod52);
		listadeprodutos.Add(prod53);
		listadeprodutos.Add(prod54);
		listadeprodutos.Add(prod55);
		listadeprodutos.Add(prod56);
		listadeprodutos.Add(prod57);
		listadeprodutos.Add(prod58);
		listadeprodutos.Add(prod59);
		listadeprodutos.Add(prod60);
		listadeprodutos.Add(prod61);
		listadeprodutos.Add(prod62);
		listadeprodutos.Add(prod63);
		listadeprodutos.Add(prod64);
		listadeprodutos.Add(prod65);
		listadeprodutos.Add(prod66);
		listadeprodutos.Add(prod67);
		listadeprodutos.Add(prod68);
		listadeprodutos.Add(prod69);
		listadeprodutos.Add(prod70);
		listadeprodutos.Add(prod71);
		listadeprodutos.Add(prod72);
		listadeprodutos.Add(prod73);
		listadeprodutos.Add(prod74);
		listadeprodutos.Add(prod75);
		listadeprodutos.Add(prod76);
		listadeprodutos.Add(prod77);
		listadeprodutos.Add(prod78);
		listadeprodutos.Add(prod79);
		listadeprodutos.Add(prod80);
		listadeprodutos.Add(prod81);
		listadeprodutos.Add(prod82);
		listadeprodutos.Add(prod83);
		listadeprodutos.Add(prod84);
		listadeprodutos.Add(prod85);
		listadeprodutos.Add(prod86);
		listadeprodutos.Add(prod87);
		listadeprodutos.Add(prod88);
		listadeprodutos.Add(prod89);
		listadeprodutos.Add(prod90);
		listadeprodutos.Add(prod91);
		listadeprodutos.Add(prod92);
		listadeprodutos.Add(prod93);
		listadeprodutos.Add(prod94);
		listadeprodutos.Add(prod95);
		listadeprodutos.Add(prod96);
		listadeprodutos.Add(prod97);
		listadeprodutos.Add(prod98);
		listadeprodutos.Add(prod99);
		listadeprodutos.Add(prod100);
		
		//criando farmacia
		farmacia minhafarmacia = new farmacia("farmaciaC&A","joao inacio, 278 - PATOS","telefone 334456",listadeprodutos);
		  
	    //imprimindo lista de produtos da farmacia 
		Console.WriteLine(" .: Farmácia :. ");
		Console.WriteLine(" Nome : " + minhafarmacia.nome);
		Console.WriteLine(" ----- Produtos ----- ");
		foreach(produto p in minhafarmacia.listadeprodutos)
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("Codigo : " + p.codigo);
			Console.WriteLine("Produto : " + p.nome);
			Console.WriteLine("Preço : " + p.preco);
			Console.WriteLine("------------------------------");
		}
	
	}
}