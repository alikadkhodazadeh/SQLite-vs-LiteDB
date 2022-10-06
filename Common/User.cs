using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Number { get; set; }

    [StringLength(6)]
    public string? Gender { get; set; }

    [StringLength(25)]
    public string? Nameset { get; set; }

    [StringLength(6)]
    public string? Title { get; set; }

    [StringLength(20)]
    public string? Givenname { get; set; }

    [StringLength(1)]
    public string? Middleinitial { get; set; }

    [StringLength(23)]
    public string? Surname { get; set; }

    [StringLength(100)]
    public string? Streetaddress { get; set; }

    [StringLength(100)]
    public string? City { get; set; }

    [StringLength(22)]
    public string? State { get; set; }

    [StringLength(100)]
    public string? Statefull { get; set; }

    [StringLength(15)]
    public string? Zipcode { get; set; }

    [StringLength(2)]
    public string? Country { get; set; }

    [StringLength(100)]
    public string? Countryfull { get; set; }

    [StringLength(100)]
    public string? Emailaddress { get; set; }

    [StringLength(25)]
    public string? Username { get; set; }

    [StringLength(25)]
    public string? Password { get; set; }

    [StringLength(255)]
    public string? Browseruseragent { get; set; }

    [StringLength(25)]
    public string? Telephonenumber { get; set; }

    public int Telephonecountrycode { get; set; }

    [StringLength(20)]
    public string? Maidenname { get; set; }

    [StringLength(10)]
    public string? Birthday { get; set; }

    public int Age { get; set; }

    [StringLength(11)]
    public string? Tropicalzodiac { get; set; }

    [StringLength(10)]
    public string? Cctype { get; set; }

    [StringLength(16)]
    public string? Ccnumber { get; set; }

    [StringLength(3)]
    public string? Cvv2 { get; set; }

    [StringLength(10)]
    public string? Ccexpires { get; set; }

    [StringLength(20)]
    public string? Nationalid { get; set; }

    [StringLength(24)]
    public string? Upstracking { get; set; }

    [StringLength(10)]
    public string? Westernunionmtcn { get; set; }

    [StringLength(8)]
    public string? Moneygrammtcn { get; set; }

    [StringLength(6)]
    public string? Color { get; set; }

    [StringLength(70)]
    public string? Occupation { get; set; }

    [StringLength(70)]
    public string? Company { get; set; }

    [StringLength(255)]
    public string? Vehicle { get; set; }

    [StringLength(70)]
    public string? Domain { get; set; }

    [StringLength(3)]
    public string? Bloodtype { get; set; }

    [StringLength(5)]
    public string? Pounds { get; set; }

    [StringLength(5)]
    public string? Kilograms { get; set; }

    [StringLength(6)]
    public string? Feetinches { get; set; }

    [StringLength(3)]
    public string? Centimeters { get; set; }

    [StringLength(36)]
    public string? Guid { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
