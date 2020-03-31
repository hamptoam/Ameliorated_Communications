using System;
using System.Collections.Generic;
using System.Text;
using Ameliorated_Communications.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ameliorated_Communications.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Callee> Callees { get; set; }

      //  public DbSet<Manager> Managers { get; set; }

        //public DbSet<Employee> Employees { get; set; }

        public DbSet<Campaign> Campaigns { get; set; }

      //  public DbSet<Manager> Managers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Ameliorated_Communications.Models.Employee> Employee { get; set; }

        public DbSet<Ameliorated_Communications.Models.Fund> Fund { get; set; }

        public DbSet<Ameliorated_Communications.Models.Manager> Manager { get; set; }

        public DbSet<Ameliorated_Communications.Models.Phone> Phone { get; set; }

  //      public DbSet<Funds> Funds { get; set; }

    //    public DbSet<CalleeCampaign> CalleeCampaigns { get; set; }

      //  public DbSet<CampaignEmployee> CampaignEmployees { get; set; }

        //public DbSet<CampaignManager> CampaignManagers { get; set; }

       // public DbSet<EmployeeCallee> EmployeeCallees { get; set; }

    //    public DbSet<ManagerEmployee> ManagerEmployees { get; set; }

      //  public DbSet<CalleeFunds> CalleeFunds { get; set; }

      //  public DbSet<CampaignFunds> CampaignFunds { get; set; }

       // public DbSet<EmployeeFunds> EmployeeFunds { get; set; }

      //  public DbSet<Phone> Phones { get; set; }

    }
}
