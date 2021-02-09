using GraphQL;

namespace Function
{
    public class Mutation
    {
        [GraphQLMetadata("addJedi")]
        public Jedi AddJedi(Jedi input)
        {
            return StarWarsDB.AddJedi(input);
        }

        [GraphQLMetadata("updateJedi")]
        public Jedi UpdateJedi(Jedi input)
        {
            return StarWarsDB.AddJedi(input);
        }

        [GraphQLMetadata("removeJedi")]
        public string AddJedi(int id)
        {
            return StarWarsDB.RemoveJedi(id);
        }
    }
}