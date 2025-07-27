using RecetaTipicaRD.Domain.Entities;
using RecetaTipicaRD.Infrastructure.Context;
using RecetaTipicaRD.Infrastructure.Core;
using RecetaTipicaRD.Infrastructure.Interfaces;

namespace RecetaTipicaRD.Infrastructure.Repositories
{
    public class UsuarioDeportivoRepository : BaseRepository<UsuarioRT>, IUsuarioRTRepository
    {
        public UsuarioDeportivoRepository(RecetaTipicaRDContext context)
            : base(context)
        {
        }
    }
}
