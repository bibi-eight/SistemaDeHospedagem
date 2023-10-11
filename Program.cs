﻿using System.Text;
using SistemaDeHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Hospede> hospedes = new List<Hospede>();

Hospede p1 = new Hospede(nome: "Hóspede 1");
Hospede p2 = new Hospede(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Executiva", capacidade: 2, valorDiaria: 40);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

