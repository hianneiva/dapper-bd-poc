using System;
using System.Collections.Generic;
using System.Text;

namespace DapperBD
{
    public static class SqlQueryBuilder
    {
        private static readonly string SELECT = "SELECT {0} FROM {1} ";
        private static readonly string UPDATE = "UPDATE {0} SET {1} ";
        private static readonly string INSERT = "INSERT INTO {0} ({1}) VALUES ({2}) ";
        private static readonly string DELETE = "DELETE FROM {0} ";
        private static readonly string WHERE = "WHERE {0}";

        public static string Select(string attributes, string table, string conditions)
        {
            string selectPart = string.Format(SELECT, attributes, table);
            string conditionPart = (conditions == null || conditions.Equals("")) ? "" : string.Format(WHERE, conditions);
            return selectPart + conditionPart;
        }

        public static string Select(IList<string> attributes, string table, IList<string> conditions)
        {
            StringBuilder attributeFlattener = new StringBuilder();
            int attributeCount = attributes.Count;

            for (int i = 0; i < attributeCount; i++)
            {
                attributeFlattener.Append(attributes[i]);
                if (i + 1 < attributeCount)
                {
                    attributeFlattener.Append(", ");
                }
            }

            StringBuilder conditionFlattener = new StringBuilder();
            int conditionCount = conditions == null ? 0 : conditions.Count;

            for (int i = 0; i < conditionCount; i++)
            {
                conditionFlattener.Append(conditions[i]);
                if (i + 1 < conditionCount)
                {
                    conditionFlattener.Append(", ");
                }
            }

            return Select(attributeFlattener.ToString(), table, conditionFlattener.ToString());
        }

        public static string SelectAll(string table, string conditions)
        {
            return Select("*", table, conditions);
        }

        public static string SelectAll(string table, IList<string> conditions)
        {
            StringBuilder conditionFlattener = new StringBuilder();
            int conditionCount = conditions.Count;

            for (int i = 0; i < conditionCount; i++)
            {
                conditionFlattener.Append(conditions[i]);
                if (i + 1 < conditionCount)
                {
                    conditionFlattener.Append(", ");
                }
            }

            return SelectAll(table, conditionFlattener.ToString());
        }

        public static string Update(string table, string values, string conditions)
        {
            if (conditions == null || conditions.Equals(""))
            {
                throw new Exception(string.Format("SQL Query: Cannot {0} without conditions.", UPDATE));
            }
            string updatePart = string.Format(UPDATE, table, values);
            string conditionPart = string.Format(WHERE, conditions);
            return updatePart + conditionPart;
        }

        public static string Update(IList<string> values, string table, IList<string> conditions)
        {
            if (conditions == null || conditions.Count == 0)
            {
                throw new Exception(string.Format("SQL Query: Cannot {0} without conditions.", UPDATE));
            }
            StringBuilder valueFlattener = new StringBuilder();
            int valueCount = values.Count;

            for (int i = 0; i < valueCount; i++)
            {
                valueFlattener.Append(values[i]);
                if (i + 1 < valueCount)
                {
                    valueFlattener.Append(", ");
                }
            }

            StringBuilder conditionFlattener = new StringBuilder();
            int conditionCount = conditions.Count;

            for (int i = 0; i < conditionCount; i++)
            {
                conditionFlattener.Append(conditions[i]);
                if (i + 1 < conditionCount)
                {
                    conditionFlattener.Append(", ");
                }
            }

            return Update(valueFlattener.ToString(), table, conditionFlattener.ToString());
        }

        public static string Delete(string table, string conditions)
        {
            if (conditions == null || conditions.Equals(""))
            {
                throw new Exception(string.Format("SQL Query: Cannot {0} without conditions.", DELETE));
            }
            string deletePart = string.Format(DELETE, table);
            string conditionPart = string.Format(WHERE, conditions);
            return deletePart + conditionPart;
        }

        public static string Delete(string table, IList<string> conditions)
        {
            if (conditions == null || conditions.Count == 0)
            {
                throw new Exception(string.Format("SQL Query: Cannot {0} without conditions.", DELETE));
            }
            StringBuilder conditionFlattener = new StringBuilder();
            int conditionCount = conditions.Count;

            for (int i = 0; i < conditionCount; i++)
            {
                conditionFlattener.Append(conditions[i]);
                if (i + 1 < conditionCount)
                {
                    conditionFlattener.Append(", ");
                }
            }

            return Delete(table, conditionFlattener.ToString());
        }

        public static string Insert(string table, string columns, string values)
        {
            string invalidQuery = null;

            if (columns == null || columns.Equals(""))
            {
                invalidQuery = string.Format("SQL Query: Cannot {0} without any specified column.", INSERT);
            }

            if (values == null || values.Equals(""))
            {
                invalidQuery = string.Format("SQL Query: Cannot {0} without any specified values.", INSERT);
            }

            if (invalidQuery != null)
            {
                throw new Exception(invalidQuery);
            }

            return string.Format(INSERT, table, columns, values);
        }

        public static string Insert(string table, IList<string> columns, IList<string> values)
        {
            string invalidQuery = null;

            if (columns == null || columns.Count == 0)
            {
                invalidQuery = string.Format("SQL Query: Cannot {0} without any specified column.", INSERT);
            }

            if (values == null || values.Count == 0)
            {
                invalidQuery = string.Format("SQL Query: Cannot {0} without any specified values.", INSERT);
            }

            if (invalidQuery != null)
            {
                throw new Exception(invalidQuery);
            }

            StringBuilder valueFlattener = new StringBuilder();
            int valueCount = values.Count;

            for (int i = 0; i < valueCount; i++)
            {
                valueFlattener.Append(values[i]);
                if (i + 1 < valueCount)
                {
                    valueFlattener.Append(", ");
                }
            }

            StringBuilder columnsFlattener = new StringBuilder();
            int conditionCount = columns.Count;

            for (int i = 0; i < conditionCount; i++)
            {
                columnsFlattener.Append(columns[i]);
                if (i + 1 < conditionCount)
                {
                    columnsFlattener.Append(", ");
                }
            }

            return Update(valueFlattener.ToString(), table, columnsFlattener.ToString());
        }
    }
}
