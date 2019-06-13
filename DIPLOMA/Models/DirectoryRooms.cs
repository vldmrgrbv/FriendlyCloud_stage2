using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPLOMA.Models
{
    public class DirectoryRooms
    {
        public int DirectoryRoomsID { get; set; }
        [Required]
        public int DirectoryCategoryRoomsID { get; set; }
        [Required]
        public int DirectoryTypeRoomsID { get; set; }
        [Required]
        public int DirectoryStatusRoomsID { get; set; }
        [Required]
        public bool Repairs { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal CostPerDay { get; set; }
        [Required]
        [StringLength(10)]
        public string NumberRoom { get; set; }

        public DirectoryTypeRooms DirectoryTypeRooms { get; set; }
        public DirectoryCategoryRooms DirectoryCategoryRooms { get; set; }
        public DirectoryStatusRooms DirectoryStatusRooms { get; set; }
    }
}
