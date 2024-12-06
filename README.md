# Contact List - Backend Service

Este projeto tem como objetivo servir como backend para integração com uma aplicação Angular, permitindo a realização de um CRUD de Contatos.

## Tecnologias Utilizadas

- **Entity Framework**
- **SQL Server**
- **Swagger**

## Como Utilizar o Serviço

Siga os passos abaixo para configurar e executar a aplicação:

### 1. Clone o Repositório

```bash
git clone https://github.com/MarcosVenicioSJr/ContactList.git
```

### 2. Compile o Projeto

Navegue até o diretório do projeto clonado e execute o comando:

```bash
dotnet build
```

### 3. Inicie a Aplicação

Escolha uma das opções abaixo para iniciar o serviço:

#### 3.1 Utilizando Docker

Certifique-se de ter o Docker instalado e execute:

```bash
docker run
```

#### 3.2 Iniciando com HTTP

Para rodar diretamente, utilize o comando:

```bash
dotnet run
```

## Recursos Disponíveis

Acesse o **Swagger UI** para explorar e testar os endpoints disponíveis. Após iniciar a aplicação, abra seu navegador e acesse:

```
http://localhost:<porta>/swagger
```

## Estrutura do CRUD

As seguintes operações estão disponíveis:

- **Create**: Adicionar um novo contato.
- **Read**: Consultar contatos existentes.
- **Update**: Atualizar informações de um contato.
- **Delete**: Remover um contato.

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto é licenciado sob os termos da [MIT License](LICENSE).
