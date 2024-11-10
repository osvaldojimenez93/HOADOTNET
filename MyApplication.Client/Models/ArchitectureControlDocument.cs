
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApplication.Client.Models;

public class ArchitectureControlDocument
{
    public Guid Id { get; set; }
    public Requestor Requestor { get; set; }
    public PropertyOwner PropertyOwner { get; set; }
    public MailingAddress MailingAddress { get; set; }
    public MailingAddress ConstructionSite { get; set; }
    public string Purpose { get; set; }
    public int ContstructionSize { get; set; }
    public int MasonryPercentage { get; set; }
    public int FrontSetback { get; set; } //Must be greater than 50'
    public bool IsCornerLot { get; set; } // If true, then SideSetback is 20'
    public int SideSetback { get; set; } //If not corner lot then setback is 10'
    public string AdditionalCommentary { get; set; }
    
}

public class Requestor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

public class Property
{
    public MailingAddress StreetAddress { get; set; }
    public string PropertyLotNumber { get; set; }
}

public class PropertyOwner
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Property Property { get; set; }
}

public class MailingAddress
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}