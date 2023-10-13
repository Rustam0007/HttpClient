namespace HttpClient2;

public class UserData
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Avatar { get; set; }
}

public class Support
{
    public string Url { get; set; }
    public string Text { get; set; }
}

public class Root
{
    public UserData Data { get; set; }
    public Support Support { get; set; }
}

public readonly record struct UserPostReq(string Name, string Job);
public readonly record struct UserPostRes(string Name, string Job, int Id, string CreatedAt);