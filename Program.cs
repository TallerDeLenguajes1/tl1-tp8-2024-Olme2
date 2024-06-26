using Tareas;
Random random=new Random();
string descripcionBuscada;
int cantidad=random.Next(1,10);
Console.WriteLine($"Se generaran {cantidad} Tareas pendientes");
List<Tarea> tareasPendientes=Tarea.GenerarTareasAleatorias(cantidad);
List<Tarea> tareasRealizadas=[];
Console.WriteLine("|| TAREAS PENDIENTES ||");
foreach(var tarea in tareasPendientes){
    Console.WriteLine($"ID: {tarea.Id}\nDESCRIPCION: {tarea.Descripcion}\nDURACION: {tarea.Duracion}\n");
}
while(true){
    Console.WriteLine("Escriba la descripcion de la tarea que quiere encontrar (escriba 0 si quiere terminar)");
    descripcionBuscada=Console.ReadLine();
    if(descripcionBuscada=='0'.ToString()){
        break;
    }
    Tarea tarea=tareasPendientes.Find(t=>t.Descripcion.ToString().ToLower()==descripcionBuscada.ToLower());
    if(tarea!=null){
        Console.WriteLine($"|| TAREA ENCONTRADA ||\nID: {tarea.Id}\nDESCRIPCION: {tarea.Descripcion}\nDURACION: {tarea.Duracion}");
    }else{
        Console.WriteLine("Tarea no encontrada");
    }
}
while(true){
    Console.WriteLine("Escriba la id de la tarea que quiere mover como realizada (escriba 0 si quiere terminar)");
    if(int.TryParse(Console.ReadLine(), out int id) && id==0){
        break;
    }
    Tarea tarea=tareasPendientes.Find(t=>t.Id==id);
    if(tarea!=null){
        tareasPendientes.Remove(tarea);
        tareasRealizadas.Add(tarea);
        Console.WriteLine($"Tarea {id} marcada como realizada");
    }else{
        Console.WriteLine("Tarea no encontrada");
    }
}
Console.WriteLine("|| TAREAS PENDIENTES ||");
foreach(var tarea in tareasPendientes){
    Console.WriteLine($"ID: {tarea.Id}\nDESCRIPCION: {tarea.Descripcion}\nDURACION: {tarea.Duracion}\n");
}
Console.WriteLine("|| TAREAS REALIZADAS ||");
foreach(var tarea in tareasRealizadas){
    Console.WriteLine($"ID: {tarea.Id}\nDESCRIPCION: {tarea.Descripcion}\nDURACION: {tarea.Duracion}\n");
}