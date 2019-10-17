using CinemaMRM.Domain;
using CinemaMRM.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaMRM.Services
{
    public static class CarteleraService
    {

        public static List<Cartelera> GetCartelera()
        {
            var Carteleras = ApiCartelera.Get<List<Cartelera>>("/api/Cartelera");

            return Carteleras;
        }
    }
}
