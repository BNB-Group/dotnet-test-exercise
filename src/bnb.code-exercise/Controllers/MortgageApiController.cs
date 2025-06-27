using System;
using Bnb.CodeExercise.Controllers.Models;
using Bnb.CodeExercise.Domain;
using Bnb.CodeExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bnb.CodeExercise.Controllers;

[ApiController]
[Route("api/mortgage")]
public class MortgageApiController
{
    [Route("calculateMonthlyPayment")] 
    [HttpPost]
    public IActionResult CalculateMonthlyPayment([FromBody] CalculateMonthlyPaymentRequestModel request)
    {
        var monthlyPayment = 0m;

        // TODO: Implement the actual mortgage calculation logic.

        return new OkObjectResult(new { MonthlyPayment = monthlyPayment });

    }
}