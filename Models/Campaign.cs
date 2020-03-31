using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ameliorated_Communications.Models
{
    public class Campaign
    {

        [Key]
        public int CampaignId { get; set; }

        public string CampaignName { get; set; }

        // public List<Employee> assignedCallers { get; set; }
       // public virtual ICollection<Employee> Employees { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public string campaignStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public string campaignEndDate { get; set; }


    }
}
