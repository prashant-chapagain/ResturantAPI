﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantAPI.Models;

public class FoodItem

{
    [Key]
    public int FoodItemId { get; set; }


    [Column(TypeName = "nvarchar(50)")]
    public string FoodItemName { get; set; }
    public decimal Price { get; set; } 
}
