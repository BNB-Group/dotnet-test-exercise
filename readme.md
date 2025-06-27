# TAP coding exercise: Mortgage Quote API

## Timebox
Please spend no more than 60 minutes on this exercise. Focus on readable, testable code, not completeness. 

## The Brief
Our product offers many Mortgage calculators to our users. You are to create a mortgage quote calculator as a .NET Core Web API.

The API should return monthly repayments based on the inputs provided by the client.

We support three different repayment types, all of which are calculated using the [Amortizing Loan Method](https://en.wikipedia.org/wiki/Amortizing_loan) (Equated monthly instalment method):
* Standard (principal + interest) 
* Interest-only
* Offset (subtract a cash offset account before calculating)

Additionally, customers may choose one or more add-ons that affect monthly repayments:
* Insurance: Adds a flat $50/month
* ExtraRepayment:<amount>: Top-up amount applied monthly (e.g., $100)

Example Request
```JSON
POST /mortgage-quote

{   
  "loanAmount": 500000,   
  "annualInterestRate": 6.5,   
  "termYears": 30,   
  "type": "Standard",   
  "offsetAmount": 0,   
  "addons": 
  [     
    "Insurance",     
    "ExtraRepayment:100"   
  ] 
}
```

Example Response

```JSON
{  
  "monthlyRepayment": 3310.34 
}
```

## Requirements
1. Apply repayment logic based on the type
2. Add add-ons to the base repayment amount
3. Show how you would test various parts of this solution

## Suggestions
We’re looking to understand how you:
* Structure composable solutions
* Use patterns
* Write readable, maintainable code
* Approach testing and validation

## Submission Instructions
* We have supplied a large amount of starter code here, which should allow you to focus on the actual implementation of what's being asked in this exercise. 
* We don't expect that you would need to remove any code, or change method signatures.
* Don’t worry about authentication or full error handling, just how you think about the items in the Suggestions above.
* Please supply all code in a zip file to [code-test-submission@bnbgroup.co.nz](mailto:code-test-submission@bnbgroup.co.nz)

> [!CAUTION]
> ## AI
> Use AI to support your work at your own risk.. Our interview process will require that you elaborate on your design and implementation - i.e. that you have a full understanding of your own work.