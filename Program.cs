using EspacioCalculadora;
Console.WriteLine("||PROBANDO CALCULADORA||");
Calculadora miCalculadora=new Calculadora();
int seguir=1;
int operacion;
double numero;
while(seguir==1){
    Console.WriteLine("ELIJA UNA OPERACION QUE QUIERA REALIZAR\n1:SUMAR\n2:RESTAR\n3:MULTIPLICAR\n4:DIVIDIR\n5:LIMPIAR");
    do{
        operacion=int.Parse(Console.ReadLine());
        if(operacion<1 || operacion>5){
            Console.WriteLine("OPERACION INCORRECTA, SELECCIONE UN NUMERO DEL 1 AL 5");
        }
    }while(operacion<1 || operacion>5);
    if(operacion!=5){
        Console.WriteLine("ELIJA UN NUMERO PARA OPERAR");
        do{
            numero=double.Parse(Console.ReadLine());
            if(operacion==4 && numero==0){
                Console.WriteLine("NO SE PUEDE REALIZAR UNA DIVISION CUYO DIVIDENDO SEA 0, CAMBIE EL NUMERO");
            }
        }while(operacion==4 && numero==0);
        switch(operacion){
            case 1:
                miCalculadora.Sumar(numero);
            break;
            case 2:
                miCalculadora.Restar(numero);
            break;
            case 3:
                miCalculadora.Multiplicar(numero);
            break;
            case 4:
                miCalculadora.Dividir(numero);
            break;
        }
        Console.WriteLine($"Resultado:{miCalculadora.resultado}");
    }else{
        miCalculadora.Limpiar();
        Console.WriteLine($"DATO LIMPIADO. DATO={miCalculadora.resultado}");
    }
    Console.WriteLine("¿DESEA SEGUIR OPERANDO?\n1:SI\n2:NO");
    do{
        seguir=int.Parse(Console.ReadLine());
        if(seguir<1 || seguir>2){
            Console.WriteLine("OPCION INCORRECTA, SELECCIONE 1 O 2");
        }
    }while(seguir<1 || seguir>2);
    Console.WriteLine("|| HISTORIAL DE OPERACIONES ||");
    foreach(var op in miCalculadora.Historial){
        Console.WriteLine($"Resultado anterior: {op.ResultadoAnterior}, Nuevo valor: {op.NuevoValor}, Operacion: {op.TipoDeOperacion}, Resultado: {op.Resultado}");
    }
}