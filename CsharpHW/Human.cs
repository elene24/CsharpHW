using System;

public class Human
{
    private string _firstName;
    private string _lastName;
    private byte _age;
    private string _personalNumber;
    private string _phoneNumber;
    private string _email;

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name is required");
            if (value.Length > 50)
                throw new ArgumentException("First name cannot exceed 50 characters");
            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name is required");
            if (value.Length > 50)
                throw new ArgumentException("Last name cannot exceed 50 characters");
            _lastName = value;
        }
    }

    public byte Age
    {
        get => _age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be positive");
            _age = value;
        }
    }

    public string PersonalNumber
    {
        get => _personalNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is required");
            if (value.Length != 11)
                throw new ArgumentException("Personal number must be exactly 11 characters");
            _personalNumber = value;
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number is required");
            if (value.Length != 9)
                throw new ArgumentException("Phone number must be exactly 9 characters");
            _phoneNumber = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is required");

            if (!value.Contains("@") || !value.Contains("."))
                throw new ArgumentException("Email must contain @ and .");

            if (value.StartsWith("@") || value.StartsWith("."))
                throw new ArgumentException("Email cannot start with @ or .");

            if (value.EndsWith("@") || value.EndsWith("."))
                throw new ArgumentException("Email cannot end with @ or .");

            int atIndex = value.IndexOf('@');
            int dotIndex = value.IndexOf('.');
            if (dotIndex < atIndex)
                throw new ArgumentException(". cannot come before @ in email");

            _email = value;
        }
    }

    public Human(string firstName, string lastName, byte age, string personalNumber, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PersonalNumber = personalNumber;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfoInConsole()
    {
        Console.WriteLine($"{FirstName} {LastName} {Age} {PersonalNumber} {PhoneNumber} {Email}");
    }
}