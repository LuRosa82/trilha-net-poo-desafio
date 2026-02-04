using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do aplicativo é obrigatório.", nameof(nome));
            Console.WriteLine($"Instalando aplicativo \"{nome}\" via Microsoft Store no Nokia...");
        }
    }
}