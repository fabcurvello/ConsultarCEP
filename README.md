# Consultar CEP (Xamarin.Forms)

> Repositório didático: aplicativo multiplataforma de consulta de CEP.

## Sobre o projeto

Aplicativo que consulta um **CEP brasileiro** na API pública [ViaCEP](https://viacep.com.br) e mostra o endereço correspondente. Foi feito com **Xamarin.Forms**, que compartilha o mesmo código C# entre Android, iOS e Windows (UWP).

## Contexto acadêmico

Exercício aplicado em sala de aula, usado como prática guiada com os alunos.

## Estrutura da solução (`CEP.sln`)

- `CEP/`: projeto compartilhado, com a tela (`MainPage.xaml`) e a lógica de consulta.
- `CEP.Android/`: projeto específico para Android.
- `CEP.iOS/`: projeto específico para iOS.
- `CEP.UWP/`: projeto específico para Windows.

## Conceitos trabalhados

- Desenvolvimento multiplataforma com Xamarin.Forms
- Interface declarada em XAML
- Requisições HTTP para uma API REST (`WebClient`)
- Desserialização de JSON com Newtonsoft.Json

## Tecnologias

- **C#** / .NET
- **Xamarin.Forms**
- **XAML**
- **Newtonsoft.Json**
- API **ViaCEP**

## Como executar

Abra `CEP.sln` no **Visual Studio** com a carga de trabalho de desenvolvimento mobile (.NET/Xamarin) instalada, escolha o projeto da plataforma desejada como projeto de inicialização e execute.

> O projeto é de 2018. O Xamarin foi descontinuado pela Microsoft e substituído pelo .NET MAUI, então versões atuais do Visual Studio podem exigir migração.

## Autor

**Fabricio Curvello**: professor de desenvolvimento de software no SENAI-RJ (desde 1997) e em faculdades do grupo Ânima Educação (IBMR e UNA).

- GitHub: [github.com/fabcurvello](https://github.com/fabcurvello)
- LinkedIn: [linkedin.com/in/fabriciocurvello](https://www.linkedin.com/in/fabriciocurvello)
- YouTube: [@fabriciocurvello](https://www.youtube.com/@fabriciocurvello)
