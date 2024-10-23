using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Arpan",
                    LastName = "Mukherjee",
                    EmployeeNumber = "EMP001",
                    Position = "Software Engineer",
                    Email = "amukharjeearpans99@gmail.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Shubham",
                    LastName = "Kumbhar",
                    EmployeeNumber = "EMP002",
                    Position = "Project Manager",
                    Email = "kumbharshubham5640@gmail.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ariyanth",
                    LastName = "Mukherjee",
                    EmployeeNumber = "EMP003",
                    Position = "HR Coordinator",
                    Email = "ariyanthmukherjee@gmail.com"
                }
            );
        }
    }
}
