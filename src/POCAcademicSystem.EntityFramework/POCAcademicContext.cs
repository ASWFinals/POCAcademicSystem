﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Model;
using Takenet.Library.Data.EntityFramework;
using System.Data.Entity;
using POCAcademicSystem.Persistence.Repository;
using POCAcademicSystem.EntityFramework.Mappings;

namespace POCAcademicSystem.EntityFramework
{
    public class POCAcademicContext : UnitOfWorkDbContext, IPOCAcademicContext
    {
        private readonly IServiceProvider _serviceProvider;

        public IDbSet<Student> Students { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Enrollment> Enrollments { get; set; }
        public IDbSet<ServiceType> ServiceTypes { get; set; }
        public IDbSet<ServiceRequest> ServiceRequests { get; set; }

        public POCAcademicContext()
            : base("POCAcademicSystemContext")
        {

        }

        public POCAcademicContext(IServiceProvider serviceProvider)
            : base("POCAcademicSystemContext")
        {
            _serviceProvider = serviceProvider;
            Configuration.ValidateOnSaveEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new CourseMapping());
            modelBuilder.Configurations.Add(new EnrollmentMapping());
            modelBuilder.Configurations.Add(new ServiceTypeMapping());
            modelBuilder.Configurations.Add(new ServiceRequestMapping());
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(IStudentRepository)) as IStudentRepository;
            }
        }

        public ICourseRepository CourseRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(ICourseRepository)) as ICourseRepository;
            }
        }

        public IEnrollmentRepository EnrollmentRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(IEnrollmentRepository)) as IEnrollmentRepository;
            }
        }

        public IServiceTypeRepository ServiceTypeRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(IServiceTypeRepository)) as IServiceTypeRepository;
            }
        }

        public IServiceRequestRepository ServiceRequestRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(IServiceRequestRepository)) as IServiceRequestRepository;
            }
        }
    }
}
