using System;

namespace nomina
{
    /// <summary>
    /// Calculador de nónima
    /// </summary>
    public class Calculadora
    {
        public double DiasVacacionesPorAño(int años){
            return 0; // pendiente por implementar
            // https://contadorcontado.com/2015/07/20/dias-de-vacaciones-por-ano/
            // https://contadorcontado.com/2018/08/03/que-es-el-salario-diario-integrado-y-como-se-calcula-sdi/
            // https://www.nominapro.mx/blog/que-es-y-como-se-calcula-el-salario-diario-integrado-sdi/
        }

        /// <summary>
        /// Calcular los dias de la prima vacacional
        /// </summary>
        /// <param name="diasVacaciones">Número de días de vacaciones</param>
        /// <param name="porcentajePrimaVacacional">Porcentaje para calcular la prima vacacional (mínimo 25% (0.25) definido por la Ley Federal de Trabajo)</param>
        /// <returns>Número de días por prima vacacional</returns>
        public double DiasPrimaVacacional(double diasVacaciones, double porcentajePrimaVacacional)
        {
            if (diasVacaciones <= 0.0)
                throw new CalculadoraException("Los días de vacaciones debe ser mayor a 0.");

            if (porcentajePrimaVacacional <= 0.0 || porcentajePrimaVacacional > 1.0)
                throw new CalculadoraException("El porcentaje para calcular la prima vacacional debe ser mayor a 0.0 (0%) y menor o igual a 1.0 (100%)");

            // calcular la prima vacacional
            var primaVacacional = (diasVacaciones * porcentajePrimaVacacional);
            return primaVacacional;
        }

        /// <summary>
        /// Calcular el factor de integración
        /// </summary>
        /// <param name="diasAño">Número de días del año</param>
        /// <param name="diasAguinaldo">Número de días de aguinaldo</param>
        /// <param name="diasPrimaVacacional">Número de días de la prima vacacional</param>
        /// <returns>Factor de integración</returns>
        public double FactorIntegracion(double diasAño, double diasAguinaldo, double diasPrimaVacacional)
        {
            var factorIntegracion = ((diasAño + diasAguinaldo + diasPrimaVacacional) / diasAño);
            return Math.Round(factorIntegracion, 4);
        }

        /// <summary>
        /// Calcular el salario diario integrado (SDI)
        /// </summary>
        /// <param name="salarioDiario">Monto del salario diario</param>
        /// <param name="factorIntegracion">Factor de integración</param>
        /// <returns>Salario diario integrado</returns>
        public double SalarioDiarioIntegrado(double salarioDiario, double factorIntegracion)
        {
            var salarioDiarioIntegrado = (salarioDiario * factorIntegracion);
            return Math.Round(salarioDiarioIntegrado, 2);
        }
    }
}
