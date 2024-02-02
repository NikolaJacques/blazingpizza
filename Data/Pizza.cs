﻿namespace BlazingPizza.Data
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan {  get; set; }
    }
}
