# Flexpay Bad Products API

## Description
This simple web API application serves as a simplified model that simulates typical payment catalog operations. Despite its simplicity, the application contains several coding issues that need to be addressed before this application can be included in any CI/CD pipeline and deployed to a production environment.

## Requirements
Your task is to identify and resolve the issues in this API using best practices in API development, focusing on the following priorities:

### Must have:
- **Time constraint** : Make sure that time constraints are respected.
- **Unit Testing**: Ensure the code is testable by implementing unit tests.
- **Refactorings**: Enhance overall code quality and projects structure to make them more robust and maintainable.

### Should have
- **Separation of responsibilities**: Ensure that functionalities are properly separated into layers, preventing any layer from taking on multiple responsibilities.
- **API Specs**: Improve readability and structure by adhering to RESTful API conventions and documentation.

### Could have
- **Functional Testing**: Implement functional tests to ensure the API functions as expected.
- **SOLID**: Ensure full compliance with SOLID design principles.
- **Caching**: Implement caching mechanisms to reduce database load.
- **Containerization**:  Set up configurations for containerizing the application.
- **Logging and monitoring**: Implement logging and monitoring capabilities for better observability.

### Out of scope
- **Database management**: The application uses EF Core with an in-memory database context for testing. Database management improvements are not within the scope.
- **Authentication**:  Authentication is not required for this exercise.

## Tasks
1. Create a new branch from the master branch.
2. Address the issues to improve code quality.
3. Submit a pull request to the master branch, explaining the changes made and the reasons behind them.
