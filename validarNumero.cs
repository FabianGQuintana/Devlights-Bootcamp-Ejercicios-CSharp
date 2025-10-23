using System;
using System.Linq;


namespace Devligths_ResolucionEjercicios1_20
{
    internal class validarNumero
    {
        #region Metodos detallistas
        public void toString()
        {
            Console.WriteLine("==============================");
        }
        #endregion

        #region Ejercicio 1
        public void determinarValorNumero(float numero)
        {
            if (numero > 0)
            {
                Console.WriteLine("El numero ingresado es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero ingresado es negativo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es 0");
            }
        }
        #endregion

        #region Ejercicio 2
        public void mayorMenor(float num1, float num2, float num3)
        {
            float mayor = Math.Max(num1, Math.Max(num2, num3));

            Console.WriteLine($"el numero mayor es {mayor}");

            float menor = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"el numero menor es {menor}");
        }
        #endregion

        #region Ejercicio 3
        public void sonMultiplos(float num1, float num2)
        {
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Los numeros son multiplos");
            }
            else
            {
                Console.WriteLine("Los numeros no son multiplos");
            }
        }

        #endregion

        #region Ejercicio 4
        public float calcularPrecio(float precio)
        {
            float descuento = 0.0f;

            if (precio > 1000.0)
            {
                descuento = precio * 1.10f;
                return descuento;
            }
            else
            {
                return precio;
            }

        }
        #endregion

        #region Ejercicio 9
        public void calcularImpuesto(decimal monto)
        {
            decimal impuesto = 0.0m;

            if (monto < 10000)
            {
                Console.WriteLine("No paga impuestos (0%).");

            }
            else if (monto <= 50000)
            {
                impuesto = monto * 0.10m;
                Console.WriteLine($"Impuesto: 10%. Monto a pagar: {impuesto:C}");
            }
            else
            {
                impuesto = monto * 0.20m;
                Console.WriteLine($"Impuesto: 20%. Monto a pagar: {impuesto:C}");
            }
        }
        #endregion

        #region Ejercicio 11
        public decimal suma(decimal num1, decimal num2)
        {
            decimal resultado = num1 + num2;
            return resultado;
        }

        public decimal resta(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;
            return resultado;
        }

        public decimal multiplicacion(decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;
            return resultado;
        }

        public decimal division(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division por cero no es permitida.");
                return 0;
            }
            decimal resultado = num1 / num2;
            return resultado;
        }
        #endregion

        #region Ejercicio 12
        public int contarPares(int n)
        {
            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    contador++;
                }
            }
            return contador;

        }
        #endregion

        #region Ejercicio 13
        public int sumaImpares()
        {
            int suma = 0;

            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        #endregion

        #region Ejercicio 15
        public void tablaMultiplicar(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
                Thread.Sleep(1000);
               Console.WriteLine("\n");
            }
        }
        #endregion
    }
}
