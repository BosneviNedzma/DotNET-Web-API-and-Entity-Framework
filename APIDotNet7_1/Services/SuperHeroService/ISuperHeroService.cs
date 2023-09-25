namespace APIDotNet7_1.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAllHeroes();
        Task<SuperHero?> GetSingleHero(int id);
        Task<List<SuperHero>>AddHero(SuperHero hero);
        Task<SuperHero?> UpdateHero(int id, SuperHero request);
        Task<List<SuperHero>?> DeleteHero(int id);
    }
}
