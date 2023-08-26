# Teste de Performance 2
## Exercício #5

Olá! Neste segundo teste de performance, você deverá criar um programa semelhante a um sistema de pedido, que mostre um menu principal para realizar um pedido em uma loja (tema da loja de escolha do aluno).

Veja abaixo, no caso de uma hamburgueria, como os menus e submenus de opções são apresentados.

O programa deverá apresentar as seguintes opções no menu principal: Selecione uma opção:

1. Adicionar um item ao pedido.
2. Mostrar os itens e o valor total a pagar.
3. Sair do programa.

Quando o usuário selecionar a opção 1, o programa deverá apresentar algo como: Selecione uma opção:

1. Adicionar Hambúrguer (R$30,00)
2. Adicionar Batata Frita (R$12,00)
3. Adicionar Refrigerante (R$8,00)

Requisitos:

1. A sua loja deve oferecer somente três tipos de produto;
2. Após adicionar um produto, o programa deverá voltar ao menu principal;
3. O programa deverá exibir um item de menu para sair do programa;
4. No cenário de total a pagar acima de cem reais (R$100,00), deve ser calculado um desconto de 10%;
5. Quando o usuário selecionar a opção para sair do programa, exiba uma mensagem de encerramento do programa.

Exercícios:

1. Crie uma classe para representar o pedido;
2. Implemente no construtor uma regra para gerar o número do pedido (aleatoriamente);
3. Crie três constantes dentro da sua classe (item 1) para armazenar os valores unitários de cada produto (será um valor padrão que não muda);
4. Crie propriedades para armazenar a quantidade de cada um dos três produtos. Defina os set das propriedades como private;
5. Crie três métodos para Incrementar a quantidade de cada produto;
6. Crie um método para calcular o total do pedido considerando o desconto;
7. No programa principal instancie um objeto referente a classe criada (item 1);
8. No programa principal implemente uma estrutura de repetição para apresentar os menus sugeridos do enunciado;
9. No programa principal execute os métodos do objeto (item 7) instanciado;
10. No programa principal apresente as mensagens de acordo com os requisitos e enunciados;