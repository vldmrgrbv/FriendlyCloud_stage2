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
        [StringLength(10)]
        public string NumberRoom { get; set; }

        public DirectoryTypeRooms DirectoryTypeRooms { get; set; }
        public DirectoryCategoryRooms DirectoryCategoryRooms { get; set; }
    }
}
