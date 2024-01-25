# AcademicDevP

AcademicDevP is a platform that hosts a variety of projects along with their complete source code. It allows developers to showcase and explore different projects across various domains.
![ProjectHub Screenshot](/wwwroot/Images/project-screenshot.png)
![image](https://github.com/MINAD0/AcademicDevProject/assets/34896655/a3df7b05-4874-4dfa-808d-aed7e3506739)


## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [Database Setup](#database-setup)
- [License](#license)
- [Acknowledgements](#acknowledgements)

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
   
