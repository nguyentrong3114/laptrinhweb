public class UserModel  {
    public string id;
    public string? FullName {get;set;}
    public string? Email{get;set;}
    public string? Username{get;set;}
    public string? Password{get;set;}

    public DateTime BirthDate { get; set; }
    public string? Gender{get;set;}
    public string? Address{get;set;}
    public string? PhoneNumber{get;set;}
    public string? CreateAt{get;set;}
}