namespace ExercicioPetShop
{
    internal class Dono
    {
        public Dono(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public string Nome { get; }
        public string Telefone { get; }
        public List<Pet> Pets { get; } = new();

        public void AdicionarPet(Pet pet)
        {
            Pets.Add(pet);
        }

    }
}
