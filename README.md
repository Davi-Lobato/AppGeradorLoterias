# Gerador de Loterias

Aplicação desktop em C# (Windows Forms) que gera palpites para as principais loterias da Caixa.

## Jogos disponíveis

- Mega-Sena
- Lotofácil
- Quina
- Lotomania
- Dia de Sorte
- Super Sete

Cada jogo abre em uma janela própria. Além de sortear os números, o app conta quantos são pares e ímpares e classifica o equilíbrio do palpite (de "muito baixo" a "muito alto").

## Estrutura

```
AppGeradorLoterias/
├── AppGeradorLoterias.sln
└── AppGeradorLoterias/
    ├── Form1.cs            # tela inicial com um botão por jogo
    ├── Formularios/        # uma tela para cada loteria
    └── Program.cs
```

## Como rodar

Requer Windows e .NET Framework 4.7.2.

1. Abra `AppGeradorLoterias/AppGeradorLoterias.sln` no Visual Studio
2. Pressione **F5**

---
Projeto de estudo. Os números são aleatórios e não aumentam a chance de ganhar.
