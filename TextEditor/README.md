## Text Editor 📝

A simple text editor developed in C# for educational and demonstration purposes. The application allows you to create, open, view, and save text files directly in the terminal.

## Features

- Open file: Read the content of existing text files.
- Create a new file: Type text directly in the terminal to create a new file.
- Save file: Save the typed text to a file on the system.
  Interactive menu: Easy navigation through options in the main menu.

## How to Use

- Clone or download the repository to your machine.
- Compile and run the program using any C# IDE or the terminal with the .NET SDK:
  bash

```
dotnet run
```

In the main menu, choose one of the options:

- 1: Open an existing file.
- 2: Create a new file.
- 3: Exit the application.

## Requirements

- .NET SDK 6.0 or higher.
- Operating system compatible with .NET Core.

## How It Works

Main Structure

- Menu: Displays the program's main options and redirects execution flow based on the user's choice.
- Open File: Uses StreamReader to read the content of the specified file and display it in the terminal.
- Create File: Allows you to type text in the terminal until the ESC key is pressed.
- Save File: Uses StreamWriter to save the typed text to a file at the specified path.

## Future Improvements

- Add support for editing existing files.
- Improve error handling, such as for missing files or insufficient permissions.
- Implement support for different file extensions.

## License

This project is licensed under the [MIT License](../LICENSE).
