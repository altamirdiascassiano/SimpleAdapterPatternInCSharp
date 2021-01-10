using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSingletonAdapterInCSharp
{
    public class OracleComandsAdapter : IDataBaseComands
    {
        private OracleComands db= null;
        public OracleComandsAdapter()
        {
            db = new OracleComands();
        }
        public string Delete()
        {
            return db.DeleteOracle();
        }

        public string Insert()
        {
            return db.InsertOracle();
        }

        public string Update()
        {
            return db.UpdateOracle();
        }

    }
}
