﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392.OutfitBox.Domain.Entities
{
    public class Favourite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

    }
}
