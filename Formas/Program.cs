using Formas;

List<FormaGeometrica> formas = new List<FormaGeometrica>();

Circulo circulo = new Circulo(12);
Retangulo retangulo = new Retangulo();

retangulo.Altura = 20;
retangulo.Lagura = 10;

formas.Add(retangulo);
formas.Add(circulo);

foreach(var forma in formas)
{
    Console.WriteLine(forma.GetType());
    Console.WriteLine(forma.CalcularArea());
    Console.WriteLine(forma.CalcularPerimetro());
}
