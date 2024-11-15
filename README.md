# PoC GitHub Actions CI Pipeline for .NET Framework

[![WakaTime](https://wakatime.com/badge/github/GuilhermeStracini/POC-GHActions-CI-NetFramework.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-GHActions-CI-NetFramework)
[![License](https://img.shields.io/github/license/GuilhermeStracini/POC-GHActions-CI-NetFramework)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework)
[![Last Commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-GHActions-CI-NetFramework)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework)

[![Build & Bump Version](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-bump-version.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-bump-version.yml)
[![Build & Deploy](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-deploy.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-deploy.yml)
[![Linter Check](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/linter.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/linter.yml)
[![Update Packages](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/update-packages.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/update-packages.yml)

[![Maintainability](https://api.codeclimate.com/v1/badges/83c1d6f45041d9d67d30/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/83c1d6f45041d9d67d30/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-GHActions-CI-NetFramework)

---

## Overview

This repository demonstrates a **proof of concept (PoC)** for implementing a CI/CD pipeline for a **.NET Framework 4.8** project using **GitHub Actions**. 

🔗 For a detailed walkthrough, check out the accompanying blog article:  
[Using GitHub Actions to Create a .NET Framework Pipeline: Build, Test, and Deploy!](https://blog.guilhermebranco.com.br/using-github-actions-to-create-a-net-framework-pipeline-build-test-and-deploy/)

---

## Features

### Pipeline Highlights

- **Environment Setup**:
  - Configure tools (MSBuild, VSTest, NuGet, Java for SonarCloud).
  - Cache dependencies for faster execution.

- **Build and Test**:
  - Restore dependencies and build the project.
  - Run unit tests using VSTest.

- **Code Quality and Security**:
  - Generate metrics using SonarCloud, Codacy, Code Climate, Snyk, and more.

- **Deployment**:
  - Request approval for deployment.
  - Upload artifacts via FTP.
  - Execute deployment commands via SSH.

### Pipeline Workflow

```mermaid
graph TD
    A[GitHub Actions Trigger] --> B[Checkout Code]
    B --> C[Configure Environment]
    C --> D[Restore Dependencies]
    D --> E[Build Project]
    E --> F[Test Project]
    F --> G{Code Quality Analysis}
    G -->|Pass| H[Upload Artifacts via FTP]
    G -->|Fail| I[Stop Pipeline]
    H --> J[Request Deployment Approval]
    J --> K[Deploy via SSH]
```

---

## Getting Started

### Prerequisites

Ensure you have the following tools installed:

- **.NET Framework Developer Tools**  
- **Git**  
- CI/CD tools for your environment as outlined in the workflow scripts.

### Steps to Use

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework.git
   ```

2. **Review and Customize**:
   - Review the GitHub Actions workflows in `.github/workflows/` to tailor them to your needs.

3. **Run Locally** (Optional):
   - Build and test the project locally:
     ```bash
     msbuild YourSolution.sln
     vstest.console.exe YourTests.dll
     ```

4. **Push Changes**:
   - Push changes to trigger the pipeline:
     ```bash
     git push origin main
     ```

---

## Contribution

Contributions are welcome!  
Feel free to fork this repository, open issues, or submit pull requests to enhance the pipeline or project functionality.

---

## License

This project is licensed under the [MIT License](LICENSE).
