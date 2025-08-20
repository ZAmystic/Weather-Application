# 🌤️ Console Weather Forecast App

A sleek C# console application that delivers real-time weather forecasts for South African cities, powered by the Visual Crossing Weather API. Enjoy a user-friendly interface with vibrant ASCII art, seamless temperature conversions, and beautifully formatted multi-day forecasts—all from the comfort of your terminal.

## 🚀 Overview

This lightweight app transforms your console into a personal weather station. Simply input a South African city, and it retrieves detailed forecasts including daily highs, lows, and conditions. Built with modern C# practices, it's perfect for developers learning API integration, asynchronous programming, or building CLI tools.

## 🔍 How It Works

1. **User Input**: Enter the name of a South African city (e.g., Johannesburg or Cape Town).
2. **API Integration**: Sends an asynchronous HTTP GET request to the Visual Crossing Weather API.
3. **Data Processing**: Parses JSON responses, converts temperatures from Fahrenheit to Celsius, and formats dates using localized culture info.
4. **Output Display**: Presents a clean, multi-day forecast in the console, complete with day-of-week labels, temperature ranges, and weather descriptions.

## ✨ Key Features

- **Asynchronous Operations**: Utilizes `HttpClient` with `async/await` for non-blocking, efficient API calls.
- **Smart Data Handling**: Automatic temperature conversion (F° to C°) with rounding to two decimal places for precision.
- **Elegant Formatting**: Leverages `DateTime` and `CultureInfo` for readable, culture-aware date and string outputs.
- **Visual Flair**: Custom ASCII art banner with color-coded console styling for an engaging startup experience.
- **Utility Functions**: Includes a string cleanup method to properly capitalize city names, ensuring reliable API queries.
- **Error Resilience**: Handles common input issues and API responses gracefully.

## 🛠️ Tech Stack

- **Language & Framework**: C# (.NET Console Application)
- **Core Libraries**:
  - `System.Net.Http` for API requests
  - `Newtonsoft.Json` for JSON parsing
  - `System.Globalization` for date and culture formatting
- **API Provider**: [Visual Crossing Weather API](https://www.visualcrossing.com) – Free tier available for development.

## 📋 Prerequisites

- .NET SDK (version 6.0 or later) installed on your machine.
- A free API key from Visual Crossing (sign up [here](https://www.visualcrossing.com/weather-api) and add it to your app's configuration).

## ⚙️ Installation & Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/console-weather-app.git
   cd console-weather-app
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Configure your API key (edit the source code or use environment variables as needed).

4. Run the app:
   ```bash
   dotnet run
   ```

   Example output:
   ```
   🌤️ Welcome to Console Weather Forecast! 🌤️

   Enter a South African city: Johannesburg

   Forecast for Johannesburg:
   - Monday: High 25.56°C | Low 15.00°C | Sunny
   - Tuesday: High 24.44°C | Low 14.44°C | Partly Cloudy
   ...
   ```

## 🤝 Contributing

Contributions are welcome! Feel free to submit pull requests for bug fixes, new features, or improvements. Please include tests and follow standard C# coding conventions.

---

Built with ☕ and curiosity. If you encounter issues or have suggestions, open an issue on GitHub!
