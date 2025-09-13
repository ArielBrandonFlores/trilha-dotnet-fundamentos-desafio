# Estacionamento - Sistema de Gerenciamento de Veículos

## Descrição do Projeto
Este projeto foi desenvolvido como parte do desafio da trilha .NET da [DIO](www.dio.me). O objetivo é criar um sistema para gerenciar um estacionamento, permitindo que os usuários adicionem, removam e listem veículos estacionados.

## Funcionalidades
O sistema de estacionamento possui as seguintes funcionalidades:

1. **Cadastrar Veículo**: Permite ao usuário adicionar a placa de um veículo ao estacionamento.
2. **Remover Veículo**: Permite ao usuário remover um veículo do estacionamento e calcular o valor cobrado com base no tempo que o veículo permaneceu estacionado.
3. **Listar Veículos**: Exibe todos os veículos atualmente estacionados. Se não houver veículos, uma mensagem informativa será exibida.
4. **Encerrar**: Finaliza a execução do programa.

### Atributos da Classe
- **precoInicial**: Tipo `decimal`. Representa o preço base cobrado para deixar um veículo estacionado.
- **precoPorHora**: Tipo `decimal`. Representa o preço cobrado por hora que o veículo permanece estacionado.
- **veiculos**: Lista de `string`, que armazena as placas dos veículos estacionados.

### Métodos da Classe
- **AdicionarVeiculo**: Recebe a placa do veículo e a adiciona à lista de veículos.
- **RemoverVeiculo**: Verifica se a placa informada está na lista de veículos. Se estiver, solicita a quantidade de horas que o veículo permaneceu e calcula o valor a ser cobrado.
- **ListarVeiculos**: Lista as placas de todos os veículos estacionados. Exibe uma mensagem caso não haja veículos.

## Como Usar
1. Clone este repositório em sua máquina local.
2. Abra o projeto em sua IDE de preferência.
3. Execute o programa e siga as instruções do menu interativo.

## Contato
Para mais informações, você pode me encontrar em [brandon.giron.flores@gmail.com](mailto:brandon.giron.flores@gmail.com).
