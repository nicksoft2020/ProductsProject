using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Product.Repositories.SqlQueries
{
    /// <summary>
    /// Contents sql queries.
    /// </summary>
    public static class MSSQLQueries
    {
        public static string CreateProduct => @"
INSERT INTO Products (
ProductName, 
Category) 
VALUES(
@ProductName, 
@Category)";

        public static string GetAllProducts => @"
SELECT 
Id, 
ProductName, 
Category 
FROM Products";

        public static string GetAllCategories => @"
SELECT 
CategoryType 
FROM Categories";
    }
}
