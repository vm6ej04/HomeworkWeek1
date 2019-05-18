namespace HomeworkWeek1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vwCustomerOverviewMetaData))]
    public partial class vwCustomerOverview
    {
    }
    
    public partial class vwCustomerOverviewMetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Contacts { get; set; }
        [Required]
        public int Accounts { get; set; }
    }
}
