using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class HouseProcessor

    {
        public static int CreateHouse(string address, string type, decimal price, string isAvailable)
        { 
        House data = new House
        {
            Address = address,
            Type = type,
            Price = price,
            IsAvailable = isAvailable
        };

        string sql = @"insert into dbo.House (Address, Type, Price, IsAvailable)
                            values (@Address, @Type, @Price, @IsAvailable);";

            return SqlDataAccess.SaveData(sql, data);
        }

    public static List<House> LoadHouses()
    {
        string sql = @"select Id, Address, Type, Price, IsAvailable
                        from dbo.House;";

        return SqlDataAccess.LoadData<House>(sql);
    }
}
}
