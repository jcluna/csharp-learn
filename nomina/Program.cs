using System;

namespace nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar la calculador de nómina
            var calculadora = new Calculadora();

            var salarioDiario = 250.00;             // Salario Diario
            var diasAño = 365.0;                    // Días del año (normalmente 365, pero considerar los bisietos)
            var diasVacaciones = 6.0;               // Días de Vacaciones (por ley 6 días el primer año)
            var porcentajePrimaVacacional = 0.25;   // Prima Vacacional (por ley 25% sobre los días de vacaciones)
            var diasAguinaldo = 15.0;               // Días de Aguinaldo (por ley 15 días)

            // calcular los días de la prima vacacional
            var diasPrimaVacacional = calculadora.DiasPrimaVacacional(
                diasVacaciones, porcentajePrimaVacacional);

            // calcular el factor de integración
            var factorIntegracion = calculadora.FactorIntegracion(
                diasAño, diasAguinaldo, diasPrimaVacacional);

            // calcular el salario diario integrado
            var salarioDiarioIntegrado = calculadora.SalarioDiarioIntegrado(
                salarioDiario, factorIntegracion);

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
