namespace Tareas{
    public enum Descripciones{
        Limpiar,
        Gestionar,
        Configurar,
        Ordenar,
        Organizar,
        Asignar,
        Agendar,
        Escribir,
        Manejar,
        Calcular

    };
    public class Tarea{
        public int Id;
        public Descripciones Descripcion;
        public int Duracion;
        public Tarea(int id, Descripciones descripcion, int duracion){
            Id = id;
            Descripcion = descripcion;
            Duracion = duracion;
        }
        public static List<Tarea> GenerarTareasAleatorias(int cantidad){
            List<Tarea> tareas=new List<Tarea>();
            Random random=new Random();
            for(int i=0; i<cantidad; i++){
                Descripciones Descripcion=(Descripciones)random.Next(Enum.GetValues(typeof(Descripciones)).Length);
                int duracion=random.Next(1,101);
                tareas.Add(new Tarea(i+1, Descripcion, duracion));
            }
        return tareas;
        }
        }
}