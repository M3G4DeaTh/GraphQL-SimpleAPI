namespace FuelManagerGraphQL.Models
{
    public class Mutation
    {
        public async Task<Veiculo> AddVeiculo([Service] AppDbContext _context, Veiculo model)
        {
            _context.Veiculos.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<Veiculo> UpdateVeiculo([Service] AppDbContext _context, Veiculo model)
        {
            _context.Veiculos.Update(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<Veiculo> DeleteVeiculo([Service] AppDbContext _context, int id)
        {
            var model = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(model);
            await _context.SaveChangesAsync();

            return model;
        }
    }
}