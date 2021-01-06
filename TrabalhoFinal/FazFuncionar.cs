using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class FazFuncionar
    {
        public String NumeroDeSerie { get; set; }

        public decimal ID { get; set; }

        public String Peça { get; set; }

        public decimal IDCategoria { get; set; }

        public String ValorCompra { get; set; }

        public decimal MargemLucro { get; set; }

        public decimal Imposto { get; set; }

        public FazFuncionar()
        {

            NumeroDeSerie = String.Empty;
            ID = 0;
            Peça = String.Empty;
            IDCategoria = 0;
            ValorCompra = String.Empty;
            MargemLucro = 0;
            Imposto = 0;
        }

        public FazFuncionar(string registro)
        {
            // 0         1         2        3            4           5           6
            //Nro Serie;ID;Nome da peça;ID Categoria;Valor Compra;Margem Lucro;Impostos
            NumeroDeSerie = PegaCampo(registro, 0);
            ID = CampoDecimal(PegaCampo(registro, 1));
            Peça = PegaCampo(registro, 2);
            IDCategoria = CampoDecimal(PegaCampo(registro, 3));
            ValorCompra = PegaCampo(registro, 4);
            MargemLucro = CampoDecimal(PegaCampo(registro, 5));
            Imposto = CampoDecimal(PegaCampo(registro, 6));

        }

        private char CampoChar(string campo)
        {
            
            
           
            char valorRetorno = Convert.ToChar(campo);
     

            return valorRetorno;
        }

        private decimal CampoDecimal(string campo)
        {
            decimal valorRetorno = 0;

            try
            {
                valorRetorno = decimal.Parse(campo);
            }
            catch
            {
            }

            return valorRetorno;
        }

        private long CampoLong(string campo)
        {
            long valorRetorno = 0;

            try
            {
                valorRetorno = long.Parse(campo);
            }
            catch
            {
            }

            return valorRetorno;
        }

        private string PegaCampo(string registro, int indice)
        {
            string valorRetorno = string.Empty;

            string[] campos = registro.Split(';');

            if (indice <= campos.Length)
            {
                valorRetorno = campos[indice].Trim().Replace('.', ',');
            }

            return valorRetorno;
        }
    }
}
