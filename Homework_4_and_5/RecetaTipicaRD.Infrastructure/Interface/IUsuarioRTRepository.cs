using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetaTipicaRD.Domain.Entities;

namespace RecetaTipicaRD.Infrastructure.Interfaces
{
    public interface IUsuarioRTRepository
    {
        Task<List<UsuarioRT>> ObtenerTodosAsync();
        Task<UsuarioRT?> ObtenerPorIdAsync(int id);
        Task AgregarAsync(UsuarioRT usuario);
        Task ActualizarAsync(UsuarioRT usuario);
        Task EliminarAsync(UsuarioRT usuario);
    }
}
