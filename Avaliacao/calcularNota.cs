using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Calculadora_de_GPA.Avaliacao
{
    public class calcularNota
    {
        private notas quantidadeNotas = new notas();
        public static string CalcularMedia(int[] notas)
        {
            int somaSomada = 0;
            foreach (int soma in notas)
            {
                somaSomada += soma;
            }

            double total = (double)somaSomada / notas.Length;

            //Verificar a letra da nota correspondente
            string letraNota;
            var valorLetrasTuplas = new (double nota, string Grade)[]
            {
                (96, "A+"),
                (92, "A"),
                (89, "A-"),
                (86, "B+"),
                (82, "B"),
                (79, "B-"),
                (76, "C+"),
                (72, "C"),
                (69, "C-"),
                (66, "D+"),
                (62, "D"),
                (59, "D-"),
            };
            letraNota = "F";
            foreach (var t in valorLetrasTuplas)
            {
                if (total > t.nota)
                {
                    letraNota = t.Grade;
                    break;
                }
            }
            

            return $"{total} {letraNota}";
        }
    }
}

