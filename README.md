# ASP.NET Core GraphQL API

This project demonstrates how to build a simple GraphQL API using ASP.NET Core and [HotChocolate](https://chillicream.com/docs/hotchocolate). It exposes endpoints to fetch user data and can be tested using Postman.

---

## 🔧 Technologies Used

- ASP.NET Core Web API
- GraphQL with HotChocolate
- .NET 6/7/8 SDK
- In-memory data service
- Postman (for testing)

---

## 🔗 GitHub Repository

[https://github.com/rashedulalam46/graphql](https://github.com/rashedulalam46/graphql)

---

## 🛠️ Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### ✅ Prerequisites

Before you begin, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Git](https://git-scm.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

---

## ⬇️ Clone the Repository

Open your terminal and run the following command:

```bash
git clone https://github.com/rashedulalam46/graphql.git
cd graphql
```

## ▶️ Run the Project

Open your terminal and run the following command to restore depedencies, build & run the project:

```bash
dotnet restore
dotnet build
dotnet run
```

The API will start on http://localhost:5000 or https://localhost:5001.

## 🔍 Test the API with Postman

Open Postman and create a POST request to:

```bash
http://localhost:5000/graphql
```

In the Body, select raw and JSON, then use sample input like:

```bash
{
  "query": "{ users { userId userName email } }"
}
```

## ✅ Expected Output

Request response like:

```bash
{
    "data": {
        "users": [
            {
                "userId": 1001,
                "userName": "RASHED",
                "email": "rashed@example.com"
            },
            {
                "userId": 1002,
                "userName": "JOHN",
                "email": "john@example.com"
            },
            {
                "userId": 1003,
                "userName": "KAMAL",
                "email": "kamal@gmail.com"
            },
            {
                "userId": 1004,
                "userName": "KEVIN",
                "email": "kevin@gmail.com"
            },
            {
                "userId": 1005,
                "userName": "MAIKEL",
                "email": "maikel@gmail.com"
            }
        ]
    }
}
```

If validation passes, you’ll get a 200 OK response or a confirmation message depending on your controller logic.

## 📁 Project Structure

```bash
graphql/
├── Queries/
│   └── UserQuery.cs
├── Services/
│   └── UserService.cs
├── Models/
│   └── User.cs
├── Program.cs
└── server-side-validation.csproj
```

## 🤝 Contributing
Pull requests are welcome! If you find bugs or have suggestions, feel free to open an issue.

## 📄 License
This project is licensed under the MIT License.

## 👤 Author
[Rashedul Alam](https://github.com/rashedulalam46)


