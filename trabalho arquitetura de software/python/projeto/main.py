from dataclasses import dataclass
from datetime import datetime
from hotel import Hotel;
from oferta import Oferta;
from acomodacao import Acomodacao;

def main():
    formato = "%d-%m-%Y %H:%M:%S"

    datadeexpiracao1 = datetime.strptime("30-09-2023 23:59:59", formato)
    oferta1 = Oferta("30% de desconto nesse inverno", datadeexpiracao1)

    datadeexpiracao2 = datetime.strptime("31-12-2023 23:59:59", formato)
    oferta2 = Oferta("15% até o fim do ano", datadeexpiracao2)
    
    quarto1 = Acomodacao("quarto solteiro")
    quarto2 = Acomodacao("quarto casal")
    
    listaDeAcomodacoes = []
    listaDeAcomodacoes.append(quarto1)
    listaDeAcomodacoes.append(quarto2)

    listaDeOfertas = []
    listaDeOfertas.append(oferta1)
    listaDeOfertas.append(oferta2)

    hotel1 = Hotel(nome="Hotel Ibis", endereco="Rua XYZ", contadoparceiro="conta 1", ofertas=listaDeOfertas, acomodacoes=listaDeAcomodacoes)
    print(hotel1.ofertas)
    print(hotel1.acomodacoes)

if __name__ == "__main__":
    main()
    
