using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = ValidateNonEmpty(numero, nameof(numero));
            _modelo = ValidateNonEmpty(modelo, nameof(modelo));
            _imei   = ValidateNonEmpty(imei,   nameof(imei));
            if (memoria <= 0)
                throw new ArgumentOutOfRangeException(nameof(memoria), "Memória deve ser maior que zero.");
            _memoria = memoria;
        }

        public void Ligar() => Console.WriteLine("Ligando...");
        public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");
        public abstract void InstalarAplicativo(string nome);

        protected static string ValidateNonEmpty(string valor, string paramName)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException($"O parâmetro {paramName} é obrigatório.", paramName);
            return valor.Trim();
        }

        // (opcional) getters de leitura
        public string ObterModelo() => _modelo;
        public string ObterIMEI()   => _imei;
        public int ObterMemoria()   => _memoria;
    }
}
