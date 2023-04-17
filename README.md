# API Car Store GraphQL

This project is an API for a car store, developed during a bootcamp at Senai using GraphQL and C# as the main technologies. The API allows users to create, update, and delete cars and perform searches using different filters.

## Technologies Used

- C#
- ASP.NET Core 3.1
- Entity Framework Core
- GraphQL
- AutoMapper

## Architecture and Best Practices

This project was developed using best practices for software architecture and design patterns. The code was organized in different layers, separating concerns and responsibilities to make the application more maintainable and scalable. The layers used are:

- Presentation Layer: responsible for exposing the API endpoints and mapping the incoming requests to the correct handlers.
- Application Layer: responsible for processing the incoming requests, executing the business logic, and returning the results.
- Domain Layer: responsible for defining the entities, interfaces, and services that represent the business domain of the application.
- Infrastructure Layer: responsible for implementing the interfaces defined in the Domain layer, providing concrete implementations for data access and other infrastructure concerns.

In addition, the code was developed following SOLID principles, which promotes better code quality, flexibility, and testability.

## Scalability and Maintainability

This project was designed with scalability and maintainability in mind. By following best practices for software architecture and design patterns, the application can easily be extended with new features and functionality without affecting the existing codebase. In addition, the use of GraphQL allows clients to specify exactly the data they need, reducing the amount of data transferred over the network and improving the performance of the application.

## How to run the project

1. Clone the repository
2. Open the solution in Visual Studio
3. Open the Package Manager Console and run the following command to create the database:

```bash
Update-Database
```

4. Run the project in Visual Studio
5. Open your browser and go to [https://localhost:5001/graphql](https://localhost:5001/graphql) to access the GraphQL Playground

## Queries and Mutations

The API supports the following queries and mutations:

### Queries

- `cars`: returns a list of all cars.
- `car(id: Int!)`: returns a car by its id.
- `searchCars(make: String, model: String, minPrice: Float, maxPrice: Float)`: searches for cars using the specified filters.

### Mutations

- `createCar(input: CarInput!): Car`: creates a new car.
- `updateCar(id: Int!, input: CarInput!): Car`: updates an existing car.
- `deleteCar(id: Int!): Boolean`: deletes a car by its id.

## Input Types

The API defines the following input types:

### CarInput

- `make: String!`
- `model: String!`
- `year: Int!`
- `price: Float!`

## Database

The database used in this project is a Microsoft SQL Server database, created using Entity Framework Core. The database has a single table, called "Cars", which contains the following fields:

- Id (int, primary key)
- Make (nvarchar(50), not null)
- Model (nvarchar(50), not null)
- Year (int, not null)
- Price (float, not null)

## Contributors

- [Eduardo Borges Gonçalves](https://github.com/eduardo-borges-goncalves) - Developer

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

# API Car Store GraphQL

Este projeto é uma API para uma loja de carros, desenvolvido durante um bootcamp no Senai usando GraphQL e C# como principais
tecnologias. A API permite que os usuários criem, atualizem e excluam carros e realizem buscas usando diferentes filtros.

## Tecnologias utilizadas

- C#
- ASP.NET Core 3.1
- Entity Framework Core
- GraphQL
- AutoMapper

## Arquitetura e boas práticas

Este projeto foi desenvolvido utilizando as melhores práticas de arquitetura de software e design patterns. O código foi organizado em diferentes camadas, separando as responsabilidades para tornar a aplicação mais fácil de manter e escalável. As camadas utilizadas são:

- Camada de apresentação: responsável por expor os endpoints da API e mapear as requisições recebidas para os handlers corretos.
- Camada de aplicação: responsável por processar as requisições recebidas, executar a lógica de negócio e retornar os resultados.
- Camada de domínio: responsável por definir as entidades, interfaces e serviços que representam o domínio de negócio da aplicação.
- Camada de infraestrutura: responsável por implementar as interfaces definidas na camada de domínio, fornecendo implementações concretas para acesso a dados e outras preocupações de infraestrutura.

Além disso, o código foi desenvolvido seguindo os princípios SOLID, que promovem uma melhor qualidade de código, flexibilidade e testabilidade.

## Escalabilidade e manutenção

Este projeto foi projetado com escalabilidade e manutenção em mente. Seguindo as melhores práticas de arquitetura de software e design patterns, a aplicação pode facilmente ser estendida com novas funcionalidades sem afetar o código existente. Além disso, o uso de GraphQL permite que os clientes especifiquem exatamente os dados de que precisam, reduzindo a quantidade de dados transferidos pela rede e melhorando o desempenho da aplicação.

## Como executar o projeto

1. Clone o repositório
2. Abra a solução no Visual Studio
3. Abra o Package Manager Console e execute o seguinte comando para criar o banco de dados:

```bash
Update-Database
```

4. Execute o projeto no Visual Studio
5. Abra seu navegador e vá para [https://localhost:5001/graphql](https://localhost:5001/graphql) para acessar o GraphQL Playground

## Consultas e mutações

A API suporta as seguintes consultas e mutações:

### Consultas

- `cars`: retorna uma lista de todos os carros.
- `car(id: Int!)`: retorna um carro pelo seu id.
- `searchCars(make: String, model: String, minPrice: Float, maxPrice: Float)`: busca carros usando os filtros especificados.

### Mutations

- `createCar(input: CarInput!): Car`: cria um novo carro.
- `updateCar(id: Int!, input: CarInput!): Car`: atualiza um carro existente.
- `deleteCar(id: Int!): Boolean`: exclui um carro pelo seu id.

## Tipos de entrada

A API define os seguintes tipos de entrada:

### CarInput

- `make: String!`
- `model: String!`
- `year: Int!`
- `price: Float!`

## Banco de dados

O banco de dados utilizado neste projeto é um banco de dados Microsoft SQL Server, criado usando o Entity Framework Core. O banco de dados
contém apenas uma tabela, `Cars`, que possui os seguintes campos:

- `Id`: chave primária do carro
- `Make`: marca do carro
- `Model`: modelo do carro
- `Year`: ano de fabricação do carro
- `Price`: preço do carro

## Contribuição

Sinta-se à vontade para contribuir com o projeto criando issues ou enviando pull requests. Todas as contribuições são bem-vindas!

