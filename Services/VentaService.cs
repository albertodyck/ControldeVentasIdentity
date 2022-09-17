using ControldeVentasIdentity.Data;
using Microsoft.EntityFrameworkCore;

namespace ControldeVentasIdentity.Services
{
    public class VentaService : IVentaService
    {
        private readonly ApplicationDbContext _context;

        public VentaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteVenta(int ventaId)
        {
            var venta = await _context.Ventas.FindAsync(ventaId);

            _context.Ventas.Remove(venta);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Venta>> GetAllVenta()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<Venta> GetVentaDetails(int ventaId)
        {
            return await _context.Ventas.FindAsync(ventaId);
        }

        public async Task<bool> InsertarVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveVenta(Venta venta)
        {
            //servicio decide cuando llamar insert o update, nosotros solo usaremos SaveVenta, los dos no se usaran desde afuera

            if (venta.Id > 0)
            {
                //la venta existe
                return await UpdateVenta(venta);
            }
            else
            {
                //es nuevo no existe
                return await InsertarVenta(venta);
            }
        }

        public async Task<bool> UpdateVenta(Venta venta)
        {
            _context.Entry(venta).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
