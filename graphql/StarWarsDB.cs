using System.Collections.Generic;
using System.Linq;

namespace Function
{
    public class StarWarsDB
    {
        private static List<Jedi> jedis = new List<Jedi>() {
      new Jedi(){ Id = 1, Name ="Luke", Side="Light"},
      new Jedi(){ Id = 2, Name ="Yoda", Side="Light"},
      new Jedi(){ Id = 3, Name ="Darth Vader", Side="Dark"}
    };
        public static IEnumerable<Jedi> GetJedis()
        {
            return jedis;
        }

        public static Jedi AddJedi(Jedi jedi)
        {
            jedi.Id = jedis.Count + 1;
            jedis.Add(jedi);
            return jedi;
        }

        public static Jedi UpdateJedi(Jedi jedi)
        {
            var toUpdate = jedis.SingleOrDefault(j => j.Id == jedi.Id);
            toUpdate.Name = jedi.Name;
            toUpdate.Side = jedi.Side;
            return toUpdate;
        }

        public static string RemoveJedi(int id)
        {
            var toRemove = jedis.SingleOrDefault(j => j.Id == id);
            jedis.Remove(toRemove);
            return "success";
        }
    }

    public class Jedi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Side { get; set; }
    }
}