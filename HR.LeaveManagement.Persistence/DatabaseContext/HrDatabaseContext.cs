﻿using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
namespace HR.LeaveManagement.Persistence.DatabaseContext
{
    public class HrDatabaseContext : DbContext
    {
        public HrDatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
        //        .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        //    {
        //        entry.Entity.DateModified = DateTime.Now;
        //        entry.Entity.ModifiedBy = _userService.UserId;
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Entity.DateCreated = DateTime.Now;
        //            entry.Entity.CreatedBy = _userService.UserId;
        //        }
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}
    }
}
