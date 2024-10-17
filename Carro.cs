public class Carro : Veiculo , IAceleravel, IFreavel
{
    public Carro(string marca, string modelo): base(marca, modelo)
    {

    }
    public override void Ligar()
    {
        Console.WriteLine($"O veiculo  de {Marca} e o modelo {Modelo}");
    }
    public void Acelerar(){
        Console.WriteLine($"O carro de modelo { Modelo} e Marca {Marca} esta acelerando");
    }
        public void Frear(){
        Console.WriteLine($"O carro de modelo { Modelo} e Marca {Marca} esta freando");
}
}