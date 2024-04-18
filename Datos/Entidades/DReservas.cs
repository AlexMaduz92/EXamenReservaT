using Datos.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class DReservas
{
    [Key]
    public int ReservaId { get; set; }

    [Required]
    [Column(TypeName = "date")]
    public DateTime FechaReserva { get; set; }

    [Required]
    public int TeatroId { get; set; }

    [Required]
    public int ClienteId { get; set; }

    [Required]
    public int AsientoN { get; set; }

    [ForeignKey("TeatroId")]
    public DTeatro Teatro { get; set; }

    [ForeignKey("ClienteId")]
    public DCliente Cliente { get; set; }
}