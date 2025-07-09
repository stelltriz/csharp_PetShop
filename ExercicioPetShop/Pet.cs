namespace ExercicioPetShop
{
    internal class Pet
    {
        public Pet(string nome, string especie, int idade, Dono dono)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            this.dono = dono;
        }

        public string Nome { get; }
        public string Especie { get; }
        public int Idade { get; }
        public Dono dono { get; }
        public List<Consulta> Consultas { get; } = new();

        public void AdicionarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }

    }
}
