using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        [Required]
        [Display(Name = "Name:")]
        [DataType(DataType.Text)]
         public string name {get; set;}

        [Required]
        [Display(Name = "Quote:")]
        [DataType(DataType.Text)]
         public string quote {get; set;}
    }
}