<h1 align="center">Olá!</h1>
<h3 align="center">21/02/2023</h3>


# Título do Projeto

Este projeto tem como objetivo explorar as REST APIs e compreender como elas funcionam, além de apresentar os aprendizados adquiridos durante o processo.


## Documentação da API

### 1. Movie

#### Estrutura


| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `title`      | `string` | **Obrigatório**. O título do filme|
| `gender`      | `string` | **Obrigatório**. O gênero do filme |
| `duration`      | `int` | **Obrigatório**. A duração do filme |


#### Adiciona um filme

```
  POST /movie

  Exemplo

  {
    "title": "Interestelar",
    "gender": "Ficção científica/Aventura",
    "duration": 169
  }
```

#### Retorna todos os filmes

```
  GET /movie
```

#### Retorna um filme específico

```
  GET /movie/id
```

#### Altera parcialmente um filme

```
  PATCH /movie/id
```

#### Altera o filme inteiro

```
  PUT /movie/id
```

#### Deleta um filme

```
  DELETE /movie/id
```

### 2. Cine

#### Estrutura


| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `name`      | `string` | **Obrigatório**. O nome do cinema|
| `addressId`      | `int` | **Obrigatório**. O id do endereço (chave relacionada com address) |


#### Adiciona um cinema

```
  POST /cine

  Exemplo

  {
    "name": "CinePlex",
    "addressId": 1
  }
```

#### Retorna todos os cinemas

```
  GET /cine
```


#### Retorna um cinema específico

```
  GET /cine/{id}
```


#### Atualiza as informações de um cinema específico

```
  PUT /cine/{id}
```


#### Deleta um cinema específico

```
  DELETE /cine/{id}
```

### 3. Address

#### Estrutura


| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `street`      | `string` | **Obrigatório**. Um endereço|
| `number`      | `int`    | **Obrigatório**. O número|


#### Adiciona um endereço

```
  POST /address

  Exemplo

  {
    "name": "CinePlex",
    "addressId": 1
  }
```

#### Retorna todos os endereço

```
  GET /address
```


#### Retorna um endereço específico

```
  GET /address/{id}
```


#### Atualiza as informações de um endereço específico

```
  PUT /address/{id}
```


#### Deleta um endereço específico

```
  DELETE /address/{id}
```

## Tecnologias Utilizadas
- .NET
- MySQL
- Insomnia
- Ubuntu

.NET foi utilizado como a plataforma de desenvolvimento, permitindo a criação de uma API REST completa e funcional. Já o MySQL foi utilizado como banco de dados, armazenando as informações da aplicação de maneira eficiente e segura. Por fim, o Insomnia foi utilizado como ferramenta de teste, permitindo testar as chamadas HTTP da API de maneira simples e rápida.

## Aprendizados

Durante meu projeto de aprendizagem sobre REST APIs, aprendi que elas são um padrão de projeto de arquitetura da web que permite a comunicação entre sistemas e aplicações, utilizando o protocolo HTTP. Aprendi sobre os principais métodos HTTP, URLs claras e significativas e o formato de resposta em JSON ou XML.

Também aprendi sobre a importância de utilizar DTOs para transferir dados de forma segura e eficiente entre diferentes camadas da aplicação, a técnica de Lazy Loading para melhorar o desempenho e a eficiência da aplicação, e sobre os relacionamentos entre entidades para o design e organização do banco de dados.

Essas habilidades me permitiram entender a potência das REST APIs e sua ampla utilização em aplicações web modernas. Foi uma experiência valiosa para o meu desenvolvimento como desenvolvedor de software.

