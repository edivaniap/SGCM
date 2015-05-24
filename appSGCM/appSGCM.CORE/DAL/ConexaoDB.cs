using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSGCM.CORE.Model
{
    public class ConexaoDB
    {
        private string connectionString =
                 @"Data Source=.\SQLExpress;Initial Catalog=DB_SGCM;User ID=sa;Password=123456";

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
        }
    }
}
