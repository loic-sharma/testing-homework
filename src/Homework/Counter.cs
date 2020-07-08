using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    public class Counter
    {
        public int CountDistinctNames(IDatabase database)
        {
            // Load all names from a database.
            var names = database.GetNames();
            
            // Now count how many distinct names there are.
            return names.Distinct().Count();
        }
    }

    public interface IDatabase
    {
        List<string> GetNames();
    }
}
