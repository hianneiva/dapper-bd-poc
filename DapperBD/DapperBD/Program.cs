using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights;
using Dapper;
using DapperBD.CurrentModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DapperBD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            testJsonParsingFromBdContent();
            // UseDao();
            // UseDapper();
        }

        private static void testJsonParsingFromBdContent()
        {
            Dao<Freight> fDao = new Dao<Freight>("[dbo]", "Server=192.168.0.32; Database=teste; User Id=SA; Password=blive@123;");
            QueryFreightResponseRoot qfrObj = fDao.Select("C7D57806-3A29-4DAA-9FB0-0130CA0BD21D").Content;
            Console.WriteLine(qfrObj);
        }

        private static void UseDao()
        {
            Random rnd = new Random();

            // FREIGHTS
            Dao<Freight> freightDao = new Dao<Freight>("[dbo]", "Server=192.168.0.32; Database=teste; User Id=SA; Password=blive@123;");

            // INSERT
            Freight newFreight = new Freight()
            {
                ShipmentNumber = "ship_" + rnd.Next(1000, 9999).ToString(),
                Content = null
            };

            freightDao.Insert(newFreight);

            string id = newFreight.Id.ToString();

            // SELECT ALL
            Freight f = freightDao.SelectAll()[0];
            Console.WriteLine(f.ShipmentNumber);

            newFreight = new Freight()
            {
                ShipmentNumber = "ship_" + rnd.Next(1000, 9999).ToString(),
                Content = null
            };

            // UPDATE
            // freightDao.Update(newFreight, id);
            freightDao.Query($"UPDATE freight SET shipment_number='ship_WXYZ', payload='<xml><dummy>DUMMY</dummy></xml>', last_updated_at='2019-08-25'," +
                $" ready_at='2019-08-25' WHERE id_freights = '{id}'");

            // SELECT SINGLE
            f = freightDao.Select(id);
            Console.WriteLine(f.ShipmentNumber);

            // DELETE - TODO
            freightDao.Delete(id);

            f = freightDao.Select(id);
            Console.WriteLine(f == null);

            // DDC
            Dao<DteDocumentControl> ddCDao = new Dao<DteDocumentControl>("[dbo]", "Server=192.168.0.32; Database=teste; User Id=SA; Password=blive@123;");

            // INSERT
            DteDocumentControl ddc = new DteDocumentControl(Guid.NewGuid(), 0, 0);
            ddCDao.Insert(ddc);
            id = ddc.Id.ToString();

            // CUSTOM QUERY
            ddc = ddCDao.Query("SELECT * FROM document_submission_control")[0];
            Console.WriteLine(ddc.Order);

            // Update
            ddc.Order = 8000;
            ddCDao.Update(ddc, id);

            // SELECT
            ddc = ddCDao.Select(id);
            Console.WriteLine(ddc.Order);

            // DELETE
            ddCDao.Delete(id);
            ddc = null;
            foreach (DteDocumentControl tempDdc in ddCDao.SelectAll())
            {
                ddc = (tempDdc.Id.ToString() == id && ddc == null) ? tempDdc : null;
            }
            Console.WriteLine(ddc == null);
        }

        private static void UseDapper()
        {
            using (SqlConnection connection = new SqlConnection("Server=192.168.0.32; Database=teste; User Id=SA; Password=blive@123;"))
            {
                //"SELECT id_freights AS FreightsEventId, created_at AS CreationDateTime, shipment_number AS ShipmentNumber, NULL AS Action, payload AS Content FROM [teste].[dbo].[freight]";
                IList<string> attributes = new List<string>
            {
                "id_freights AS FreightsEventId",
                "created_at AS CreationDateTime",
                "shipment_number AS ShipmentNumber",
                "NULL AS Action",
                "payload AS Content"
            };
                string freightSelectQuery = SqlQueryBuilder.Select(attributes, "[teste].[dbo].[freight]", null);

                Freight f = connection.Query<Freight>(freightSelectQuery).AsList()[0];

                Console.WriteLine("Freight: " + f.Id + "\tCreation Date:" + f.CreationDateTime + "\nShipment No.: " + f.ShipmentNumber + "\nPayload:\n" + f.Content
                    + "\nAction: " + /*f.Action*/"");
            }
        }
    }
}
