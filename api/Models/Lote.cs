﻿namespace api.Models;

public class Lote
{
    [Column("id")]
    public required int IdLote { get; set; }

    [Column("evento_id")]
    public required int EventoId { get; set; }

    [Column("valor_unitario")]
    public required double ValorUnitario { get; set; }

    [Column("quantidade_total")]
    public required int QuantidadeTotal { get; set; }

    [Column("saldo")]
    public required int Saldo { get; set; }

    [Column("ativo")]
    public required int Ativo { get; set; }

    [Column("data_inicio")]
    public required DateTime DataInicio { get; set; }

    [Column("data_final")]
    public required DateTime DataFinal { get; set; }

}