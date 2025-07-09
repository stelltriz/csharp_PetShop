
using ExercicioPetShop;

Dono dono1 = new("Ana", "123456");
Pet pet1 = new("Totó", "Vira-lata", 5, dono1);

dono1.AdicionarPet(pet1);

Medico medico1 = new("Fulano", "Cachorro");

Consulta consulta1 = new("01/02/2025", "Comeu chocolate", pet1, medico1);

medico1.AtenderPet(consulta1);

