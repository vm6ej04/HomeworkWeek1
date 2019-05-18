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
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 客戶聯絡人數 { get; set; }
        public Nullable<int> 銀行帳戶數 { get; set; }
    }
}
