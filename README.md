
# Título do Projeto

Este é um projeto de aprendizado para entender a comunicação com o banco de dados e a estrutura de uma API utilizando .NET.


## Documentação da API

#### Adiciona um filme ao banco

```http
  POST /movie

  Exemplo

  {
    "title": "Interestelar",
    "gender": "Ficção científica/Aventura",
    "duration": 169
  }
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `title`      | `string` | **Obrigatório**. O título do filme|
| `gender`      | `string` | **Obrigatório**. O gênero do filme |
| `duration`      | `int` | **Obrigatório**. A duração do filme |

#### Retorna todos os itens

```http
  GET /movie
```

#### Retorna um item específico

```http
  GET /movie/id
```

#### Altera parcialmente um item

```http
  PATCH /movie/id
```

#### Altera o objeto inteiro

```http
  PUT /movie/id

  Exemplo

  {
  "title": "string",
  "gender": "string",
  "duration": 500
  }
```

#### Deleta um item

```http
  DELETE /movie/id
```



## Aprendizados

Neste projeto aprendi a utilizar e criar WEB API's utilizando .NET. Com isso consegui realizar a integração do conhecimento de banco de dados e fazer com que os dados fossem armazenados através das DTO's.

