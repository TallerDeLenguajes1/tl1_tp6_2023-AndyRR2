using System;
using System.Text.RegularExpressions;
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

//#2 CalculadoraV1
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

//#3 CalculadoraV2
/*string? entrada1,entrada2;
float a, b, opcion;
bool resultado;
Console.WriteLine("CalculadoraV2: ");
Console.WriteLine("Entre un numero");
entrada1 = Console.ReadLine();
resultado = float.TryParse(entrada1,out a);
while (resultado==false){
    Console.WriteLine("Numero invalido");
    Console.WriteLine("Entre un numero: ");
    entrada1 = Console.ReadLine();
    resultado = float.TryParse(entrada1,out a);
}
Console.WriteLine("Menu:");
Console.WriteLine("1-Valor absoluto");
Console.WriteLine("2-Cuadrado");
Console.WriteLine("3-Raiz cuadrada");
Console.WriteLine("4-Seno");
Console.WriteLine("5-Coseno");
Console.WriteLine("6-Parte entrea");
Console.WriteLine("Otro-Cerrar");
float.TryParse(Console.ReadLine(),out opcion);
while (opcion!=0){
    switch (opcion){  
        case 1: if(a<0){
                Console.WriteLine(-1*a);
                }else{
                    Console.WriteLine(a);
                };
        break;
        case 2: Console.WriteLine(a*a);break;
        case 3: Console.WriteLine(Math.Sqrt(a));break;
        case 4: Console.WriteLine(Math.Sin(a));break;
        case 5: Console.WriteLine(Math.Cos(a));break;
        case 6: Console.WriteLine(Convert.ToInt32(a));break;
    }    
    Console.WriteLine("Ver maximo y minimo: ");
    Console.WriteLine("Entre un numero");
    entrada1 = Console.ReadLine();
    resultado = float.TryParse(entrada1,out a);
    while (resultado==false){
    Console.WriteLine("Numero invalido");
    Console.WriteLine("Entre un numero: ");
    entrada1 = Console.ReadLine();
    resultado = float.TryParse(entrada1,out a);
    }
    Console.WriteLine("Entre el segundo numero");
    entrada2 = Console.ReadLine();
    resultado = float.TryParse(entrada2,out b);
    while (resultado==false){
        Console.WriteLine("Numero invalido");
        Console.WriteLine("Entre el segundo numero");
        entrada2 = Console.ReadLine();
        resultado = float.TryParse(entrada2,out b);
    }
    Console.WriteLine("Maximo: " + Math.Max(a,b));
    Console.WriteLine("Minimo: " + Math.Min(a,b));
    Console.WriteLine("CalculadoraV2: ");
    Console.WriteLine("Entre un numero");
    entrada1 = Console.ReadLine();
    resultado = float.TryParse(entrada1,out a);
    while (resultado==false){
        Console.WriteLine("Numero invalido");
        Console.WriteLine("Entre un numero: ");
        entrada1 = Console.ReadLine();
        resultado = float.TryParse(entrada1,out a);
    }
    Console.WriteLine("Menu:");
    Console.WriteLine("1-Valor absoluto");
    Console.WriteLine("2-Cuadrado");
    Console.WriteLine("3-Rauz cuadrada");
    Console.WriteLine("4-Seno");
    Console.WriteLine("5-Coseno");
    Console.WriteLine("6-Parte entrea");
    Console.WriteLine("Otro-Cerrar");
    float.TryParse(Console.ReadLine(),out opcion);
}
Console.WriteLine("Cerrado");*/

//#4 Strings
string? cadena, cadena2, concatenada, subcadena, palabra;
int buscada;
Console.WriteLine("Entre una cadena: ");
cadena = Console.ReadLine();
while ((cadena is null)||cadena==""){
    Console.WriteLine("La cadena esta vacia");
    Console.WriteLine("Entre una cadena: ");
    cadena = Console.ReadLine();
}
Console.WriteLine("Entre otra cadena: ");
cadena2 = Console.ReadLine();
while ((cadena2 is null)||cadena2==""){
    Console.WriteLine("La cadena esta vacia");
    Console.WriteLine("Entre otra cadena: ");
    cadena2 = Console.ReadLine();
}
concatenada = cadena + " " + cadena2;
Console.WriteLine("Cadenas concatenadas: " + concatenada);
subcadena = concatenada.Substring(5);
Console.WriteLine("Subcadena: " + subcadena);
int num1=2, num2= 7;
int result= num1 + num2;
Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual a: " + result);
foreach (var letra in concatenada){
    Console.WriteLine(letra);
}
palabra="Hola";
buscada = concatenada.IndexOf(palabra);
if (buscada==-1){
    Console.WriteLine("La cadena no contiene la palabra");
}else{
    Console.WriteLine("La cadena contiene la palabra {0} en la posicion {1}",palabra,buscada);
}
Console.WriteLine("Cadena en mayuscula: " + concatenada.ToUpper());
Console.WriteLine("Cadena en minuscula: " + concatenada.ToLower());
Console.WriteLine("Entre una cadena separada por caracteres: ");
cadena=Console.ReadLine();
while ((cadena is null)||cadena==""){
    Console.WriteLine("La cadena esta vacia");
    Console.WriteLine("Entre una cadena: ");
    cadena = Console.ReadLine();
}
Console.WriteLine("Cadena entrada: " + cadena);
string[] cadenaConSplit=cadena.Split(" ");
foreach (var subc in cadenaConSplit){
    Console.WriteLine(subc);
}
string? a = "582", b = "2";
Console.WriteLine("582 + 2 = " + (int.Parse(a)+int.Parse(b)));

//#5
Console.WriteLine("Entre una nueva cadena: ");
cadena = Console.ReadLine();
while ((cadena is null)||cadena==""){
    Console.WriteLine("La cadena esta vacia");
    Console.WriteLine("Entre una cadena: ");
    cadena = Console.ReadLine();
}

bool coincidencia1 = Regex.IsMatch(cadena,@"\bhttp://\b");
bool coincidencia2 = Regex.IsMatch(cadena,@"\bhttps://\b");
bool coincidencia3 = Regex.IsMatch(cadena,@"\@\b");
if (coincidencia1||coincidencia2){
    Console.WriteLine("La cadena ingresada es una direccion web");
}else if (coincidencia3)
{
    Console.WriteLine("La cadena ingresada es un correo");
}