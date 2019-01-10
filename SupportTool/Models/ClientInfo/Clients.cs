using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SupportTool.Models.ClientInfo
{
    public class Clients
    {
        // primaryKey
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [MaxLength(4)]
        public string ClientID { get; set; }

        [Required]
        public string ClientName { get; set; }

        public string ClientAcronym { get; set; }

        public string ClientVersion { get; set; }

        // 1 = hosted, 0 = premise
        [Required]
        public bool Hosted { get; set; }

        // 1 = has Pgo, 0 = does not have Pgo
        [Required]
        public bool PGo { get; set; }
    }

    public class ClientsDbContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<ClientDetails> ClientDetails { get; set; }

        public ClientsDbContext()
            : base("name=DefaultConnection")
        {

        }

    }

}