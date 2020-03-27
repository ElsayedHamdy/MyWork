using Library.Models;
using System;
using System.Collections.Generic;
namespace Library.DataAccess
{
    public class TextConnector /*: IConnection*/
    {
        public List<string> CreateAuthors(Book book)
        {
            throw new NotImplementedException();
        }

        public Book CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Course CreateCourse(Course courses)
        {
            return courses;
        }

        public Instructor CreateInstractor(Instructor instructor)
        {
            return instructor;
        }

        public Lecture CreateLecture(Lecture lecture)
        {
            throw new NotImplementedException();
        }

        public Material CreateMaterials(Material materials)
        {
            return materials;
        }

        public Section CreateSection(Section section)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAuthors(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public Instructor GetInstructor(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetInstructors()
        {
            throw new NotImplementedException();
        }

        public List<Lecture> GetLectures()
        {
            throw new NotImplementedException();
        }

        public List<Material> GetMaterials()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetMaterialsBooks(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Lecture> GetMaterialsLectures(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Section> GetMaterialsSections(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Section> GetSections()
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchBooks(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Course> SearchCourses(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> SearchInstructors(string FirstName, string LastName,string Type)
        {
            throw new NotImplementedException();
        }

        public List<Lecture> SearchLectures(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Material> SearchMaterials(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Section> SearchSections(string Name)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void DeleteInstructor(int Id)
        {
            throw new NotImplementedException();
        }

        public Material GetMaterial(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public void DeleteMaterial(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Lecture> GetLecturesWithoutMaterials(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Section> GetSectionsWithoutMaterials(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksWithoutMaterials(int Id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
