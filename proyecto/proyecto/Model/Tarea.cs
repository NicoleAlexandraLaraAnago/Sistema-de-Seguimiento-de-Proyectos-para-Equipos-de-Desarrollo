namespace proyecto.Model
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string NombreTarea { get; set;}
        public string NombreEquipo { get; set; }
        public string DescripcionTarea { get; set; }
        public Boolean Estado { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
    }
}
