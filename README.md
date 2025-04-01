Anotações de um projeto de persistência de dados usando .NET frameworkcore. Projeto BlazorWebApp - Server
Para construir uma aplicação web, o primeiro passo que deve ser feito é ter um modelo/diagrama de classe, onde sejam explicitados todas as classes que comporão o sistema. No nosso caso, estamos utilizando as seguintes classes: Cliente, Funcionário, Pedido, ItemPedido e Produto.
Para construir esse sistema, vamos utilizar o padrão arquitetural monolítico. é um padrão arquitetural onde temos na mesma aplicação, o Backend e o Frontend. 
Nossa aplicação está subdividida/arquitetada com as seguintes pastas: Pasta data e uma subpasta context, que contêm uma classe chamada SQLServerContext, essa classe vai herdar a classe abstrata DBContext (obs.: Detalhar a estrutura da classe SQLServerContext). 
Pasta Entities ou model, nessa pasta teremos nossas classes anêmicas - detalhar o que é classe anêmica. 
Pasta Service; A pasta Service possuirá duas outras pastas, são elas: Implementation e Interface. Na pasta interface teremos as nossas interfaces, que vão conter as assinaturas dos métodos identificados no diagrama de classe, já na pasta Implementation, teremos as classes que vão implementar as interfaces.
Um dos arquivos importantes do nosso projeto é o appsettings.json3, é nesse arquivo que nós temos a nossa string de conexão, detalhada a seguir:
O arquivo program é um dos arquivos mais importantes da aplicação, pois é nesse arquivo que vão ser realizados todos os registros de classes e interfaces que utilizaremos em nosso projeto.

IMPORTANTE: Para que possamos utilizar o entity frameworkcore e o sql server, deveremos instalar os seguintes pacotes nuget:
Microsoft entity framework core
Microsoft entity frameworkcore tools
Microsoft entity frameworkcore design
Microsoft entity frameworkcore sql server

Para fazer essas instalações, basta clicar com o botão direito no projeto BlazorVendas, selecionar a opção "Selecionar pacotes do nuget", clicar na aba procurar e instalar cada um dos pacotes.
