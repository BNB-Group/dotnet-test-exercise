using Bnb.CodeExercise.Domain;

namespace Bnb.CodeExercise.Services
{
    /// <summary>
    /// Interface for mortgage calculation services.
    /// </summary>
    public interface IMortgageCalculator
    {
        /// <summary>
        /// Calculates the monthly payment for a mortgage.
        /// </summary>
        /// <param name="amount">The loan amount.</param>
        /// <param name="annualInterestRate">The annual interest rate as a percentage.</param>
        /// <param name="years">The term of the loan in years.</param>
        /// <param name="loanType">The type of loan.</param>
        /// <param name="Addons">Optional addons that can affect the monthly payment.</param>
        /// <returns>The calculated monthly payment.</returns>
        decimal CalculateMonthlyLoanPayment(decimal amount, decimal annualInterestRate, int years, LoanType loanType, Addon [] Addons = null);
    }
}