# 🌟 **UserApp** 🌟

Welcome to **UserApp**! 🚀 An **ASP.NET Core MVC** project powered by the **Identity Framework**, designed to manage user authentication. This app provides all the essential features you need for handling user accounts, including **registration**, **login**, **password reset**, and **logout**. Perfect for building secure web applications! 🔒

## 🚀 Features

- **📝 User Registration**: Let new users sign up with secure password validation and hashing!
- **🔑 Login**: Registered users can easily log in with their credentials.
- **🔄 Password Reset**: Forgot your password? No worries! Users can reset their passwords via a secure link sent to their email. 📧
- **🚪 Logout**: Securely log out to protect your personal data. 🛡️

## ⚙️ Requirements

To run **UserApp**, you'll need the following tools:

- **.NET Core 6.0** or later ⚡
- Visual Studio (or any preferred IDE) 🖥️
- **SQL Server** (or any database provider for Identity storage) 🗃️

## 🛠️ Installation

Follow these simple steps to get started:

1. **Clone the repository** to your local machine:
    ```bash
    git clone https://github.com/ozcanakyuz/UserApp.git
    ```

2. **Restore the NuGet packages** to load all dependencies:
    ```bash
    dotnet restore
    ```

3. **Apply migrations** to create the database:
    ```bash
    dotnet ef database update
    ```

4. **Run the application** and enjoy exploring the features:
    ```bash
    dotnet run
    ```

Once done, you’re good to go! 🎉

## 💻 Technologies Used

This project leverages the following technologies:

- **ASP.NET Core MVC**: A powerful framework for creating dynamic web pages with the MVC pattern.
- **Identity Framework**: Simplifies user authentication, including registration, login, and password management.
- **Entity Framework Core**: An ORM that allows easy interaction with the database.
- **SQL Server** (or other database providers): Storing user data and handling authentication securely. 🛠️

## 📜 License

This project is licensed under the **MIT License**. For more details, check out the [LICENSE](LICENSE) file. 📑
