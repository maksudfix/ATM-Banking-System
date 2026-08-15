# ATM Banking System

A simple C# Console Application that simulates basic ATM banking operations, including checking balance, depositing money, withdrawing money, and exiting the system.

## Features

* Create a bank account with an account number and balance
* Check current account balance
* Deposit money into the account
* Withdraw money from the account
* Validate minimum withdrawal amount
* Check for insufficient balance
* Validate numeric user input
* Use a menu-driven ATM interface

## Code Structure

Banking
 ├── AccountNumber
 ├── balance
 ├── Banking()
 ├── Deposit()
 └── Withdraw()

ATM
 └── Main()
      ├── Create Bank Account
      ├── Display ATM Menu
      ├── Check Balance
      ├── Deposit
      ├── Withdraw
      └── Exit

## Concepts Used

* Classes & Objects — `Banking` represents a bank account.
* Properties — Stores account number and balance.
* Constructors — Initializes the account.
* Methods — `Deposit()` and `Withdraw()` handle transactions.
* Encapsulation— Banking operations are handled inside the `Banking` class.
* while Loop — Keeps the ATM menu running.
* switch — Handles different menu options.
* TryParse() — Validates user input.
* Conditional Statements — Checks deposit, withdrawal, and balance conditions.

## Sample Output

Select Option:
1.Current Balance
2.Deposit
3.Withdraw
4.Exit

1
Current Balance: 45035 BDT

2
Enter Deposite Amount: 5000
Amount 5000 BDT Deposited Successfully
Updated Balance: 50035 BDT

3
Enter Wthdraw Amount: 1000
Amount 1000 BDT Withdrawn Successfully
Updated Balance: 49035 BDT

## Technologies

*C# • .NET Console Application • Classes • Objects • Methods • Properties • while Loop • switch • TryParse() • Console I/O*
