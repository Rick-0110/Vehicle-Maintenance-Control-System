using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeControleVeiculos.Models

{
    public class VeiculosModel
    {
public int Id { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Range(1900, 2099)]
        public int Ano { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Quilometragem { get; set; }

    }
}