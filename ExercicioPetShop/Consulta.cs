namespace ExercicioPetShop
{
    internal class Consulta
    {
        public Consulta(string data, string motivo, Pet pet, Medico medico)
        {
            Data = data;
            Motivo = motivo;
            this.pet = pet;
            this.medico = medico;
        }

        public string Data { get; }
        public string Motivo { get; }
        public Pet pet { get; }
        public Medico medico { get; }
        
    }
}
