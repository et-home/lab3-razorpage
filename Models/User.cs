using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab3.Models;

public class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }


    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Confirm Password")]
    [NotMapped, DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string? VarPassword { get; set; }

    [MinLength(2, ErrorMessage = "A single letter First Name?")]
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }

    [MinLength(2, ErrorMessage = "A single letter Laster Name?")]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }

    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
    [Display(Name = "Email Address")]
    public string? Email { get; set; }

    //address
    [Required]
    [Display(Name = "Street No.")]
    public int? StreetNumber { get; set; }

    [Required]
    [Display(Name = "Street Name")]
    public string? StreetName { get; set; }

    [Display(Name = "Postal Code")]
    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
    public string? PostalCode { get; set; }

    [Required]
    public string? City { get; set; }

    [Required]
    [StringLength(2, ErrorMessage = "Use 2 letters notation")]
    public string? Province { get; set; }

    [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "Phone number format is incorrect!")]
    public string? Phone { get; set; }

}