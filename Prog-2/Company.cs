class Company
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string FaxNumber { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public Manager Manager { get; set; } = new Manager();
}

