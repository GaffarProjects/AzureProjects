# DoomSkillsWeb - ASP.NET Core Web Application

A modern ASP.NET Core web application built with Razor Pages, deployed to Azure App Service using GitHub Actions CI/CD pipeline.

## 🚀 Features

- ASP.NET Core 8.0 Razor Pages
- Responsive design with custom styling
- Automated deployment to Azure Web App
- GitHub Actions CI/CD pipeline
- Production-ready architecture

## 📋 Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Azure Account](https://azure.microsoft.com/free/)
- [Git](https://git-scm.com/)

## 🛠️ Local Development

### Clone the Repository
```bash
git clone https://github.com/GaffarProjects/AzureProjects.git
cd AzureProjects/DoomSkillsWeb

dotnet restore
dotnet build
dotnet run

git clone https://github.com/GaffarProjects/AzureProjects.git
cd AzureProjects/DoomSkillsWeb

### Run Locally

dotnet restore
dotnet build
dotnet run

text

Visit `http://localhost:5006` in your browser.

## ☁️ Azure Deployment

### Manual Deployment via Azure CLI

1. **Login to Azure:**

az login

2. **Create Resource Group:**


3. **Create App Service Plan:**


4. **Create Web App:**


5. **Deploy Application:**

dotnet publish -c Release -o ./publish
cd publish
zip -r publish.zip .
az webapp deployment source config-zip --resource-group DoomSkillsRG --name doomskills --src publish.zip

### Automated Deployment via GitHub Actions

This project uses GitHub Actions for continuous deployment.

#### Setup Instructions:

1. **Download Publish Profile:**
- Go to Azure Portal → Your Web App → Overview
- Click "Get publish profile" and download the file

2. **Add GitHub Secret:**
- Go to your GitHub repository → Settings → Secrets and variables → Actions
- Click "New repository secret"
- Name: `AZURE_WEBAPP_PUBLISH_PROFILE`
- Value: Paste the entire contents of the publish profile file

3. **GitHub Actions Workflow:**
- The workflow file is located at `.github/workflows/deploy.yml`
- Triggers automatically on push to `main` branch
- Builds, tests, and deploys to Azure Web App

## 📂 Project Structure


DoomSkillsWeb/
├── Pages/
│ ├── Index.cshtml # Homepage
│ ├── _Layout.cshtml # Layout template
│ └── _ViewStart.cshtml
├── wwwroot/ # Static files
├── Program.cs # Application entry point
├── appsettings.json # Configuration
└── DoomSkillsWeb.csproj # Project file

## 🔧 Configuration

### Application Settings

Update `appsettings.json` for environment-specific configurations.

### Azure Configuration

Set environment variables in Azure Portal:
- Go to Web App → Configuration → Application settings
- Add custom app settings as needed

## 🧪 Testing


dotnet test



## 📦 Build & Publish


Build
dotnet build --configuration Release

Publish
dotnet publish --configuration Release --output ./publish

## 🌐 Live Application

Visit the live application at: `https://doomskills.azurewebsites.net`

## 👤 Author

**Gaffar**
- GitHub: [@GaffarProjects](https://github.com/GaffarProjects)
- Portfolio: Building cloud solutions with Azure and .NET

## 📝 License

This project is open source and available under the MIT License.

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

**Built with ❤️ using ASP.NET Core and Azure Cloud**
