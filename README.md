<h1 align="center">
  <br />
  <br />
  <img alt="Altaliza" src="https://user-images.githubusercontent.com/48810400/130319364-40a51bfe-2037-4bc2-b5d7-8e77f5c511b4.png" />
  <br />
  <br />
</h1>

<h3 align="center">
  Cidade Alta: Desafio FullStack
</h3>

<p align="center">
  <a href="#-sobre-a-aplicação">Sobre a aplicação</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-imagens">Imagens</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-como-usar">Como usar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-documentação-da-api">Documentação API</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-funcionalidades-da-aplicação">Funcionalidades</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-licença">Licença</a>
</p>

<br />

## 💬 Sobre a aplicação
Essa aplicação foi desenvolvida para o desafio fullstack do Cidade Alta.

O objetivo do desafio era demonstrar os conhecimentos em C#, .NET Core e React.

Desafio entregue no commit [feat(frontend): add CharacterVehicles page](https://github.com/pedr0fontoura/cda-altaliza/tree/e04d2e65b00d5f955edac768621357a5cb969b97)

## 📷 Imagens
<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/rKCaelJ.png" />
</h4>

<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/HrJ5h1P.png" />
</h4>

<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/iWrU61x.png" />
</h4>

<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/0ysWKZX.png" />
</h4>

<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/5QyXuCc.png" />
</h4>

<h4 align="center">
  <img alt="Altaliza" src="https://i.imgur.com/BWTAhSM.png" />
</h4>

## 💻 Como usar
Para clonar e rodar essa aplicação você vai precisar do [Git](https://git-scm.com/), [Node.js v14.15.1+](https://nodejs.org/en/), [Yarn v1.22.5+](https://yarnpkg.com/) e o [.NET Core 3.1](https://dotnet.microsoft.com/download).

Da sua linha de comando:
```bash
# Clone esse repositório
$ git clone https://github.com/pedr0fontoura/cda-altaliza

# Acesse o repositório
$ cd cda-altaliza
```

Para executar o backend, você irá precisar de um servidor MySQL rodando na sua máquina, edite as [configurações](https://github.com/pedr0fontoura/cda-altaliza/blob/c55affb09f7b3db7ebb90467e1a8727b4f3755e0/backend/Altaliza.Infra/Context/MySqlContext.cs#L13) conforme as informações do seu banco de dados.
```bash
# Navegue até o backend
$ cd backend

# Instale os pacotes NuGet e faça build da aplicação
$ dotnet build

# Prepare o banco de dados para a aplicação
$ dotnet ef database update --project Altaliza.Infra

# Execute a aplicação
$ dotnet run --project Altaliza.Application
```

Para o frontend, você primeiro precisa popular o arquivo `.env` seguindo o [`.env.example`](https://github.com/pedr0fontoura/cda-altaliza/blob/main/frontend/.env.example).

Em seguida:
```bash

# Navegue até o frontend
$ cd frontend

# Instale as dependências da aplicação
$ yarn

# Execute a aplicação React
$ yarn start
```

## 🧰 Documentação da API

Você pode acessar a documentação gerada automaticamente pelo SwaggerGen em `http://localhost:5000/swagger`

## ✨ Funcionalidades da aplicação
- **Listar os veículos para aluguel**
- **Alugar um veículo durante 1, 7 ou 15 dias**
- **Renovação automática de 1 dia para o aluguel**
- **Devolução / renovação manual de veículos alugados**
- **Listagem dos seus veículos alugados**
- **"Autenticação" no front-end**

## 📝 Licença

Esse projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.


<h1></h1>


Feito por Pedro Fontoura :wave: [Entre em contato!](https://twitter.com/pedr0fontoura)
