using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Config
{
    public class SalaConfig
    {
        EntityTypeBuilder<Sala> SalaBuilder;
        public SalaConfig(EntityTypeBuilder<Sala> _SalaBuilder)
        {
            SalaBuilder = _SalaBuilder;
            SalaBuilder.HasKey(x => x.SalaId);

            CreadorSalas.creadorSalas(SalaBuilder, 1, 5);
            CreadorSalas.creadorSalas(SalaBuilder, 2, 15);
            CreadorSalas.creadorSalas(SalaBuilder, 3, 35);
        }
    }
    public class CreadorSalas
    {
        public static void creadorSalas(EntityTypeBuilder<Sala> SalaBuilder, int xSalaId, int xCapacidad)
        {
            SalaBuilder.HasData(new Sala
            {
                SalaId = xSalaId,
                Capacidad = xCapacidad

            });

        }
    }
}
