public class Bicicleta : Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo): base(marca, modelo)
    {

    }

    public void Acelerar()
    {
        Console.WriteLine($"A bicicleta da {Marca} e modelo {Modelo} esta pedalando mais rapido");
    }
    public override void Ligar()
    {
        Console.WriteLine($"A bicicleta esta prota para o uso");
    }
}