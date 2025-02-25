﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392.OutfitBox.Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } =string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phone{ get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;    
        public int Status { get; set; }
        public long MoneyInWallet { get; set; }

        public long OTP {  get; set; }
        public int RoldeId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; } 
        
        public List<UserPackage>? UserPackages { get; set; }

        public List<ReturnOrder>? ReturnOrders { get; set; } 

        public List<Wallet>? Wallets { get; set; }   
    }
}
