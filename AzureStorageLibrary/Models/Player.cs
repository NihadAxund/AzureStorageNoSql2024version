
using Azure;
using Azure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageLibrary.Models
{
    public class Player:ITableEntity
    {
        public Player() {
            
        }
        public Player(string? name, string? surname, string? birthDate, double salary, double score, string partitionKey)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Salary = salary;
            Score = score;
            PartitionKey = partitionKey;
            RowKey = Guid.NewGuid().ToString();
        }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? BirthDate { get; set; }
        public double Salary { get; set; }
        public double Score { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.MinValue;
        public ETag ETag { get; set; } = ETag.All;
    }
}
