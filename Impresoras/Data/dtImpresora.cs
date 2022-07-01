﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresoras.Data
{
    class dtImpresora
    {
        int idInventarioEquipo;
        string numeroEquipo;
        string nombreEquipo;
        string serieEquipo;
        string marcaEquipo;
        string modeloEquipo;
        bool estadoEquipo;
        string fechaAlta;
        string obsEquipo;
        byte[] imgQr;

        public int IdInventarioEquipo
        {
            get
            {
                return idInventarioEquipo;
            }

            set
            {
                idInventarioEquipo = value;
            }
        }


        public string NumeroEquipo
        {
            get
            {
                return numeroEquipo;
            }

            set
            {
                numeroEquipo = value;
            }
        }

        public string NombreEquipo
        {
            get
            {
                return nombreEquipo;
            }

            set
            {
                nombreEquipo = value;
            }
        }

        public string SerieEquipo
        {
            get
            {
                return serieEquipo;
            }

            set
            {
                serieEquipo = value;
            }
        }

        public string MarcaEquipo
        {
            get
            {
                return marcaEquipo;
            }

            set
            {
                marcaEquipo = value;
            }
        }

        public string ModeloEquipo
        {
            get
            {
                return modeloEquipo;
            }

            set
            {
                modeloEquipo = value;
            }
        }

        public bool EstadoEquipo
        {
            get
            {
                return estadoEquipo;
            }

            set
            {
                estadoEquipo = value;
            }
        }

        public string FechaAlta
        {
            get
            {
                return fechaAlta;
            }

            set
            {
                fechaAlta = value;
            }
        }

        public string ObsEquipo
        {
            get
            {
                return obsEquipo;
            }

            set
            {
                obsEquipo = value;
            }
        }
    }
}
