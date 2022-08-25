using System;
using Whitely.Domain.Enum;

namespace Whitely.Domain.Models
{
    public class RealProperty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Categories Type { get; set; }
        public decimal? RentPrice { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal Area { get; set; }
        public DateTime DateAdded { get; set; }
    }
}