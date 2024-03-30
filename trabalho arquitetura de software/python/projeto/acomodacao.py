from dataclasses import dataclass
from typing import Optional
from datetime import datetime
from oferta import Oferta;
 
@dataclass
class Acomodacao:
    descricao: str
    oferta: Optional[Oferta] = None