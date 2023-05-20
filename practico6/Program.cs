//#1
/*string? numero;
int n, aux, invertido=0, resto;
bool resultado;
Console.WriteLine("Ingrese un numero: ");
numero = Console.ReadLine();
resultado = int.TryParse(numero,out n);
aux=n;
if (resultado){
    if (aux>0){
        while (aux>0){
            resto=aux%10;
            aux=aux/10;
            invertido = invertido*10 + resto;    
        }
        Console.WriteLine("Numero original: ");
        Console.WriteLine(n);
        Console.WriteLine("Numero invertido: ");
        Console.WriteLine(invertido);
    }else{
        Console.WriteLine("Numero invalido");
    }
}else{
    Console.WriteLine("Numero invalido");
}*/

//#2
/*string? entrada1,entrada2;
float a, b, opcion;
Console.WriteLine("Menu:");
Console.WriteLine("1-Suma");
Console.WriteLine("2-Resta");
Console.WriteLine("3-Producto");
Console.WriteLine("4-Cociente");
Console.WriteLine("Otro-Cerrar");
float.TryParse(Console.ReadLine(),out opcion);//entra una linea y automaticamente la guarda en opcion como float
while (opcion!=0){
    Console.WriteLine("Entre el primer numero");
    entrada1 = Console.ReadLine();
    Console.WriteLine("Entre el segundo numero");
    entrada2 = Console.ReadLine();
    if (float.TryParse(entrada1,out a) && float.TryParse(entrada2,out b)){
    switch (opcion){  
        case 1: Console.WriteLine(a+b);break;
        case 2: Console.WriteLine(a-b);break;
        case 3: Console.WriteLine(a*b);break;
        case 4: Console.WriteLine(a/b);break;
    }    
    }else{
        Console.WriteLine("Alguno de los numeros ingresados es incorrecto: ");
    }
    Console.WriteLine("Menu:");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Producto");
    Console.WriteLine("4-Cociente");
    Console.WriteLine("0-Cerrar");
    float.TryParse(Console.ReadLine(),out opcion);
}
Console.WriteLine("Cerrado");*/