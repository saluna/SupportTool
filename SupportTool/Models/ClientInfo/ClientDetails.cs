using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SupportTool.Models.ClientInfo
{
    public class ClientDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        // 1 if prod, 0 if non-prod
        public bool prod { get; set; }

        // if prod = 1, then envType == 'Prod'.
        // Otherwise, the envType can be set to the environment name such as 
        public string envType { get; set; }

        //[Column("ClientID")]
        // public Clients ClientID { get; set; }

        // example: ('BOE CMC URL', 'http://BOE/CMC', 'username', 'password')

        [Required]
        public string envTitle { get; set; }

        [Required]
        public string envDetails { get; set; }

        public string envUsername { get; set; }

        public string envPassword { get; set; }

        public virtual Clients Clients { get; set; }

    }

}