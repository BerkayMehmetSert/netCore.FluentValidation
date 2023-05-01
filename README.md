# NetCore FluentValidation Example

## Description

This code example creates a Product class and performs basic CRUD operations in an ASP.NET Core Web API using the Fluent Validation library to validate the class's correctness.

## How Does It Work?

The code handles HTTP requests to the API and uses a simple **List<Product>** as the data storage method.

- The **GetAllProducts()** method returns all the available products.
- The **GetProductById(int id)** method returns a specific product with the given ID.
- The **CreateProduct(Product request)** method creates and adds a new product.
- The **UpdateProduct(int id, Product request)** method updates a specific product.
- The **DeleteProduct(int id)** method deletes a specific product.

Before each request, the **ProductValidato**r class is used to validate the accuracy of the Product class. If the Product class cannot be validated, the request is rejected and the relevant error message is returned.

## Installing

1. Clone the repository

```bash
git clone https://github.com/BerkayMehmetSert/netCore.FluentValidation.git
```

2. Install the dependencies
```bash
dotnet restore
```

3. Run the project
```bash
dotnet run
```

## Usage

The API allows you to manage products. You can create, update, delete, and retrieve products.

**Get all products**
```bash
Get /api/products
```

Request body:
```json
{
  "success": true,
  "error": null,
  "data": [
    {
      "id": 1,
      "name": "Product 1",
      "description": "Description 1",
      "price": 10
    },
    {
      "id": 2,
      "name": "Product 2",
      "description": "Description 2",
      "price": 20
    }
  ]
}
```

**Get a product by id**
```bash
Get /api/products/{id}
```

Response body:
```json
{
  "success": true,
  "error": null,
  "data": {
    "id": 1,
    "name": "Product 1",
    "description": "Description 1",
    "price": 10
  }
}
```

**Create a product**
```bash
Post /api/products
```

Request body:
```json
{
  "id": 3,
  "name": "Product 3",
  "description": "Description 3",
  "price": 30
}
```

Response body:
```json
{
  "success": true,
  "error": null,
  "data": {
    "id": 3,
    "name": "Product 3",
    "description": "Description 3",
    "price": 30
  }
}
```

**Update a product**
```bash
Put /api/products/{id}
```

Request body:
```json
{
  "id": 3,
  "name": "Product 3",
  "description": "Description 3",
  "price": 30
}
```

Response body:
```json
{
  "success": true,
  "error": null,
  "data": {
	"id": 3,
	"name": "Product 3",
	"description": "Description 3",
	"price": 30
  }
}
```

**Delete a product**
```bash
Delete /api/products/{id}
```

Response body:
```json
{
  "success": true,
  "error": null,
  "data": {
    "id": 1,
    "name": "Product 1",
    "description": "Description 1",
    "price": 10
  }
}
```
