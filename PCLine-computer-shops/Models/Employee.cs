﻿using PCLine_computer_shops.Enums;

namespace PCLine_computer_shops.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Position { get; set; } 
        public decimal Salary { get; set; }
        public EmployeePosition EmployeePosition { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
