using Calculadora_de_GPA.Avaliacao;

notas notasClasse = new notas();

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + calcularNota.CalcularMedia(notasClasse.sophia));
Console.WriteLine("Nicolas:\t" + calcularNota.CalcularMedia(notasClasse.nicolas));
Console.WriteLine("Zahirah:\t" +calcularNota.CalcularMedia(notasClasse.zahirah));
Console.WriteLine("Jeong:\t\t" + calcularNota.CalcularMedia(notasClasse.jeong));