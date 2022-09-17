using ControldeVentasIdentity.Data;

namespace ControldeVentasIdentity.Services
{
    interface IVentaService
    {
        Task<IEnumerable<Venta>> GetAllVenta();

        Task<Venta> GetVentaDetails(int ventaId);

        Task<bool> InsertarVenta(Venta venta);

        Task<bool> UpdateVenta(Venta venta);

        Task<bool> DeleteVenta(int ventaId);

        Task<bool> SaveVenta(Venta venta);
    }
}
