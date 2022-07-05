using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Config
{
    public class TicketConfig
    {
        public TicketConfig(EntityTypeBuilder<Ticket> EntityBuilder)
        {
            EntityBuilder.HasKey(x => new { x.TicketId, x.FuncionId });
            EntityBuilder.Property(x => x.Usuario).HasMaxLength(50).IsRequired();
        }
    }
}
