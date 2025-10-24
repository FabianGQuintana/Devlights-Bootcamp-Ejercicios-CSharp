using MiniCajeroAutomatico_Bootcamp;
using System;
using System.Threading; 

namespace cajeroAutomatico
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            #region Instancia y variables
            // Instancia de la clase Operaciones
            Operaciones op = new Operaciones();
            // Variables
            int opWhile = 1;
            #endregion

            // Menu Principal
            #region estructuraMenu
            do
            {
               
                Console.Clear();

                op.toString();
                op.toString();
                Console.WriteLine("Bienvenido al Mini Cajero Automatico\n\tK.I.N.S");
                op.toString();

                // Estructura del Menu
                op.toString();
                Console.WriteLine("1) Consultar Saldo" +
                                  "\n2) Depositar" +
                                  "\n3) Retirar" +
                                  "\n4) Salir.");
                op.toString();


                Console.Write("Seleccione la opcion a realizar: ");
                string opcionMenuInput = Console.ReadLine();
                int seleccionMenu;

                
                
                bool esOpcionValida = int.TryParse(opcionMenuInput, out seleccionMenu) && seleccionMenu >= 1 && seleccionMenu <= 4;

                // Menu-Switch
                #region Menu-Switch
                if (esOpcionValida)
                {
                   
                    Console.Clear();

                    switch (seleccionMenu)
                    {
                        case 1:
                            Console.WriteLine("Usted a elegido Consultar saldo.");
                            Console.WriteLine("Consultando saldo...");
                            Thread.Sleep(1000);
                            Console.WriteLine($"Su saldo actual es: {op.consultarSaldo():C2}");
                            break;
                        case 2:
                            Console.WriteLine("Usted a elegido Depositar.");
                            Console.Write("Ingrese el monto a depositar: ");
                            string depositoInput = Console.ReadLine();
                            decimal depositoMonto;

                            if (decimal.TryParse(depositoInput, out depositoMonto) && !string.IsNullOrWhiteSpace(depositoInput))
                            {
                                if (op.depositar(depositoMonto))
                                {
                                    Console.WriteLine("Depositando...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"Deposito exitoso! Su nuevo saldo es: {op.consultarSaldo():C2}");
                                }
                                else
                                {
                                    Console.WriteLine("Error: El monto a depositar debe ser un valor positivo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Ingrese un monto valido para depositar.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Usted a elegido Retirar.");
                            Console.Write("Ingrese el monto a retirar: ");
                            string retiroInput = Console.ReadLine();
                            decimal retiroMonto;

                            if (decimal.TryParse(retiroInput, out retiroMonto) && !string.IsNullOrWhiteSpace(retiroInput))
                            {
                                if (op.retirar(retiroMonto))
                                {
                                    Console.WriteLine("Retirando...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"Retiro exitoso! Su nuevo saldo es: {op.consultarSaldo():C2}");
                                }
                                else
                                {
                                    Console.WriteLine("Error: Fondos insuficientes o monto inválido/negativo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Ingrese un monto valido para retirar.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del sistema.");
                            Thread.Sleep(1000);
                            op.toString();
                            Console.WriteLine(" Gracias por usar el Mini Cajero Automatico K.I.N.S.");
                            op.toString();
                            opWhile = 0;
                            break;
                    }

                    
                    if (opWhile != 0)
                    {
                        Console.WriteLine("\nPresione cualquier tecla para volver al Menú Principal...");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("\nERROR: Opción inválida. Por favor, ingrese un número del 1 al 4.");
                    Console.WriteLine("Presione cualquier tecla para reintentar...");
                    Console.ReadKey(true);
                }
                #endregion

            } while (opWhile != 0);
            #endregion
        }
    }
}
