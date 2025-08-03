# 🌦️ Console Weather Forecast App

This C# console application fetches and displays detailed weather forecasts for a given South African city using the Visual Crossing Weather API. It offers a clean user interface with ASCII art branding, practical unit conversion, and neatly formatted daily conditions.

## 🔍 How It Works

- Accepts user input for a city name
- Sends an HTTP GET request to the Visual Crossing API
- Parses and converts weather data (Fahrenheit → Celsius)
- Displays multi-day forecasts in the console, including:
  - Day of the week
  - High and low temperatures
  - General weather description

## 🧠 Key Features

- **Asynchronous API Request**  
  Uses `HttpClient` and `async/await` for responsive performance.

- **Data Parsing and Formatting**  
  Leverages `DateTime` and `CultureInfo` for human-readable output.

- **Temperature Conversion**  
  Converts Fahrenheit to Celsius and rounds to two decimal places.

- **ASCII Branding**  
  Eye-catching startup banner generated via `Console.WriteLine` with color styling.

- **String Cleanup Utility**  
  Capitalizes city names properly for consistent API querying.

## 🧰 Tech Stack

- **Language**: C# (.NET Console App)
- **Libraries**: `System.Net.Http`, `Newtonsoft.Json`, `System.Globalization`
- **API Source**: [Visual Crossing Weather API](https://www.visualcrossing.com)

## 🛠 Usage

```bash
dotnet run
