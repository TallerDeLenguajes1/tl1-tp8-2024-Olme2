namespace EspacioCalculadora{
public class Calculadora{
    private double dato;
    private List<Operacion> historial=new List<Operacion>();
    public void Sumar(double termino){
        double resultadoAnterior=dato;
        dato+=termino;
        historial.Add(new Operacion(resultadoAnterior, termino, TipoOperacion.Suma));
    }
    public void Restar(double termino){
        double resultadoAnterior=dato;
        dato-=termino;
        historial.Add(new Operacion(resultadoAnterior, termino, TipoOperacion.Resta));
    }
    public void Multiplicar(double termino){
        double resultadoAnterior=dato;
        dato*=termino;
        historial.Add(new Operacion(resultadoAnterior, termino, TipoOperacion.Multiplicacion));
    }
    public void Dividir(double termino){
        double resultadoAnterior=dato;
        dato/=termino;
        historial.Add(new Operacion(resultadoAnterior, termino, TipoOperacion.Division));
    }
    public void Limpiar(){
        historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
        dato=0;
    }
    public double resultado => dato;
    public List<Operacion> Historial => historial;
    public enum TipoOperacion{
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }
    public class Operacion{
        public double ResultadoAnterior{get;}
        public double NuevoValor{get;}
        public TipoOperacion TipoDeOperacion{get;}
        public double Resultado{get;}
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacionTipo){
            ResultadoAnterior=resultadoAnterior;
            NuevoValor=nuevoValor;
            TipoDeOperacion=operacionTipo;
            Resultado=CalcularResultado(resultadoAnterior, nuevoValor, operacionTipo);
        }
        private double CalcularResultado(double resultadoAnterior, double nuevoValor, TipoOperacion tipoOperacion){
            return TipoDeOperacion switch{
                TipoOperacion.Suma => resultadoAnterior+nuevoValor,
                TipoOperacion.Resta => resultadoAnterior-nuevoValor,
                TipoOperacion.Multiplicacion => resultadoAnterior*nuevoValor,
                TipoOperacion.Division => resultadoAnterior/nuevoValor,
                TipoOperacion.Limpiar => 0,
                _ => resultadoAnterior
            };
        }
    }
}
}