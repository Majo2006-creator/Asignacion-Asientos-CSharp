namespace AsignacionAsientos
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
