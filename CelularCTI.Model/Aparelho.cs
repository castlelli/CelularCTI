using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Aparelho
    {
        private Int64 id_aparelho;
        private string modelo;
        private Fabricante fabricante;
        private double espessura;
        private double altura;
        private double largura;
        private double peso;
        private double quantidade; //SEMPRE double para estoque
        private decimal preco; //Decimal para campos monetários (JAVA e C#)
        private decimal desconto;

        //Encapsulamentos 
        public Int64 Id_Aparelho { get; set; }
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        public double Espessura { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Quantidade { get; set; }
        public string Modelo { get; set; }
        public decimal Preco 
        {    get 
                { return preco; }
            //Não fazer o get/set "Na preguiça" pra ser possível pôr mais código além da atribuição 
             set 
                {
                if (value > 0)
                    preco = value;
                else //O teste de erro que evita que tenha que ter if's na aplicação!
                    throw new Exception("O campo Preço do Produto não pode ser negativo.");
                } 
        }
        public decimal Desconto { get; set; }

        //Sobrescrever método ToString original (Que mostra o objeto, não as informãções do jeito que eu quero).
        public override string ToString()
        {
            return Fabricante.Nome + " " + Modelo + " - " + Preco.ToString("C") + " (" + Quantidade + " em estoque)"; //ToString("C") -> Transforma a string em currency, na moeda do sistema operacional. 
            //.PadRight ou Left -> Ajuda a formatar como será exibido na ListBox
        }


    }
}
