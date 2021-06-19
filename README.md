# API de cadastro de livros
<p align="center">

 ![](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white) ![](https://img.shields.io/badge/NuGet-004880?style=for-the-badge&logo=nuget&logoColor=white) ![](https://img.shields.io/badge/Microsoft-666666?style=for-the-badge&logo=microsoft&logoColor=white) ![](https://img.shields.io/badge/MongoDB-4EA94B?style=for-the-badge&logo=mongodb&logoColor=white) ![](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white) ![](https://img.shields.io/badge/Visual_Studio_Code-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)

</p>

Api de cadastro de livros desenvolvida com ASP.NET Core 5.0 e MongoDb Atlas.

## Motivação
Lendo a página da [documentação](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-5.0&tabs=visual-studio) oficial da Microsoft sobre o desenvolvimento de uma API com ASP.NET e MongoDB eu desenvolvi a base desse projeto, mas pensei que poderia melhorá-la e inserir alguns padrões de projetos assim como deixar um pouco mais completa.

![endpoints image](./images/api-1.png)
## Foi adicionado ao projeto:
 * Camada de Entidades;
 * Mais campos no modelo de entidade *Book* para deixá-lo mais completo de informações;
 * Modelo de entidade de inserção de dados base para a criação de um novo livro;
 * Mapeamento do modelo de entrada para o modelo de dados; 
 * Inteface para a camada de serviços;
 * Separação da interface de configuração do mongo;
 * Padrão **Repository** com interface e implementação para desacoplar da **Service**;
 * Novo endpoint *HttpPach* para atualizar apenas o preço do produto;
 * Comentários do swagger para melhorar a documentação para quem for consumir a API;
 * Códigos http de retorno dos *Endpoints*;

![](http://ForTheBadge.com/images/badges/built-with-love.svg)
