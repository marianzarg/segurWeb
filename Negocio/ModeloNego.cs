﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ModeloNego
    {
        ModeloRepo modeloRepo = new ModeloRepo();

        public List<Modelos> CargarComboModelo(int marcaId)
        {
            return modeloRepo.CargarComboModelo(marcaId);
        }

        public Modelos BuscarModelo(int? modeloId)
        {
            return modeloRepo.BuscarModelo(modeloId);
        }
    }
}
