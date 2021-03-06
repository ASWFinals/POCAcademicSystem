﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using Takenet.Library.Data;
using POCAcademicSystem.Core.Translators;
using Omu.ValueInjecter;
using POCAcademicSystem.Domain.Exceptions;

namespace POCAcademicSystem.Core.Engine
{
    public class EnrollmentEngine : IEnrollmentEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentEngine(IPOCAcademicContext context)
        {
            _unitOfWork = context;
            _enrollmentRepository = context.EnrollmentRepository;
        }

        public int Create(Domain.Model.EnrollmentDomain enrollmentDomain)
        {
            if (enrollmentDomain == null)
            {
                throw new InvalidRequestException("Enrollment entity is null");
            }

            //translating DTOs
            var enrollmentModel = enrollmentDomain.ToPersistence();
            
            _enrollmentRepository.Add(enrollmentModel, true);
            _unitOfWork.Save();

            return enrollmentModel.EnrollmentId;
        }

        public Domain.Model.EnrollmentDomain Get(int id)
        {
            var enrollmentModel = _enrollmentRepository.GetById(id);

            if (enrollmentModel == null)
            {
                throw new NotFoundException("Enrollment entity does not exists");
            }

            return enrollmentModel.ToDomain();
        }

        public void Update(Domain.Model.EnrollmentDomain enrollmentDomain)
        {
            if (enrollmentDomain == null)
            {
                throw new InvalidRequestException("Entidade não pode ser nula");
            }

            if (enrollmentDomain.EnrollmentId != 0)
            {
                var enrollmentModel = _enrollmentRepository.GetById(enrollmentDomain.EnrollmentId);
                enrollmentModel.InjectFrom(enrollmentDomain);

                _enrollmentRepository.Add(enrollmentModel, false);
                _unitOfWork.Save();
            }

        }

        public void Delete(int id)
        {
            var enrollmentModel = _enrollmentRepository.GetById(id);

            if (enrollmentModel == null)
            {
                throw new NotFoundException("Entidade não existe");
            }
            _enrollmentRepository.Remove(enrollmentModel);
            _unitOfWork.Save();

        }

        public IEnumerable<Domain.Model.EnrollmentDomain> GetAll()
        {
            var enrollmentModels = _enrollmentRepository.AsQueryable();

            if (enrollmentModels.Any())
            {
                //foreach enrollment in repository, translate them.
                return enrollmentModels.ToList().Select(e => e.ToDomain());
            }

            throw new NotFoundException("There are no enrollment");
        }
    }
}
