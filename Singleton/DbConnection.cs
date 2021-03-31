namespace Singleton
{
	class DbConnection
	{
        // Статическая переменная - ссылка на конкретный экземпляр объекта
        private static DbConnection Connection;

        public string Configuration { get; private set; }

        // Приватный конструктор
        protected DbConnection(string configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
        /// </summary>
        public static DbConnection GetConnectionInstance(string dbServer)
        {
            if (Connection == null)
                Connection = new DbConnection(dbServer);
            return Connection;
        }
    }
}
