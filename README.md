<h1 align="center">Hi!</h1>
<h3 align="center">my name is Israel Schroeder and that is my first project.</h3>

<p align="center">I used this to learn PHP, HTML5, CSS, JavaScript (JQuery) and MYSQL.</p>

<h4 align="center">
> :construction: Project in progress :construction:
</h4>


# Título do Projeto

Este projeto é para explorar as REST APIs e compreender como elas funcionam. Aprendi os princípios e técnicas que regem as chamadas HTTP. Aprendi como elas possibilitam a comunicação entre sistemas e aplicações web e como são utilizadas para acessar recursos e serviços de maneira simples e eficiente. Este projeto me deu uma base sólida para continuar desenvolvendo minhas habilidades em programação e tecnologia da web


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

## Tecnologias Utilizadas
- .NET
- MySQL
- Postman

.NET foi utilizado como a plataforma de desenvolvimento, permitindo a criação de uma API REST completa e funcional. Já o MySQL foi utilizado como banco de dados, armazenando as informações da aplicação de maneira eficiente e segura. Por fim, o Postman foi utilizado como ferramenta de teste, permitindo testar as chamadas HTTP da API de maneira simples e rápida.

## Aprendizados

Durante o meu projeto de aprendizagem sobre REST APIs, descobri que elas são um padrão de projeto de arquitetura da web que permite a comunicação entre sistemas e aplicações. Aprendi sobre as chamadas HTTP, como o método GET, POST, PUT, PATCH e DELETE. Além disso, também aprendi sobre a importância de utilizar URLs claras e significativas e o formato de resposta em JSON ou XML. Tudo isso me permitiu entender a potência das REST APIs e como elas são amplamente utilizadas em aplicações web modernas

