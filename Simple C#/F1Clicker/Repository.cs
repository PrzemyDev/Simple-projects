using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class Repository
    {
        private string _connectionString = "YOUR DATABASE CONNECTION STRING HERE";

        public bool UpdateSave(Save save)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    string insertQuery = @"UPDATE [Save] SET Points = @Points,
                    PointsPerClick = @PointsPerClick, PointsPerSecond = @PointsPerSecond, UpgrSuit = @UpgrSuit,
                    UpgrWheels = @UpgrWheels, UpgrSteeringWheel= @UpgrSteeringWheel, UpgrCommunications= @UpgrCommunications,
                    UpgrTools = @UpgrTools, UpgrTeammate = @UpgrTeammate";
                    db.Execute(insertQuery, new
                    {
                        save.Points,
                        save.PointsPerClick,
                        save.PointsPerSecond,
                        save.UpgrSuit,
                        save.UpgrWheels,
                        save.UpgrSteeringWheel,
                        save.UpgrCommunications,
                        save.UpgrTools,
                        save.UpgrTeammate
                    });
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            } 
        }
        public int GetPTS()
        {
            string sql = "SELECT Points FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<int>(sql).First();
                return myvalue;
            }
        }
        public int GetPPC()
        {
            string sql = "SELECT PointsPerClick FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<int>(sql).First();
                return myvalue;
            }
        }
        public int GetPPS()
        {
            string sql = "SELECT PointsPerSecond FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<int>(sql).First();
                return myvalue;
            }
        }

        public bool GetUpgradesSuit()
        {
            string sql = "SELECT UpgrSuit FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }   
        }
        public bool GetUpgradesWheels()
        {
            string sql = "SELECT UpgrWheels FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }
        }
        public bool GetUpgradesSteeringWheel()
        {
            string sql = "SELECT UpgrSteeringWheel FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }
        }
        public bool GetUpgradesCommunications()
        {
            string sql = "SELECT UpgrCommunications FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }
        }
        public bool GetUpgradesTools()
        {
            string sql = "SELECT UpgrTools FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }
        }
        public bool GetUpgradesTeammate()
        {
            string sql = "SELECT UpgrTeammate FROM [Save]";
            using (var connection = new SqlConnection(_connectionString))
            {
                var myvalue = connection.Query<bool>(sql).FirstOrDefault();
                return myvalue;
            }
        }
    }
}
