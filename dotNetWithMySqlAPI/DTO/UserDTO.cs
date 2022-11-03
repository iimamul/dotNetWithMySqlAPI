﻿namespace dotNetWithMySqlAPI.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }
    }
}
