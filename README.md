Dragonvain Accounting System 1.0
Welcome to the Dragonvain Accounting System 1.0! This console application is designed to simulate basic banking operations for two types of accounts: Checking and Premium. It allows users to create accounts, deposit and withdraw funds, transfer money between accounts, and calculate interest.

Features
Account Creation: Users can create checking and premium accounts by providing an account number and initial balance.
Deposit: Add funds to your account.
Withdraw: Withdraw funds from your account (Checking accounts only).
Transfer: Transfer funds between accounts.
Interest Calculation: Automatically calculate interest for both checking and premium accounts, with premium accounts earning a higher interest rate.
Getting Started
Prerequisites
Ensure you have the following installed:

.NET 6.0 SDK or later
Running the Application
Clone the repository or download the source code.
Open your terminal or command prompt.
Navigate to the project directory.
Run the application using the command:
shell
Copy code
dotnet run
Save to grepper
Using the Application
Follow the on-screen prompts to interact with the application. Here's a quick guide:

The application will welcome you and prompt to create a checking account.
Enter the required account number and balance as instructed.
Next, you'll be prompted to create a premium account. Follow the instructions.
Once both accounts are created, you can deposit funds, transfer between accounts, and calculate interest as demonstrated on-screen.
Classes and Interfaces
IAccountingSystem Interface: Defines the basic structure for accounts.
CheckingAccount Class: Implements the IAccountingSystem interface to represent a checking account with basic functionalities.
PremiumAccount Class: Inherits from CheckingAccount and represents a premium account with a higher interest rate.
Contributing
Feel free to fork the repository and submit pull requests to contribute to the development of Dragonvain Accounting System 1.0.
