using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Config
{
    public class FuncionConfig
    {
        public FuncionConfig(EntityTypeBuilder<Funcion> FuncionBuilder)
        {
            FuncionBuilder.HasKey(x => x.FuncionId);

        }
    }
}
