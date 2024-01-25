# AcademicDevP

AcademicDevP is a platform that hosts a variety of projects along with their complete source code. It allows developers to showcase and explore different projects across various domains.

![Desktop Screenshot 2024 01 25 - 23 24 12 94](https://github.com/MINAD0/AcademicDevProject/assets/34896655/5377cd3d-a1ed-43cc-acac-89bb900a79e1)
![Screenshot 2024-01-25 230159](https://github.com/MINAD0/AcademicDevProject/assets/34896655/db6fb25a-d1e9-4fdc-9b44-9f63d32c3f89)


## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Introduction

AcademicDevP is designed to be a centralized hub for developers to share and discover open-source projects. Whether you're looking for inspiration, collaboration, or just exploring different technologies, ProjectHub has you covered.

## Features

- Browse and explore a diverse range of projects.
- View project details, source code, and documentation.
- Submit your own projects to showcase to the community.
- Collaborate with other developers on interesting projects.

## Getting Started

### Prerequisites

Before you begin, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server/)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/projecthub.git
   cd AcademicDevP
```dotnet restore```
```dotnet build ```
2. Update the database connection string in appsettings.json:

"ConnectionStrings": {
    "DefaultConnection": "YourSQLServerConnectionStringHere"
}

3. Apply database migrations:
   ``` add-migration [migrationName]
   update-database```

 ### Usage
1. Browse through the platform to discover projects.
2. Click on a project to view its details, source code, and documentation.
3. Submit your own projects to contribute to the community.
   
## License

This project is licensed under the [MIT License](LICENSE).

The MIT License is a permissive open-source license. Feel free to use this project and its source code in your own projects. You can find a copy of the license in the [LICENSE](LICENSE) file.

---
**Note:** Customize this template to fit the specific details and structure of your AcademicDevP platform.
