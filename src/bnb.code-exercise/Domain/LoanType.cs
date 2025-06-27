using System.Runtime.Serialization;

namespace Bnb.CodeExercise.Domain;

/// <summary>
/// Represents the type of loan.
/// </summary>
public enum LoanType
{
    /// <summary>
    /// A standard mortgage where the interest and principal are paid in equal installments over the term of the loan.
    /// </summary>
    [EnumMember]
    Standard,

    /// <summary>
    /// A loan where the interest rate is paid only, but not the principal.
    /// </summary>
    [EnumMember]
    InterestOnly,

    /// <summary>
    /// A loan which follows the same terms as a standard mortgage, but any cash deposited, offsets the amount of the loan outstanding. 
    /// </summary>
    [EnumMember]
    Offset 
}