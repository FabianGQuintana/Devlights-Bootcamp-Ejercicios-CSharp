using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCajeroAutomatico_Bootcamp
{
    internal class Operaciones
    {
        #region Atributos y Constructores
        //Atributos
        private decimal montoInicial = 1000.00m;
        private decimal saldoActual;


        //Constructores
        public Operaciones() { 
            this.setMontoInicial(1000.00m);
            this.setSaldoActual(this.montoInicial);
        }

        #endregion

        #region ACCESORS
        //Methods Accesors
        //Setters
        private void setMontoInicial(decimal p_montoInicial)
        {
            this.montoInicial = p_montoInicial;
        }

        private void setSaldoActual(decimal p_montoActual)
        {
            this.saldoActual = p_montoActual;
        }

        //Getters
        public decimal getMontoInicial()
        {
            return this.montoInicial;
        }

        public decimal getSaldoActual()
        {
            return this.saldoActual;
        }
        #endregion

        #region METHODS
        //Methods
        public decimal consultarSaldo()
        {
            return this.getSaldoActual();
        }

        public bool depositar(decimal p_saldoIngreso)
        {
            decimal nuevoSaldo = 0.0m;
            
            if (decimal.IsPositive(p_saldoIngreso))
            {
               nuevoSaldo = this.getSaldoActual() + p_saldoIngreso;
               this.setSaldoActual(nuevoSaldo);
               return true;
            }
            else
            {
                return false;
            }
        }

        public bool retirar(decimal p_saldoRetiro)
        {
            decimal nuevoSaldo = 0.0m;

            if (decimal.IsPositive(p_saldoRetiro) && p_saldoRetiro <= this.getSaldoActual())
            {
                nuevoSaldo = this.getSaldoActual() - p_saldoRetiro;
                this.setSaldoActual(nuevoSaldo);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void toString()
        {
            Console.WriteLine("==========================================");
        }
        #endregion
    }
}
