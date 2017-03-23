# MarsRoverCSharpConsole

Esse arquivo tem como intuito ajudar àqueles que irão utilizar-se do MarsRoverCSharpConsole, constitui-se de instruções para melhor uso do mesmo.

É um programa que faz movimentação de um Rover num grid de tamanho definido pelo usuário, além disso retorna qual a posição final e orientação do robô.

Tem como **ENTRADA** um conjunto de três linhas: 

X Y

X Y Dir

Lista de instruções


* A primeira linha representa as coordenadas do canto superior direito do plano, ou seja, as coordenadas máximas do plano (dois inteiros separados por espaço). O qual tem como coordenadas do canto inferior esquerdo 0,0, por padrão.
* A segunda linha representa a posição atual do Rover,isto é, suas coordenadas (dois inteiros separados por espaço) e a direção para a qual aponta (também separada por espaço).
* A terceira linha é o conjunto de instruções que indicam como o Rover deve se movimentar explorando o plano.

Obs.: cada Rover termina de forma sequencial, ou seja, um segundo rover não começa a se mover enquanto o primeiro ainda não tiver acabado de se movimentar.
      
Tem como **SAÍDA**: sua coordenada final e a direção para qual aponta.

***Exemplo de entradas e saídas:***

5 5 

1 2 N 

LMLMLMLMM 

3 3 E 

MMRMMRMRRM 
 
***Saída esperada:***

1 3 N 

5 1 E 
 
