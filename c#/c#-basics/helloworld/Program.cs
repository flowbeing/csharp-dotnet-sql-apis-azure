// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, World!!");

using Microsoft.Data.SqlClient; // to create a database connection to Azure Data Studio
using Dapper; // to run queries on after an database connection has been setup with Azure Data Studio

using HelloWorld.Models;
using HelloWorld.Data;
using System.Data;

namespace HelloWorld
{

    // class types: public class, private class, internal class
    internal class Program
    {

        public static void Main(string[] args)
        {

            // an instance of Computer
            Computer computerOne = new Computer()
            {

                MotherBoard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 943.87m,
                VideoCard = "RTX 2060"
            };

            Computer computerTwo = new Computer();

            computerTwo.getProperties();

            // an instance of DataContextDapper
            // DataContextDapper dapper = new DataContextDapper();
            DataContextEF entityFramework = new DataContextEF();


            // Console.WriteLine(sqlConnection.ConnectionString);

            // sqlConnection.Query("USE master");
            string querySingleSelect = "SELECT GETDATE()";

            string queryMultiple = @"
            USE DotNetCourseDatabase;
            SELECT 
                Computer.ComputerId, 
                Computer.MotherBoard,
                Computer.HasWifi, 
                Computer.HasLTE, 
                Computer.ReleaseDate, 
                Computer.Price, 
                Computer.VideoCard
            FROM SchemaOne.Computer";

            string insertValuesString = @"
            USE DotNetCourseDatabase;

            INSERT INTO SchemaOne.Computer (
                Computer.MotherBoard,
                Computer.HasWifi, 
                Computer.HasLTE, 
                Computer.ReleaseDate, 
                Computer.Price, 
                Computer.VideoCard)
            VALUES ('" +
                computerOne.MotherBoard + "','" +
                computerOne.HasWifi + "','" +
                computerOne.HasLTE + "','" +
                computerOne.ReleaseDate + "','" +
                computerOne.Price + "','" +
                computerOne.VideoCard + "'" +
            ");";


            // DAPPER CODES
            // Adding rows to database using dapper methods
            // Console.WriteLine($"At least a row was affected: {dapper.ExecuteSql(insertValuesString)}");
            // Console.WriteLine($"number of rows affected: {dapper.ExecuteWithRowCount(insertValuesString)}");


            // var querySingleResult = dapper.LoadDataSingle<string>(querySingleSelect);
            // IEnumerable<Computer> queryMultipleResult = dapper.LoadData<Computer>(queryMultiple); // query multiple always returns an IEnumerable..

            // Console.WriteLine(querySingleResult.ToString());
            // // 
            // Console.WriteLine();
            // foreach (var result in queryMultipleResult)
            // {
            //     Console.WriteLine(result);
            // }


            // ENTITY FRAMEWORK CODE
            // adding row to database using entity framework
            // entityFramework.Add(computerOne);
            // entityFramework.SaveChanges();

            // retrieving rows from database using entity framework
            IEnumerable<Computer>? entityFrameworkIEmunerable = entityFramework.Computer?.ToList<Computer>();

            if (entityFrameworkIEmunerable != null)
            {
                foreach (var data in entityFrameworkIEmunerable)
                {
                    Console.WriteLine("ComputerId, MotherBoard, HasWifi, HasLTE, ReleaseDate, Price, VideoCard");
                    Console.WriteLine($"{data.ComputerId}, {data.MotherBoard}, {data.HasWifi}, {data.HasLTE}, {data.ReleaseDate}, {data.Price}, {data.VideoCard}");
                }
            }




            // Console.WriteLine(computerOne.MotherBoard);
            // Console.WriteLine(computerOne.HasWifi);
            // Console.WriteLine(computerOne.HasLTE);
            // Console.WriteLine(computerOne.ReleaseDate);
            // Console.WriteLine(computerOne.Price);
            // Console.WriteLine(computerOne.VideoCard);
        }
    }
}