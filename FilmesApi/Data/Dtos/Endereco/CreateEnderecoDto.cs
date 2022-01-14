﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {

        [Required(ErrorMessage = "O campo logradouro é obrigatório.")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo numero é obrigatório.")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo bairro é obrigatório")]
        public string Bairro { get; set; }
    }
}
