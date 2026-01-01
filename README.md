# Multiples of 3 (Recursive Console Application)

This C# console application prints all multiples of 3 less than a given number N using a recursive function.

## 📌 Features
- Reads an integer N from the user
- Finds all numbers less than N that are divisible by 3
- Uses recursion instead of loops
- Prints the results in ascending order

## 🧠 How the Algorithm Works
The program uses a recursive method called MultiplesOf3:

- If n <= 0, the recursion stops
- If n is not divisible by 3, the function calls itself with n - 1
- If n is divisible by 3:
  - The function first calls itself with n - 3
  - Then prints n

This ensures the numbers are printed in correct (ascending) order.

## 🛠️ Technologies
- Language: C#
- Framework: .NET Console Application

## ▶️ How to Run
1. Open the project in Visual Studio
2. Build the solution
3. Run the application
4. Enter an integer value for N when prompted

## 💻 Example Output

## 📂 Project Structure

## 🎯 Learning Purpose
This project is designed to practice:
- Recursive functions
- Conditional logic
- Console input and output in C#

## 📜 License
This project is open-source and intended for educational use.
