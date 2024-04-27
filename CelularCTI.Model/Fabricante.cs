using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Fabricante
    {
        //Atributo interno -> Usado dentro da classe
        private Int64 id_fabricante;
        private string nome;
        private string observacao;

        //Propriedades -> São "expostos"

   
        public Int64 Id_Fabricante
        {
            get { return id_fabricante; }
            set { id_fabricante = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        //Métodos


    }
}
