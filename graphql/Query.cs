using System.Collections.Generic;
using GraphQL;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Function
{
    public class Result<T>
    {
        public int count { get; set; }
        public T results { get; set; }
    }

    public class Planet
    {
        public string name { get; set; }
    }

    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().SingleOrDefault(j => j.Id == id);
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "World";
        }


        // 
        // Custom external data source from URI instead of DB
        //
        [GraphQLMetadata("planets")]
        public async Task<List<Planet>> GetPlanet()
        {
            var planets = await Fetch.ByUrl("planets/");
            var result = JsonConvert.DeserializeObject<Result<List<Planet>>>(planets);
            return result.results;
        }
    }

}