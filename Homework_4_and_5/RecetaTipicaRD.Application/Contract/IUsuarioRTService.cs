using System;
using RecetaTipicaRD.Application.Dtos.UsuarioRT;

namespace RecetaTipicaRD.Application.Contract
{
    public interface IUsuarioRTService
    {
        Task<List<UsuarioRTDto>> ObtenerTodos();
        Task<UsuarioRTDto?> ObtenerPorId(int id);
        Task Crear(UsuarioRTDto usuarioDto);
        Task Actualizar(UsuarioRTDto usuarioDto);
        Task Eliminar(int id);
    }
}
