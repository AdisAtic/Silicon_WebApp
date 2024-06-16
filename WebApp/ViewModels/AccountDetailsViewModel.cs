﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic {  get; set; }
    public AccountAddressInfo? Address { get; set; }
}


public class AccountBasicInfo
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone (optional)", Prompt = "Enter your phone ")]
    public string? PhoneNumber { get; set; }


    [Display(Name = "Bio (optional)", Prompt = "Add a short bio...")]
    public string? Bio { get; set; }
}

public class AccountAddressInfo
{
    [Required]
    [Display(Name = "Addressline 1", Prompt = "Enter your first addressline")]
    public string AddressLine_1 { get; set; } = null!;

    [Display(Name = "Addressline 2", Prompt = "Enter your second addressline")]
    public string? AddressLine_2 { get; set; }

    [Required]
    [Display(Name = "Postal Code", Prompt = "Enter your Postal Code")]
    public string PostalCode {  get; set; } = null!;

    [Required]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
} 