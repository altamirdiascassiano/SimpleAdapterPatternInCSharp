namespace SimpleSingletonAdapterInCSharp
{
    class MySqlComandsAdapter : IDataBaseComands
    {
        private MySqlComands db = null;
        public MySqlComandsAdapter()
        {
            db = new MySqlComands();
        }
        public string Delete()
        {
            return db.DeleteMySql();
        }

        public string Insert()
        {
            return db.InsertMySql();
        }

        public string Update()
        {
            return db.UpdateMySql();
        }
    }
}
