using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProdutoModelo
    {
        private int id_tamanho;
      public enum tamanho {broto, media, grande, gigante};
        private int quant_sabores;
        private int idsabor;
        private string desc_sabor;
        private decimal valor_broto;
        private decimal valor_media;
        private decimal valor_grande;
        private decimal valor_gigante;
        private int id_Bebida;
        private string desc_Bebida;
        private string volume_Bebida;
        private decimal valor_Bebida;



        public ProdutoModelo()
        {
            this.id_tamanho = 0;
            this.quant_sabores = 0;
            this.idsabor = 0;
            this.desc_sabor = "";
            this.valor_broto = 0;
            this.valor_media = 0;
            this.valor_grande = 0;
            this.valor_gigante = 0;
            this.id_Bebida = 0;
            this.desc_Bebida = "";
            this.volume_Bebida = "";
            this.valor_Bebida = 0;

          

        }

        public int idBebida
        {
            get { return id_Bebida; }
            set { id_Bebida = value; }
        }
        public string descBebida
        {
            get { return desc_Bebida; }
            set { desc_Bebida = value; }
            
        }
        public string volumeBebida
        {
            get { return volume_Bebida; }
            set { volume_Bebida = value; }
        }
        public decimal valorBebida
        {
            get { return valor_Bebida; }
            set { valor_Bebida = value; }   
        }

        public int codigo
        {
            get {return idsabor;}
            set {idsabor = value;}  
        }
      

        
        public int qtdsabores
        {
            get {return quant_sabores;}
            set {quant_sabores = value; }
        }
        public int idsabores
        {
            get {return idsabor;}
            set{ idsabor = value;}
        }
        public string descricaosabor
        {
            get {return desc_sabor;}
            set{desc_sabor = value;}
        }
        public decimal valorBroto
        {
            get {return valor_broto;}
            set { valor_broto=value;}
        }
        public decimal valorMedia
        {
            get {return valor_media;}
            set { valor_media = value;}
        }
        public decimal valorGrande
        {
              get {return valor_grande;}
              set { valor_grande = value;}
        }
        public decimal valorGigante 
        {
            get { return valor_gigante;}
            set { valor_gigante = value; }
        
        }
    }
}
