namespace paineldecarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Fusca", 1975);

            Console.WriteLine($"Velocidade inicial do {carro.Modelo}: {carro.Velocidade} km/h");

            carro.Acelerar();
            Console.WriteLine($"Velocidade após acelerar: {carro.Velocidade} km/h");

            carro.Frear();
            Console.WriteLine($"Velocidade após frear: {carro.Velocidade} km/h");

            // Tentando frear novamente para garantir que a velocidade não se torne negativa
            carro.Frear();
            Console.WriteLine($"Velocidade após tentar frear novamente: {carro.Velocidade} km/h");
        }
    }
}