﻿using Gudulion.BackEnd.DB;

namespace Gudulion.BackEnd.Moduls.Sweet;

public class Sweet:IEntityWithId
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Occasion { get; set; }
    public string trackingCode { get; set; }
    public SweetType Type { get; set; }
    public DateTime AddDate { get; set; }
    public DateTime PayDate { get; set; }
}

public class UserSweetMappign
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User.User User { get; set; }
    public int SweetId { get; set; }
    public Sweet Sweet { get; set; }
    public bool IsPayer { get; set; }
}

public enum SweetType
{
}