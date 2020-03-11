using System;
using System.Collections.Generic;
using System.Text;

namespace AULA1.Negocio
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public ListaDeLeitura Lista { get; set; }
        public int IDictionary { get; internal set; }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Livro");
            stringBuilder.AppendLine("*****");
            stringBuilder.AppendLine($"Titulo: {Titulo}");
            stringBuilder.AppendLine($"Autor: {Autor}");
            stringBuilder.AppendLine($"Lista: {Lista.Titulo}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }
}
