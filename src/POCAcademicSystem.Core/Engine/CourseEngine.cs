using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Domain.Exceptions;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using Takenet.Library.Data;
using POCAcademicSystem.Core.Translators;
using Omu.ValueInjecter;

namespace POCAcademicSystem.Core.Engine
{
    public class CourseEngine : ICourseEngine
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CourseEngine(IPOCAcademicContext context)
        {
            _unitOfWork = context;
            _courseRepository = context.CourseRepository;
        }

        public int Create(Domain.Model.CourseDomain course)
        {
            if (course == null)
            {
                throw new InvalidRequestException("Entity course is null.");
            }

            var courseModel = course.ToPersistence();

            _courseRepository.Add(courseModel, true);
            _unitOfWork.Save();

            return courseModel.CourseId;
        }

        public void Update(Domain.Model.CourseDomain course)
        {
            if (course == null)
            {
                throw new InvalidRequestException("Entity course is null.");
            }

            if (course.CourseId != 0)
            {
                var courseModel = _courseRepository.GetById(course.CourseId);
                courseModel.InjectFrom(course);

                _courseRepository.Add(courseModel, false);
                _unitOfWork.Save();
            }
        }

        public void Delete(int id)
        {
            var courseModel = _courseRepository.GetById(id);

            if (courseModel == null)
            {
                throw new NotFoundException("Entity doesn't exists");
            }

            //intention
            _courseRepository.Remove(courseModel);
            //commit
            _unitOfWork.Save();
        }

        public Domain.Model.CourseDomain Get(int id)
        {
            var courseModel = _courseRepository.GetById(id);

            if (courseModel == null)
            {
                throw new NotFoundException("Entity doesn't exists");
            }

            return courseModel.ToDomain();
        }

        public IEnumerable<Domain.Model.CourseDomain> GetAll()
        {
            var courseModels = _courseRepository.AsQueryable();

            if (courseModels.Any())
            {
                //translate each entity repository
                return courseModels.ToList().Select(c => c.ToDomain());
            }

            throw new NotFoundException("There are no course");
        }
    }
}
