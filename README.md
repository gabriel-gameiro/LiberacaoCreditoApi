# Projeto LiberacaoCreditoApi

Este é um projeto de API desenvolvido em .NET 8 para o processamento de solicitações de crédito.

## Sobre o Projeto

O objetivo deste projeto é criar uma API que lida com requisições utilizando o padrão de design Template Method. 
O padrão Template Method é utilizado para definir o esqueleto de um algoritmo em uma superclasse, permitindo que subclasses redefinam certos passos desse algoritmo sem alterar sua estrutura geral.

## Estrutura do Projeto

```
LiberacaoCreditoApi/
│
├── Controllers/
│   └── LiberacaoController.cs
│
├── Models/
│   ├── RequisicaoSolicitacaoCredito.cs
│   ├── RetornoSolicitacaoCredito.cs
│   └── TipoCreditoEnum.cs
│
├── Services/
│   └── ProcessamentoLiberacaoService.cs
│
└── Templates/
    └── ProcessamentoLiberacaoCredito/
        ├── ProcessamentoTemplate.cs
        ├── ProcessamentoConsignado.cs
        ├── ProcessamentoDireto.cs
        ├── ProcessamentoImobiliario.cs
        ├── ProcessamentoPessoaFisica.cs
        └── ProcessamentoPessoaJuridica.cs

```

## Como Executar o Projeto

Para executar este projeto localmente, siga estas etapas:

1. Clone este repositório em sua máquina local.
2. Abra o projeto em sua IDE preferida (como Visual Studio ou Visual Studio Code).
3. Certifique-se de ter o .NET 8 SDK instalado em sua máquina.
4. Execute o comando `dotnet run` no terminal na pasta raiz do projeto.
