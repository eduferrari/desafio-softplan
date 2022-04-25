# Desafio Softplan 
## Aplicação Web ASP .Net Core, faz cálculo em memória de juros compostos. O projeto possui duas API's:
- TaxaDeJurosAPI: Responde pelo path "/taxaJuros", retornando a taxa juros de 1% ou 0,01;
- CalculaJurosAPI: Responde pelo path "/calculajuros", faz um cálculo em memória de juros compostos. Respondendo também pelo path relativo "/showmethecode" que retorna a url do projeto no github.

### Instruções para a execução do projeto:
- Abrir diretorio da api **TaxaServicoAPI** pelo terminal, rode o comando `dotnet run --project TaxaJurosAPI.csproj`;
- Abrir diretorio da api **CalculaJurosAPI** pelo terminal, rode o comando `dotnet run --project CalculaJurosAPI.csproj`;

### Instruções para a acesso a documentação Swagger:
- Documentação **TaxaServicoAPI**: `http://localhost:5003/documentacao/index.html`;
- Documentação **CalculoJurosAPI**: `http://localhost:5001/documentacao/index.html`;

### Instruções para a execução dos teste unitários:
- Abrir a IDE do Visual Studio.
- Os testes estão localizados na pasta 'test', selecionar o teste desejado;
- Clique com o botão direito do mouse, selecione a opção 'Run Test (Executar Testes)'
- O Gerenciador de testes será aberto.
Obs: execute os serviços das api pelo prompt de comando, conforme descrito acima.