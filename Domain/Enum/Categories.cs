using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Whitely.Domain.Enum
{
    public enum Categories
    {
        [Display(Name = "Warehouse")]
        Warehouse = 1,
        [Display(Name = "Office")]
        Office = 2,
        [Display(Name = "Car Wash")]
        CarWash = 3,
        [Display(Name = "Garage")]
        Garage = 4,
        [Display(Name = "Area")]
        Area
    }
}