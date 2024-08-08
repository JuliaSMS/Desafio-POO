# Sistema de Celulares

Este projeto é uma implementação de um sistema de gerenciamento de celulares utilizando Programação Orientada a Objetos (POO) no .NET. O sistema inclui uma abstração para celulares e implementações específicas para modelos de Nokia e iPhone.

## Objetivo

Modelar um sistema que permita a criação e manipulação de diferentes tipos de celulares, utilizando uma classe abstrata para definir um modelo genérico e classes derivadas para implementar comportamentos específicos.

## Estrutura do Projeto

O projeto é composto pelas seguintes classes:

- **`Smartphone`**: Classe abstrata que define as propriedades e métodos comuns a todos os celulares.
- **`Nokia`**: Classe derivada que implementa o método de instalação de aplicativos específico para celulares Nokia.
- **`iPhone`**: Classe derivada que implementa o método de instalação de aplicativos específico para iPhones.
- **`Program`**: Classe com o método `Main`, que serve como ponto de entrada do aplicativo e demonstra o uso das classes `Nokia` e `iPhone`.
