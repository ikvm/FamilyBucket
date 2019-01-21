﻿namespace Bucket.DbContext
{
    public class DbConnectOption
    {
        public string Name { set; get; }
        public string ConnectionString { set; get; }
        public SqlSugar.DbType DbType { set; get; }
        public bool IsAutoCloseConnection { set; get; }
    }
}
