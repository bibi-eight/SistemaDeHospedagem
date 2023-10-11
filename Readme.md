# Desafio DIO - Construindo um Sistema de Hospedagem de um Hotel no C#

OLá, seja bem vindo ao meu sistema de hospedagem, esse projeto é um desafio da DIO -> Digital Inovation One no Bootcamp WEX - Desenvolvimento .NET e QA


## Contexto
Neste desafio foi proposto construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos. Seu programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
</br>
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá 
retornar o valor da diária (Dias reservados x valor da diária).
</br>
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.