# DTE Common Lambda
## Table of Contents
- [DTE Common Lambda](#dte-common-lambda)
  - [Table of Contents](#table-of-contents)
  - [Project Description](#project-description)
  - [How to Install and Run the Project](#how-to-install-and-run-the-project)
  - [How to Deploy the Project to AWS Lambda](#how-to-deploy-the-project-to-aws-lambda)
  - [How to Use the Project](#how-to-use-the-project)

## Project Description
DTE Common Lambda is a C#-developed set of utilities and common functionalities designed to be used in AWS Lambda functions. The main objective of this project is to provide an efficient and reusable code base for common operations in AWS Lambda functions such as handling different types of events (like CognitoCustomMessageEvent, ScheduledEvent, etc.), resolving handlers, and executing tasks.

The codebase was developed using the .NET Core framework and is intended to run on AWS Lambda. It offers flexibility and robustness for different use cases, allowing developers to focus more on the business logic of their applications rather than the setup and teardown of Lambda functions. 

## How to Install and Run the Project
Follow these steps to set up and run the DTE Common Lambda project locally:

1. Ensure you have the .NET SDK installed on your machine. If not, download and install it from the .NET official website.
2. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/PA-NIHR-CRN/dte-common-lambda.git
    ```
3. Navigate to the project folder:
    ```bash
    cd dte-common-lambda
    ```
4. Restore the required dependencies and build the project:
    ```bash
    dotnet restore
    dotnet build
    ```
5. Start the development server:
    ```bash
    dotnet run
    ```
## How to Deploy the Project to AWS Lambda
Follow these steps to deploy the DTE Common Lambda project to AWS Lambda:

1. Ensure you have the AWS CLI installed and configured on your machine. If not, download and install it from the AWS CLI official website and follow the configuration guide.
2. Install the AWS Lambda .NET Core Global Tool:
    ```bash
    dotnet tool install -g Amazon.Lambda.Tools
    ```
3. Follow the prompts to configure the deployment settings. Once the deployment is complete, you will receive the Lambda function name for accessing your deployed application.

## How to Use the Project
The DTE Common Lambda project is a set of utilities and common functionalities that can be used in AWS Lambda functions. To use this project, you will need to import the required modules and methods into your own AWS Lambda functions and configure them according to your specific needs.

Detailed usage instructions can be found in the source code comments and documentation.
