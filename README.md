# PoC GitHub Actions CI pipeline .NET Framework

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-GHActions-CI-NetFramework.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-GHActions-CI-NetFramework)
[![GitHub license](https://img.shields.io/github/license/GuilhermeStracini/POC-GHActions-CI-NetFramework)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework)
[![GitHub last commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-GHActions-CI-NetFramework)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework)

[![Build & Bump Version](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-bump-version.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-bump-version.yml)
[![Build & Deploy](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-deploy.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/build-deploy.yml)
[![Linter check](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/linter.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/linter.yml)
[![Update packages](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/update-packages.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-GHActions-CI-NetFramework/actions/workflows/update-packages.yml)

[![Maintainability](https://api.codeclimate.com/v1/badges/83c1d6f45041d9d67d30/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/83c1d6f45041d9d67d30/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-GHActions-CI-NetFramework/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-GHActions-CI-NetFramework)

🔬 PoC of a .NET Framework project using GitHub Actions for pipelines

---

This repository is a playground/sandbox of a .NET Framework (4.8) project/solution using GitHub Actions to: 

-  Checkout
-  Configure environment (MSBuild, VSTest, NuGet, Java - for SonarCloud scanner)
-  Cache dependencies (SonarCloud scanner and packages)
-  Restore
-  Build
-  Test
-  Code Quality & Metrics (Sonar Cloud, Codacy, Code Climate, Snyk, Codecov, CodeFactor)
-  Request approval to publish/deploy
-  Upload artifacts via FTP
