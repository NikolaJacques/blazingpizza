
namespace BlazingPizza.Services
{
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAscync()
        {
            return await Task.Run(() => new Pizza[0]);
        }
    }
}
