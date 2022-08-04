// Exercíco di site URI "Somando Inteiros Consecutivos"
// Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). 
// Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.
// Entrada
// A entrada contém somente valores inteiros, podendo ser positivos ou negativos. Todos os valores estão na mesma linha.
// Saída
// A saída contém apenas um valor inteiro.

int A, N, i, soma;

string[] valores = Console.ReadLine().Split(' ');

A = int.Parse(valores[0]);

i = 1;
N = int.Parse(valores[i]);
while (N <= 0)
{
    i = i + 1;
    N = int.Parse(valores[i]);
}

soma = 0;
for (i = 0; i < N; i++)
{
    soma = soma + A + i;
}

Console.WriteLine(soma);