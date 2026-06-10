# Credit Bureau Integration Platform

## Overview

A secure enterprise-style credit verification platform built using ASP.NET Core Web API, SQL Server, and React.

This project simulates real-world credit bureau integrations used by automotive finance and lending organizations. It includes dealer validation, credit report retrieval, finance approval workflows, role-based security, and audit logging.

------------------------------------------------------------

## Features

### Credit Bureau Integration Simulator
- Simulated credit report retrieval
- Credit score generation
- Approval and review recommendations
- REST API endpoints

### Dealer Validation Module
- Dealer verification workflow
- Dealer code validation
- Active/inactive dealer status management

### Finance Approval Workflow
- Loan application processing
- Automated approval rules
- Manual review routing
- Decision tracking

### Security
- JWT Authentication
- Role-Based Authorization
- Protected API endpoints
- Secure access control

### Audit Logging
- User activity tracking
- Request logging
- Approval history
- Compliance support

------------------------------------------------------------

## Technology Stack

### Backend
- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server

### Frontend
- React.js
- JavaScript
- REST API Integration

### Security
- JWT Authentication
- Role-Based Access Control

### DevOps
- GitHub Actions
- Docker
- CI/CD Pipeline

------------------------------------------------------------

## Architecture

Frontend (React)
        ↓
ASP.NET Core Web API
        ↓
Credit Bureau Services
        ↓
SQL Server Database

------------------------------------------------------------

## Planned Enhancements

- Multi-bureau support (Experian, Equifax, TransUnion simulation)
- Dealer management dashboard
- Credit score analytics
- Docker containerization
- GitHub Actions CI/CD
- Automated testing
- Azure deployment

------------------------------------------------------------

## Resume Highlights

- Developed enterprise-grade credit bureau integration simulator
- Implemented dealer validation and finance approval workflows
- Built secure JWT-based authentication and authorization
- Designed RESTful APIs using ASP.NET Core
- Created audit logging and compliance-focused tracking features
- Integrated SQL Server persistence with Entity Framework Core

------------------------------------------------------------

## Project Status

Active Development

------------------------------------------------------------

## How to Run & Test the Project

1. Run Backend (.NET API)

cd backend/CreditBureau.API
dotnet run

Expected output:
Now listening on: http://localhost:5166

------------------------------------------------------------

2. Open Swagger UI

http://localhost:5166/swagger

------------------------------------------------------------

3. Test Credit Report API

GET /api/CreditReport/{customerName}

Example:
http://localhost:5166/api/CreditReport/John

Response:
{
  "customerName": "John",
  "creditScore": 720,
  "status": "Approved"
}

------------------------------------------------------------

4. Test Dealer Validation API

GET /api/dealer/validate/{dealerCode}

Example:
http://localhost:5166/api/dealer/validate/DLR1001

Response:
{
  "dealerCode": "DLR1001",
  "isValid": true,
  "dealerStatus": "Active"
}

------------------------------------------------------------

5. Optional Frontend Setup

cd frontend
npm install
npm start

Frontend runs at:
http://localhost:3000

------------------------------------------------------------
