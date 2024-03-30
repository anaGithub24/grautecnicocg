from dataclasses import dataclass
from typing import Optional
from datetime import datetime
from oferta import Oferta;
from acomodacao import Acomodacao;

 
@dataclass
class Hotel:
    nome: str
    endereco: str
    cadeiadohotel: Optional[str] = None 
    contadeparceiro: str
    ofertas: list[Oferta]
    acomodacoes: list[Acomodacao]