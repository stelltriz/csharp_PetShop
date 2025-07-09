namespace ExercicioPetShop
{
    internal class Medico
    {
        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; }
        public string Especialidade { get; }
        public List<Consulta> Consultas { get; } = new();

        public void AtenderPet(Consulta consulta)
        {
            Consultas.Add(consulta);
        }
    }
}
