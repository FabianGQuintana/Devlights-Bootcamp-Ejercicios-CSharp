//Ejercicios 1-20. Resolución Quintana Fabián.

using Devligths_ResolucionEjercicios1_20;
using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace Ejercicios
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            validarNumero validacion = new validarNumero();
            #region Ejercicio 1
            //
            // ==============
            // == Ejercicio 1
            // ==============
            // 

            //Console.WriteLine("Ingrese un numero para determinar si es negativo, positivo o 0. \n:");
            //string input = Console.ReadLine();
            //float numeroValido;
            //if (float.TryParse(input, out numeroValido))
            //{
            //    validacion.determinarValorNumero(numeroValido);
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es un numero valido.");
            //}
            #endregion

            #region Ejercicio 2
            //==============
            //== Ejercicio 2
            //==============


            //Console.WriteLine("Ingrese el primer numero:");
            //string primerNumero = Console.ReadLine();
            //Console.WriteLine("Ingrese el segundo numero:");
            //string segundoNumero = Console.ReadLine();
            //Console.WriteLine("Ingrese el tercer numero:");
            //string tercerNumero = Console.ReadLine();

            //float num1 = 0.0f, num2 = 0.0f, num3 = 0.0f;

            //if (float.TryParse(primerNumero, out num1) &&
            //   float.TryParse(segundoNumero, out num2) &&
            //   float.TryParse(tercerNumero, out num3))
            //{
            //    validacion.mayorMenor(num1, num2, num3);
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es un numero valido.");
            //}

            #endregion

            #region Ejercicio 3
            //==============
            //== Ejercicio 3
            //==============


            //Console.WriteLine("Ingrese 2 numeros para validar si son multiplos: ");
            //string numero1 = Console.ReadLine();
            //string numero2 = Console.ReadLine();

            //float num1=0.0f, num2=0.0f;

            //if(float.TryParse(numero1, out num1) && float.TryParse(numero2, out num2))
            //{
            //    Console.WriteLine("Numeros ingresados validos.");
            //    validacion.toString();
            //    validacion.sonMultiplos(num1, num2);
            //    validacion.toString();
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es un numero valido.");
            //}
            #endregion

            #region Ejercicio 4
            //==============
            //== Ejercicio 4
            //==============

            //    Console.WriteLine("Ingrese el precio del producto: ");
            //    string precioInput = Console.ReadLine();
            //    float precio = 0.0f;

            //    if (float.TryParse(precioInput, out precio))
            //    {
            //        float precioFinal = validacion.calcularPrecio(precio);
            //        validacion.toString();
            //        Console.WriteLine($"El precio final es: {precioFinal}");
            //        validacion.toString();
            //    } else
            //    {
            //        Console.WriteLine("El valor ingresado no es un numero valido.");
            //    }

            #endregion

            #region Ejercicio 5
            //==============
            //== Ejercicio 5
            //==============

            //Console.WriteLine("Ingrese un numero decimal");
            //string decimalInput = Console.ReadLine();
            //decimal numeroDecimal = 0.0m;

            //if(decimal.TryParse(decimalInput, out numeroDecimal))
            //{
            //    int numeroEntero = (int)numeroDecimal;
            //    validacion.toString();
            //    Console.WriteLine($"La parte entera del numero decimal es: {numeroEntero}");
            //    Console.WriteLine($"\nEl numero original es {numeroDecimal}");
            //    validacion.toString();
            //    Console.WriteLine("Diferencia entre ambos: C# realiza un truncamiento o" +
            //        " un 'descarte' de decimales, este redondeo genera cierta perdida de datos(se pierden los decimales)");
            //}
            #endregion

            #region Ejercicio 6
            //==============
            //== Ejercicio 6
            //==============

            //Console.WriteLine("Ingrese su edad para determinar en que rango de edad cualitativo esta: ");
            //string edadInput = Console.ReadLine();
            //int edad = 0;

            //if (int.TryParse(edadInput, out edad))
            //{
            //    if (edad >= 0 && edad <= 12)
            //    {
            //        Console.WriteLine("Usted es un niño.");
            //    }
            //    else if (edad >= 13 && edad <= 17)
            //    {
            //        Console.WriteLine("Usted es un adolescente.");
            //    }
            //    else if (edad >= 18 && edad <= 64)
            //    {
            //        Console.WriteLine("Usted es un adulto.");
            //    }
            //    else if (edad >= 65)
            //    {
            //        Console.WriteLine("Usted es un adulto mayor.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("La edad ingresada no es valida.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es valido");
            //}

            #endregion

            #region Ejercicio 7
            //==============
            //== Ejercicio 7
            //==============


            //Console.WriteLine("Ingrese un numero para verificar si esta dentro del rango o no:");
            //string numeroInput = Console.ReadLine();

            //decimal edadDecimal = 0.0m;

            //if (decimal.TryParse(numeroInput, out edadDecimal))
            //{
            //    if (edadDecimal >= 1.0m && edadDecimal <= 100.0m)
            //    {
            //        Console.WriteLine("El numero ingresado esta dentro del rango.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero ingresado esta fuera del rango.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es valido");

            //}

            #endregion

            #region Ejercicio 8
            //==============
            //== Ejercicio 8
            //==============

            //Console.WriteLine("Ingrese un numero para determinar si es par o impar:");
            //string numeroInput = Console.ReadLine();

            //int numeroEntero = 0;

            //if(int.TryParse(numeroInput, out numeroEntero))
            //{
            //    numeroInput = numeroEntero % 2 == 0 ? "El numero es par" : "El numero es impar";
            //    Console.WriteLine(numeroInput);
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado es invalido");
            //}
            #endregion

            #region Ejercicio 9
            //==============
            //== Ejercicio 9
            //==============

            //Console.WriteLine(" \t\tCalcular Impuestos \n\n");
            //Console.WriteLine("Ingrese el monto anual: ");
            //string montoInput = Console.ReadLine();

            //decimal montoAnual = 0.0m;

            //if (decimal.TryParse(montoInput, out montoAnual))
            //{
            //    validacion.toString();
            //    validacion.calcularImpuesto(montoAnual);
            //    validacion.toString();
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado es invalido");
            //}
            #endregion

            #region Ejercicio 10


            //Console.WriteLine("Ingrese un numero del 1-7 para determinar el dia de la semana:");
            //string diaInput = Console.ReadLine();

            //int diaNumero = 0;

            //if(int.TryParse(diaInput, out diaNumero))
            //{
            //    switch (diaNumero)
            //    {
            //        case 1:
            //            Console.WriteLine("Lunes");
            //            break;
            //        case 2:
            //            Console.WriteLine("Martes");
            //            break;
            //        case 3:
            //            Console.WriteLine("Miércoles");
            //            break;
            //        case 4:
            //            Console.WriteLine("Jueves");
            //            break;
            //        case 5:
            //            Console.WriteLine("Viernes");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sábado");
            //            break;
            //        case 7:
            //            Console.WriteLine("Domingo");
            //            break;

            //        default:

            //            Console.WriteLine("El numero ingresado no corresponde a un dia de la semana.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado es invalido");
            //}
            #endregion

            #region Ejercicio 11
            //Menu con switch-case
            //validacion.toString();
            //Console.WriteLine("\t\n\tMenu De Operaciones\n");
            //validacion.toString();

            //Console.WriteLine("Ingrese una de las opciones:");
            //string opWhile = "s";
            //int opcion = 0;
            //decimal numero1 = 0.0m, numero2 = 0.0m;
            //do
            //{
            //    Console.WriteLine("1- Sumar" +
            //                      "\n2- Restar" +
            //                      "\n3- Multiplicar" +
            //                      "\n4- Dividir\n: ");
            //    string opcionInput = Console.ReadLine();
            //    if (!int.TryParse(opcionInput, out opcion) || opcion < 1 || opcion > 4)
            //    {
            //        Console.WriteLine("\nERROR: Opción de menú no válida. Debe ingresar 1, 2, 3 o 4.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Ingrese 2 numeros para realizar las operaciones:");
            //        string numero1Input = Console.ReadLine();
            //        string numero2Input = Console.ReadLine();
            //        if (decimal.TryParse(numero1Input, out numero1) && decimal.TryParse(numero2Input, out numero2))
            //        {
            //            Console.WriteLine("Numeros ingresados validos.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("El valor ingresado no es valido");
            //            continue;
            //        }

            //        if (int.TryParse(opcionInput, out opcion))
            //        {
            //            switch (opcion)
            //            {
            //                case 1:
            //                    decimal resultadoSuma = validacion.suma(numero1, numero2);
            //                    Console.WriteLine($"Ha seleccionado la opcion Sumar.\n Su resultado es: {resultadoSuma}");

            //                    break;
            //                case 2:
            //                    decimal resultadoResta = validacion.resta(numero1, numero2);
            //                    Console.WriteLine($"Ha seleccionado la opcion Restar.\n Su resultado es: {resultadoResta}");

            //                    break;
            //                case 3:
            //                    decimal resultadoMultiplicacion = validacion.multiplicacion(numero1, numero2);
            //                    Console.WriteLine($"Ha seleccionado la opcion Multiplicar.\n Su resultado es: {resultadoMultiplicacion}");

            //                    break;
            //                case 4:
            //                    decimal resultadoDivision = validacion.division(numero1, numero2);
            //                    Console.WriteLine($"Ha seleccionado la opcion Dividir.\n Su resultado es: {resultadoDivision}");

            //                    break;

            //            }

            //            Console.WriteLine("\nDesea realizar otra operacion?\n's' para seguir, de lo contrario, presion cualquier tecla.: ");
            //            opWhile = Console.ReadLine()?.ToLower() ?? "";
            //        }

            //    }
            //} while (opWhile == "s") ;

            //validacion.toString();
            //Console.WriteLine("Programa finalizado. ¡Gracias!");
            #endregion

            #region Ejercicio 12

            //Console.WriteLine("Ingrese un numero cualquiera para determinar la cantidad de numeros pares que hay. ");
            //Console.WriteLine("Por favor, ingrese numeros mayores o iguales a 1.\n");
            //string numeroInput = Console.ReadLine();
            //int numeroLimite = 0;
            //if(int.TryParse(numeroInput, out numeroLimite))
            //{

            //    int resultdo = validacion.contarPares(numeroLimite);
            //    Console.WriteLine($"La cantidad de numeros pares desde el 1 hasta el {numeroLimite} es: {resultdo}");
            //    validacion.toString();
            //}
            //else 
            //{
            //    Console.WriteLine("El valor ingresado es invalido");
            //}


            #endregion

            #region Ejercicio 13
            //validacion.toString();
            //Console.WriteLine("Bienvenido al sumador de numeros impares (1-100)");
            //validacion.toString();

            //int resultado = validacion.sumaImpares();

            //Console.WriteLine($"La suma de los numeros impares entre 1 y 100 es: {resultado}");

            #endregion

            #region Ejercicio 14

            //validacion.toString();
            //Console.WriteLine("Bienvenido al contador de palabras.");
            //validacion.toString();

            //Console.WriteLine("Ingrese alguna palabra para determinar cuantas letras existen en la misma.");
            //string palabraInput = Console.ReadLine() ?? "";
            //int cantidadLetras = 0;

            //if(!string.IsNullOrWhiteSpace(palabraInput) && Regex.IsMatch(palabraInput, @"^[a-zA-ZÁáÉéÍíÓóÚúñÑ\s]+$"))
            //{
            //    // Verifica si la cadena contiene solo letras (incluyendo acentos y ñ) y espacios. Regex explicado:
            //    cantidadLetras = palabraInput.Trim().Length;
            //    cantidadLetras = palabraInput.Replace(" ", "").Length; // Elimina espacios antes de contar letras
            //    Console.WriteLine($"La palabra ingresada tiene {cantidadLetras} letras.");
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado es incorrecto o no es una palabra valida."); 
            //}
            #endregion

            #region Ejercicio 15
            //validacion.toString();
            //Console.WriteLine("\tTabla Multiplicar");
            //validacion.toString();

            //Console.WriteLine("Ingrese un numero para ver su tabla de multiplicar del 1 al 10.");
            //string numeroInput = Console.ReadLine();
            //int numeroTabla = 0;

            //if(int.TryParse(numeroInput , out numeroTabla))
            //{
            //    validacion.tablaMultiplicar(numeroTabla);
            //    Console.WriteLine("Fin del programa, gracias !");
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado es invalido");
            //}
            #endregion

            #region Ejercicio 16
            //validacion.toString();
            //Console.WriteLine("Promedio de notas");
            //validacion.toString();

            //Console.WriteLine("Ingrese 5 notas de un alumno para determinar si aprueba o no.");
            //Console.WriteLine("Ingrese la primera nota:");
            //string nota1Input = Console.ReadLine();
            //Console.WriteLine("Ingrese la segunda nota:");
            //string nota2Input = Console.ReadLine();
            //Console.WriteLine("Ingrese la tercer nota:");
            //string nota3Input = Console.ReadLine();
            //Console.WriteLine("Ingrese la cuarta nota:");
            //string nota4Input = Console.ReadLine();
            //Console.WriteLine("Ingrese la quinta nota:");
            //string nota5Input = Console.ReadLine();

            //float nota1 = 0.0f, nota2 = 0.0f, nota3 = 0.0f, nota4 = 0.0f, nota5 = 0.0f;

            //if (float.TryParse(nota1Input, out nota1) &&
            //   float.TryParse(nota2Input, out nota2) &&
            //   float.TryParse(nota3Input, out nota3) &&
            //   float.TryParse(nota4Input, out nota4) &&
            //   float.TryParse(nota5Input, out nota5))
            //{
            //    float promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5.0f;
            //    Console.WriteLine($"El promedio de las notas ingresadas es: {promedio}");
            //    if (promedio >= 6.0f)
            //    {
            //        Console.WriteLine("El alumno ha aprobado.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El alumno ha desaprobado.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es un numero valido.");
            //}
            #endregion

            #region Ejercicio 17
            // validacion.toString();
            // Console.WriteLine("  CONTADOR HASTA CERO.");
            // validacion.toString();

            // // Variables
            // int contador = 0;
            // int numEntero = 1;


            // while (true)
            // {
            //     Console.Write("\nIngrese un número entero (0 para finalizar): ");
            //     string numeroEnteroInput = Console.ReadLine();


            //     if (int.TryParse(numeroEnteroInput, out numEntero))
            //     {

            //         if (numEntero == 0)
            //         {
            //             // Esta es la única forma de salir del bucle while
            //             break;
            //         }
            //         else
            //         {

            //             contador++;
            //             Console.WriteLine($"-> Número {numEntero} registrado. Contador actual: {contador}");
            //         }
            //     }
            //     else
            //     {

            //         Console.WriteLine("-> ERROR: Dato ingresado inválido. Por favor, ingrese solo números enteros.");

            //     }

            // }

            // validacion.toString();
            // Console.WriteLine("¡Ha ingresado 0! Fin del programa.");
            // Console.WriteLine($"La cantidad total de números introducidos es: {contador}");
            //validacion.toString();
            #endregion

            #region Ejercicio 18
            //validacion.toString();
            //Console.WriteLine("Suma acumulada con condición");
            //validacion.toString();

            ////variables
            //decimal sumaAcumulada = 0m;
            //decimal numeroIngresado = 0m;
            //int cantNumeros = 0;

            //do
            //{
            //    Console.Write("Ingrese un numero para sumar hasta que llegue a 100: ");
            //    string numeroInput = Console.ReadLine();
            //    if (decimal.TryParse(numeroInput, out numeroIngresado))
            //    {
            //        Console.WriteLine($"Ha ingresado el numero {numeroIngresado}");
            //        sumaAcumulada += numeroIngresado;
            //        Console.WriteLine($"Su suma actual es de: {sumaAcumulada}");

            //            cantNumeros++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR: Dato ingresado invalido.");

            //    }

            //} while (sumaAcumulada < 100);

            //validacion.toString();
            //Console.WriteLine("Fin del programa.");
            //validacion.toString();

            #endregion

            #region Ejercicio 19
            //validacion.toString();
            //Console.WriteLine("  CONTADOR DE DÍGITOS");
            //validacion.toString();

            ////variables
            //int numero;
            //string numeroComoTexto= "";
            //string soloDigitos = "";
            //Console.Write("\nIngrese un número entero (positivo o negativo): ");
            //string entrada = Console.ReadLine();



            //if (int.TryParse(entrada, out numero))
            //{
            //     numeroComoTexto = entrada;

            //    // Eliminamos caracteres no dígitos: el signo negativo (-) si existe.
            //    // Usamos Regex.Replace para eliminar cualquier signo (-) al inicio.
            //     soloDigitos = Regex.Replace(numeroComoTexto, @"^\s*[-+]\s*", string.Empty);

            //    int cantidadDigitos = soloDigitos.Length;

            //    Console.WriteLine($"\nEl número ingresado es: {numero}");
            //    Console.WriteLine($"El número {numero} tiene {cantidadDigitos} dígitos.");

            //}
            //else
            //{

            //    Console.WriteLine("\nERROR: La entrada no es un número entero válido.");
            //}
            #endregion

            #region Ejercicio 20
            //validacion.toString();
            //Console.WriteLine("Contador de vocales.");
            //validacion.toString();

            ////variables
            //int contadorVocales = 0;
            //char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };

            //Console.Write("Ingrese una palabra o frase para contar sus vocales: ");
            //string entradaInput = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(entradaInput))
            //{
            //    Console.WriteLine("\nERROR: No ingresó una palabra válida.");
            //    return;
            //}
            //else
            //{
            //    string textoMinusculas = entradaInput.ToLower();

            //    foreach(char letra in textoMinusculas)
            //    {
            //        if (Array.IndexOf(vocales, letra) != -1)
            //        {
            //            contadorVocales++;
            //        }
            //    }

            //    Console.WriteLine($"\nLa palabra ingresada fue: \"{entradaInput}\"");
            //    Console.WriteLine($"La palabra tiene {contadorVocales} vocales.");
            //    validacion.toString();
            //}
            #endregion

        }
    }
}

