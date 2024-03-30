from dataclasses import dataclass
from datetime import datetime

@dataclass    
class Oferta:
    descricao: str
    datadeexpiracao: datetime
    
