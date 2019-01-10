using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SupportTool.Models.ClientInfo
{
    public class ClientDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ClientID")]
        public Clients ClientID { get; set; }

        // example: ('BOE CMC URL', 'http://BOE/CMC', 'username', 'password')

        [Required]
        public string EnvTitle { get; set; }

        [Required]
        public string EnvDetails { get; set; }

        public string envUsername { get; set; }

        public string envPassword { get; set; }
    }
}