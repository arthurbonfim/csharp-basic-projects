# IMC Calculator

IMC Calculator is a simple console application developed in C# to calculate the Body Mass Index (IMC) based on the user's weight and height. It also provides a category classification based on the calculated IMC.

## Features

- Calculate your IMC.
- View your IMC classification.
- User-friendly menu for navigation.

## How It Works

1. The user selects an option from the main menu:
   - **1:** Calculate IMC
   - **2:** Exit the application
2. If the calculation option is selected, the user inputs their weight (in kilograms) and height (in meters).
3. The application calculates the IMC and displays the result along with the classification.

### IMC Categories

| **IMC**        | **Classification** |
| -------------- | ------------------ |
| Less than 16,0 | Severe Thinness    |
| 16,0 - 16,9    | Moderate Thinness  |
| 17,0 - 18,4    | Mild Thinness      |
| 18,5 - 24,9    | Normal Weight      |
| 25,0 - 29,9    | Overweight         |
| 30,0 - 34,9    | Obesity Class I    |
| 35,0 - 39,9    | Obesity Class II   |
| 40,0 and above | Obesity Class III  |

## Prerequisites

- .NET SDK installed on your machine.

## How to Run

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/IMCCalculator.git
   ```
2. Navigate to the project folder:
   ```bash
   cd IMCCalculator
   ```
3. Build and run the application:
   ```bash
   dotnet run
   ```

## Example Usage

```
===== Calculadora de IMC =====
Selecione uma opção:
1. Calcular IMC
2. Sair

Informe seu peso em Kg: 70
Informe sua altura em metros: 1.75
Seu IMC é 22.86
Seu peso está normal
```

## Project Structure

- **Program.cs:** Contains the main logic for the application, including the menu, IMC calculation, and classification display.

## Future Improvements

- Add input validation to ensure correct data entry.
- Include detailed health tips based on the IMC category.
- Expand functionality to calculate IMC for different age groups.

## License

This project is licensed under the MIT License - see the [LICENSE](../LICENSE) file for details.

## Author

- **Arthur Bonfim** - Developer

Feel free to contribute or report any issues!
