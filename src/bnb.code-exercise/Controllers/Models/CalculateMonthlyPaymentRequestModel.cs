using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Bnb.CodeExercise.Domain;

namespace Bnb.CodeExercise.Controllers.Models;

public class CalculateMonthlyPaymentRequestModel
{
    [JsonPropertyName("loanAmount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("annualInterestRate")]
    public decimal AnnualInterestRate { get; set; }

    [JsonPropertyName("termYears")]
    public int Years { get; set; }

    [JsonPropertyName("type")]
    public LoanType LoanType { get; set; }

    [JsonConverter(typeof(AddonListSystemTextJsonConverter))]
    public Addon[] Addons { get; set; }


}