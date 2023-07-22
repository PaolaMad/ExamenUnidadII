using ExamenUnidadII.Models;

namespace ExamenUnidadII.Services
{
    public interface IServiceEmail
    {
        Task Send(Test model);
    }
}