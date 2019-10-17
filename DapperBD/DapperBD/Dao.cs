using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace DapperBD
{
    public class Dao<T>
    {
        public string ConnectionString { get; protected set; }
        public string Schema { get; protected set; }
        public Dao(string schema = "", string connectionString = "")
        {
            Schema = schema;
            ConnectionString = connectionString?.Length > 0 ? connectionString : ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }

        public T Select(string id)
        {
            Type type = typeof(T);
            OrmAttribute orm = type.GetCustomAttribute<OrmAttribute>();
            string query = $"SELECT * FROM {GetTableName(ref orm)} WHERE {orm.IdName} = '{id}'";

            T result = default;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = ConvertToObject(reader, orm);

                        }

                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }

            return result;
        }

        public IList<T> SelectAll()
        {
            IList<T> result = new List<T>();
            OrmAttribute orm = new OrmAttribute();

            string query = $"SELECT * FROM {GetTableName(ref orm)}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = ConvertToObject(reader, orm);
                            result.Add(entity);
                        }

                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }

            return result;
        }

        public void Insert(T genericObject)
        {
            string columns = BuildInsertColumns(out Type type);
            string values = BuildInsertValues(genericObject, type);
            OrmAttribute orm = type.GetCustomAttribute<OrmAttribute>();
            string query = $"INSERT INTO {GetTableName(ref orm)} ({ columns }) VALUES ({ values })";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }
        }

        public void Update(T genericObject, string id, string query = "")
        {
            if (query?.Length <= 0 || query == null)
            {
                string updateParameters = BuildUpdateParameters(genericObject, out Type type);
                OrmAttribute orm = type.GetCustomAttribute<OrmAttribute>();
                query = $"UPDATE {GetTableName(ref orm)} SET { updateParameters } WHERE { orm.IdName } = { ConvertInputToSqlQuery(id) }";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }
        }

        public void Delete(string id)
        {
            OrmAttribute orm = new OrmAttribute();
            string query = $"DELETE {GetTableName(ref orm)} WHERE { orm.IdName } = { ConvertInputToSqlQuery(id) }";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }
        }

        public List<T> Query(string query)
        {
            List<T> result = new List<T>();
            OrmAttribute orm = typeof(T).GetCustomAttribute<OrmAttribute>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Debug.WriteLine(query);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = ConvertToObject(reader, orm);
                            if (entity != null)
                            {
                                result.Add(entity);
                            }
                        }

                        reader.Close();
                    }
                }

                finally
                {
                    connection?.Close();
                }
            }

            return result;
        }

        protected virtual string GetTableName(ref OrmAttribute ormAttribute)
        {
            Type type = typeof(T);
            OrmAttribute orm = type.GetCustomAttribute<OrmAttribute>();
            string table = orm != null ? orm.Name : typeof(T).Name.ToLower();

            string schemaTable = Schema?.Length > 0 ? $"{Schema}.{table}" : table;
            ormAttribute = orm;
            return schemaTable;
        }

        protected virtual T ConvertToObject(SqlDataReader dataReader, OrmAttribute orm)
        {
            Type type = typeof(T);
            T entity = (T)Activator.CreateInstance(type);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetCustomAttribute<OrmAttribute>().Ignore)
                {
                    continue;
                }

                object value;

                if (property.Name == "Id")
                {
                    value = ConvertValue(dataReader, property, orm.IdName);
                }
                else
                {
                    value = ConvertValue(dataReader, property, null);
                }

                SetValue(property, entity, value);

            }

            return entity;
        }

        protected virtual object ConvertValue(SqlDataReader dataReader, PropertyInfo property, string entityIdName)
        {
            OrmAttribute orm = property.GetCustomAttribute<OrmAttribute>();
            string columnName = (entityIdName == null && orm != null) ? orm.Name.ToLower() : property.Name.ToLower(); ;

            object rawValue = entityIdName == null ? dataReader[columnName] : dataReader[entityIdName.ToLower()];
            object value;
            Type valueType = property.PropertyType;

            if (valueType == typeof(Guid))
            {
                value = ConvertToGuid(rawValue);
            }
            else if (valueType.IsEnum)
            {
                value = Convert.ChangeType(Enum.ToObject(property.PropertyType, rawValue), property.PropertyType);
            }
            else if (valueType == typeof(QueryFreightResponseRoot))
            {
                value = Parser<QueryFreightResponseRoot>.FromJson((string)rawValue);
            }
            else
            {
                value = Convert.ChangeType(rawValue, property.PropertyType);
            };
            return value;
        }

        protected virtual Guid ConvertToGuid(object rawValue)
        {
            return (Guid)rawValue;
        }

        protected virtual void SetValue(PropertyInfo property, T entity, object value)
        {
            if (value != null)
            {
                property.SetValue(entity, value);
            }
        }

        protected virtual string BuildInsertColumns(out Type externalType)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            List<string> propertyNames = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                OrmAttribute propertyAttributes = property.GetCustomAttribute<OrmAttribute>();
                string propertyName;

                if (propertyAttributes.Ignore == true)
                {
                    continue;
                }
                else if (propertyAttributes.Name == null)
                {
                    propertyName = type.GetCustomAttribute<OrmAttribute>().IdName.ToLower();
                }
                else
                {
                    propertyName = propertyAttributes.Name.ToLower();
                }

                propertyNames.Add(propertyName);
            }

            StringBuilder insertColumnsListBuilder = new StringBuilder();

            for (int i = 0; i < propertyNames.Count; i++)
            {
                insertColumnsListBuilder.Append(propertyNames[i]);

                if ((i + 1) < propertyNames.Count)
                {
                    insertColumnsListBuilder.Append(", ");
                }
            }

            externalType = type;
            return insertColumnsListBuilder.ToString();
        }

        protected virtual string BuildInsertValues(T genericObject, Type tType)
        {
            Type type = tType;
            PropertyInfo[] properties = type.GetProperties();
            List<string> valuesList = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                bool propertyIsIgnored = property.GetCustomAttribute<OrmAttribute>().Ignore;

                if (propertyIsIgnored == true)
                {
                    continue;
                }
                object value = property.GetValue(genericObject);
                valuesList.Add(ConvertInputToSqlQuery(value));
            }

            StringBuilder updateParameterBuilder = new StringBuilder();

            for (int i = 0; i < valuesList.Count; i++)
            {
                updateParameterBuilder.Append(valuesList[i]);

                if ((i + 1) < valuesList.Count)
                {
                    updateParameterBuilder.Append(", ");
                }
            }

            return updateParameterBuilder.ToString();
        }

        protected virtual string BuildUpdateParameters(T genericObject, out Type externalType)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            List<Tuple<string, string>> propertyValuePair = new List<Tuple<string, string>>();

            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.GetCustomAttribute<OrmAttribute>().Name;

                if (propertyName == null || property.Name == "Id" || property.Name == "CreationDateTime")
                {
                    continue;
                }

                object value = property.GetValue(genericObject);
                propertyValuePair.Add(new Tuple<string, string>(propertyName.ToLower(), ConvertInputToSqlQuery(value)));
            }

            StringBuilder updateParameterBuilder = new StringBuilder();

            for (int i = 0; i < propertyValuePair.Count; i++)
            {
                Tuple<string, string> entry = propertyValuePair[i];
                updateParameterBuilder.Append(entry.Item1).Append(" = ").Append(entry.Item2);

                if ((i + 1) < propertyValuePair.Count)
                {
                    updateParameterBuilder.Append(", ");
                }
            }

            externalType = type;
            return updateParameterBuilder.ToString();
        }

        protected virtual string ConvertInputToSqlQuery(object obj)
        {
            string converted;

            if ((obj is string) || (obj is Guid))
            {
                converted = $"'{obj.ToString()}'";
            }
            else if (obj is DateTime)
            {
                DateTime date = (DateTime)obj;
                converted = $"'{date.ToString("yyyy-MM-dd HH:mm:ss.fff")}'";
            }
            else if (obj is Enum)
            {
                converted = ((int)obj).ToString();
            }
            else
            {
                converted = obj.ToString();
            }

            return converted;
        }
    }
}

