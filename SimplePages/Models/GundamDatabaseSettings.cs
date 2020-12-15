using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePages.Models
{
    public class GundamDatabaseSettings : IGundamDatabaseSettings
    {
        public string GundamsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IGundamDatabaseSettings
    {
        string GundamsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}
