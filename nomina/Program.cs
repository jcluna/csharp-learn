using System;

namespace nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar la calculador de nómina
            var calculadora = new Calculadora();

            var salarioDiario = 1266.67;            // segun corresponda al empleado ($)
            var diasVacaciones = 18.0;              // 6 días el primer año (LFT)
            var porcentajePrimaVacacional = 0.25;   // 25% de la prima vacacional (LFT)
            var diasAguinaldo = 15.0;               // 15 días de aguinaldo (LFT)

            // calcular los días de la prima vacacional
            var diasPrimaVacacional = calculadora.DiasPrimaVacacional(
                diasVacaciones,
                porcentajePrimaVacacional);

            // calcular el factor de integración
            var factorIntegracion = calculadora.FactorIntegracion(
                diasAguinaldo,
                diasPrimaVacacional);

            // calcular el salario diario integrado
            var salarioDiarioIntegrado = calculadora.SalarioDiarioIntegrado(
                salarioDiario,
                factorIntegracion);

            Console.WriteLine(new
            {
                empleado = new
                {
                    salarioDiario,
                    diasVacaciones,
                    porcentajePrimaVacacional,
                    diasAguinaldo
                },
                calculos = new
                {
                    diasPrimaVacacional,
                    factorIntegracion,
                    salarioDiarioIntegrado
                }
            });
        }
    }
}
