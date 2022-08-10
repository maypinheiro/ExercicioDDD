using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDDD
{
    class Ddd
    {


        public string VerificaDDD(int ddd)
        {
                 if (ddd == 61) return ("Brasilia");
            else if (ddd == 71)return("Salvador");
            else if (ddd == 11) return("São Paulo");
            else if (ddd == 21) return("Rio de Janeiro");
            else if (ddd == 32) return("Juíz de Fora");
            else if (ddd == 19) return("Campinas");
            else if (ddd == 31) return("Belo Horizonte");
            else return("DDD não cadastrado");
        }
    }
}
