using Dapper;
using Library.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Library.DataAccess
{
    public class SqlConnector : IConnection
    {
        private const string db = "Library";
        public List<string> CreateAuthors(Book book)
        {
            if (book.Authors!=null)
            {
                using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
                {
                    foreach (var item in book.Authors)
                    {
                        var p = new DynamicParameters();
                        p.Add("@Author", item);
                        p.Add("@BookId", book.Id);
                        connection.Execute("dbo.spAuthors_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
                return book.Authors;
            }else
            {
               return null;
            }
        }
        public Book CreateBook(Book book,int materialid)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", book.Name);
                p.Add("@Publisher", book.Publisher);
                p.Add("@PageCount", book.PageCount);
                p.Add("@Location", book.Location);
                p.Add("@ChapterCount", book.ChapterCount);
                p.Add("@Date", book.Date);
                p.Add("@MaterialId", materialid);
                p.Add("@Id", book.Id, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spBook_Insert", p, commandType: CommandType.StoredProcedure);
                book.Id = p.Get<int>("@Id");
                CreateAuthors(book);
            }
            return book;
        }
        public Course CreateCourse(Course course)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", course.Name);
                p.Add("@Place", course.Place);
                p.Add("@Price", course.Price);
                p.Add("@Time", course.time.ToString());
                p.Add("@Period", course.period.ToString());
                p.Add("@Day", course.Day.ToString());
                p.Add("@InstructorId", course.Instructor.ID);
                p.Add("@MaterialId", course.Material.ID);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spCourses_Insert", p, commandType: CommandType.StoredProcedure);
                course.ID = p.Get<int>("@Id");
            }
            return course;
        }
        public Instructor CreateInstructor(Instructor instructor)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", instructor.FirstName);
                p.Add("@LastName", instructor.LastName);
                p.Add("@EmailAdress", instructor.Email);
                p.Add("@PhoneNumber", instructor.Phone);
                p.Add("@Type", instructor.type.ToString());
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spInstructors_Insert", p, commandType: CommandType.StoredProcedure);
                instructor.ID = p.Get<int>("@Id");
            }
            return instructor;
        }
        public Lecture CreateLecture(Lecture lecture,int materialid)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", lecture.Name);
                p.Add("@PageCount", lecture.PageCount);
                p.Add("@Location", lecture.Location);
                p.Add("@Date", lecture.Date);
                p.Add("@MaterialId", materialid);
                p.Add("@Id", lecture.Id, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spLecture_Insert", p, commandType: CommandType.StoredProcedure);
                lecture.Id = p.Get<int>("@Id");
            }
            return lecture;
        }
        public Material CreateMaterials(Material materials)
        {
            using(IDbConnection connection =new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name",materials.Name);
                p.Add("@NumberOfBooks", materials.NumberOfBooks);
                p.Add("@NumberOfLectures", materials.NumberOfLectures);
                p.Add("@NumberOfSections", materials.NumberOfSections);
                p.Add("@Id", materials.ID,dbType:DbType.Int32,direction:ParameterDirection.Output);
                connection.Execute("dbo.spMaterials_Insert", p,commandType:CommandType.StoredProcedure);
                materials.ID = p.Get<int>("@Id");
                foreach (var item in materials.Books)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@Publisher", item.Publisher);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@ChapterCount", item.ChapterCount);
                    p.Add("@Date", item.Date);
                    p.Add("@Id",item.Id,DbType.Int32,ParameterDirection.InputOutput);
                    p.Add("@MaterialId", materials.ID);
                    connection.Execute("dbo.spMaterIalsBooks_Insert", p, commandType: CommandType.StoredProcedure);
                    item.Id = p.Get<int>("@Id") ;
                    CreateAuthors(item);
                }
                foreach (var item in materials.Lectures)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@Date", item.Date);
                    p.Add("@LectureId", 0);
                    p.Add("@MaterialId", materials.ID);
                    connection.Execute("dbo.spMaterIalsLectures_Insert", p, commandType: CommandType.StoredProcedure);
                }
                foreach (var item in materials.Sections)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@Date", item.Date);
                    p.Add("@SectionId", 0);
                    p.Add("@MaterialId", materials.ID);
                    connection.Execute("dbo.spMaterIalsSections_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
            return materials;
        }
        public Section CreateSection(Section section,int materialid)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", section.Name);
                p.Add("@PageCount", section.PageCount);
                p.Add("@Location", section.Location);
                p.Add("@Date", section.Date);
                p.Add("@MaterialId", materialid);
                p.Add("@Id", section.Id, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spSection_Insert", p, commandType: CommandType.StoredProcedure);
                section.Id = p.Get<int>("@Id");
            }
            return section;
        }
        public List<string> GetAuthors(int Id)
        {
            List<string> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@BookId", Id, dbType: DbType.Int32);
                output = connection.QueryAsync<string>("dbo.spAuthors_Get",p,commandType:CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetBooks()
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooks_Get").Result.ToList();
                for (int i = 0; i < output.Count; i++)
                {
                    output[i].Authors = GetAuthors(output[i].Id);
                }
            }
            return output;
        }
        public List<Course> GetCourses()
        {
            List<Course> output;
            using(IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Course>("dbo.spCourses_Get").Result.ToList();
                foreach(Course course in output)
                {
                    course.Material = connection.QuerySingle<Material>("dbo.spCoursesMaterials_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                    course.Material.Lectures = GetMaterialsLectures(course.Material.ID);
                    course.Material.Sections = GetMaterialsSections(course.Material.ID);
                    course.Material.Books = GetMaterialsBooks(course.Material.ID);
                    course.Instructor = connection.QuerySingle<Instructor>("dbo.spCoursesInstructors_Get", new { CourseId = course.ID },commandType:CommandType.StoredProcedure);
                }
            }
            return output;
        }
        public List<Lecture> GetMaterialsLectures(int Id)
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spMaterialsLectures_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Instructor> GetInstructors()
        {
            List<Instructor> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Instructor>("dbo.spInstructors_GET").Result.ToList();
            }
            return output;
        }
        public List<Lecture> GetLectures()
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLectures_Get").Result.ToList();
            }
            return output;
        }
        public List<Material> GetMaterials()
        {
            List<Material> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Material>("dbo.spMaterials_GET").Result.ToList();
                foreach (var material in output)
                {
                    material.Lectures = GetMaterialsLectures(material.ID);
                    material.Books = GetMaterialsBooks(material.ID);
                    material.Sections = GetMaterialsSections(material.ID);
                }
            }
            return output;
        }
        public List<Section> GetSections()
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSections_Get").Result.ToList();
            }
            return output;
        }
        public List<Section> GetMaterialsSections(int Id)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spMaterialsSections_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetMaterialsBooks(int Id)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spMaterialsBooks_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
                for (int i = 0; i < output.Count; i++)
                {
                    output[i].Authors = GetAuthors(output[i].Id);
                }
            }
            return output;
        }
        public List<Instructor> SearchInstructors(string FirstName, string LastName,string Type)
        {
            List<Instructor> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Instructor>("dbo.spInstructors_Search",new {FirstName=FirstName,LastName=LastName,Type = Type},commandType:CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Course> SearchCourses(string Name)
        {
            List<Course> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Course>("dbo.spCourses_Search", new { Name = Name }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (Course course in output)
                {
                    course.Material = connection.QuerySingle<Material>("dbo.spCoursesMaterials_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                    course.Material.Lectures = GetMaterialsLectures(course.Material.ID);
                    course.Material.Sections = GetMaterialsSections(course.Material.ID);
                    course.Material.Books = GetMaterialsBooks(course.Material.ID);
                    course.Instructor = connection.QuerySingle<Instructor>("dbo.spCoursesInstructors_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                }
            }
            return output;
        }
        public List<Material> SearchMaterials(string Name)
        {
            List<Material> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Material>("dbo.spMaterials_Search", new { Name = Name }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var material in output)
                {
                    material.Lectures = GetMaterialsLectures(material.ID);
                    material.Books = GetMaterialsBooks(material.ID);
                    material.Sections = GetMaterialsSections(material.ID);
                }
            }
            return output;
        }
        public List<Lecture> SearchLectures(string Name)
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLectures_Search", new { Name = Name}, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Section> SearchSections(string Name)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSections_Search", new { Name = Name }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> SearchBooks(string Name)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooks_Search", new { Name = Name }, commandType: CommandType.StoredProcedure).Result.ToList();
                for (int i = 0; i < output.Count; i++)
                {
                    output[i].Authors = GetAuthors(output[i].Id);
                }
            }
            return output;
        }
        public Instructor GetInstructor(int Id)
        {
            Instructor instructor;
            using(IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                instructor = connection.QuerySingle<Instructor>("dbo.spInstructor_Get",new { Id = Id },commandType:CommandType.StoredProcedure);
            }
            return instructor;
        }
        public Course GetCourse(int Id)
        {
            Course course;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                course = connection.QuerySingle<Course>("dbo.spCourse_Get", new { Id = Id }, commandType: CommandType.StoredProcedure);
                course.Material = connection.QuerySingle<Material>("dbo.spCoursesMaterials_Get", new { CourseId = Id }, commandType: CommandType.StoredProcedure);
                course.Material.Lectures = GetMaterialsLectures(course.Material.ID);
                course.Material.Sections = GetMaterialsSections(course.Material.ID);
                course.Material.Books = GetMaterialsBooks(course.Material.ID);
                course.Instructor = connection.QuerySingle<Instructor>("dbo.spCoursesInstructors_Get", new { CourseId = Id }, commandType: CommandType.StoredProcedure);
            }
            return course;
        }
        public void UpdateInstructor(Instructor instructor)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", instructor.ID);
                p.Add("@FirstName", instructor.FirstName);
                p.Add("@LastName", instructor.LastName);
                p.Add("@Email", instructor.Email);
                p.Add("@Phone", instructor.Phone);
                p.Add("@Type", instructor.type.ToString());
                connection.Execute("dbo.spInstructor_Update", p,commandType: CommandType.StoredProcedure);
            }
        }
        public void  DeleteInstructor(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spInstructor_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public Material GetMaterial(int Id)
        {
            Material material;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                material = connection.QuerySingle<Material>("dbo.spMaterial_Get", new { Id = Id }, commandType: CommandType.StoredProcedure);
                material.Lectures = GetMaterialsLectures(material.ID);
                material.Sections = GetMaterialsSections(material.ID);
                material.Books = GetMaterialsBooks(material.ID);
            }
            return material;
        }
        public void UpdateMaterial(Material material)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", material.ID);
                p.Add("@Name", material.Name);
                p.Add("@NumberOfBooks", material.NumberOfBooks);
                p.Add("@NumberOfLectures", material.NumberOfLectures);
                p.Add("@NumberOfSections", material.NumberOfSections);
                connection.Execute("dbo.spMaterial_Update", p, commandType: CommandType.StoredProcedure);
                foreach (var item in material.Books)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@Publisher", item.Publisher);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@ChapterCount", item.ChapterCount);
                    p.Add("@Date", item.Date);
                    p.Add("@Id", 0,DbType.Int32,ParameterDirection.InputOutput);
                    p.Add("@MaterialId", material.ID);
                    connection.Execute("dbo.spMaterIalsBooks_Insert", p, commandType: CommandType.StoredProcedure);
                    item.Id = p.Get<int>("@Id");
                    CreateAuthors(item);
                }
                foreach (var item in material.Lectures)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@Date", item.Date);
                    p.Add("@LectureId", 0);
                    p.Add("@MaterialId", material.ID);
                    connection.Execute("dbo.spMaterIalsLectures_Insert", p, commandType: CommandType.StoredProcedure);
                }
                foreach (var item in material.Sections)
                {
                    p = new DynamicParameters();
                    p.Add("@Name", item.Name);
                    p.Add("@PageCount", item.PageCount);
                    p.Add("@Location", item.Location);
                    p.Add("@Date", item.Date);
                    p.Add("@SectionId", 0);
                    p.Add("@MaterialId", material.ID);
                    connection.Execute("dbo.spMaterIalsSections_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public void DeleteMaterial(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spMaterial_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Section> GetSectionsWithoutMaterials(int Id)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSectionsWithoutMaterIals_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetBooksWithoutMaterials(int Id)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooksWithoutMaterials_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Lecture> GetLecturesWithoutMaterials(int Id)
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLecturesWithoutMaterIals_Get", new { MaterialId = Id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public void UpdateCourse(Course course)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", course.Name);
                p.Add("@Place", course.Place);
                p.Add("@Price", course.Price);
                p.Add("@Time", course.time.ToString());
                p.Add("@Period", course.period.ToString());
                p.Add("@Day", course.Day.ToString());
                p.Add("@InstructorId", course.Instructor.ID);
                p.Add("@MaterialId", course.Material.ID);
                p.Add("@Id", course.ID);
                connection.Execute("dbo.spCourse_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteCourse(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spCourse_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public Book GetBook(int Id)
        {
            Book book;
            using(IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                book = connection.QuerySingle<Book>("dbo.spBook_Get",new { Id = Id },commandType:CommandType.StoredProcedure);
                book.Authors = GetAuthors(Id);
            }
            return book;
        }
        public void UpdateBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", book.Name);
                p.Add("@Publisher", book.Publisher);
                p.Add("@PageCount", book.PageCount);
                p.Add("@Location", book.Location);
                p.Add("@ChapterCount", book.ChapterCount);
                p.Add("@Date", book.Date);
                p.Add("@Id", book.Id);
                connection.Execute("dbo.spBook_Update", p, commandType: CommandType.StoredProcedure);
                CreateAuthors(book);
            }
        }
        public void DeleteBook(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spBook_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public Lecture GetLecture(int Id)
        {
            Lecture output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QuerySingle<Lecture>("dbo.spLecture_Get",new { Id = Id },commandType:CommandType.StoredProcedure);
            }
            return output;
        }
        public void UpdateLecture(Lecture lecture)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", lecture.Name);
                p.Add("@PageCount", lecture.PageCount);
                p.Add("@Location", lecture.Location);
                p.Add("@Date", lecture.Date);
                p.Add("@Id", lecture.Id);
                connection.Execute("dbo.spLecture_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteLecture(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spLecture_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public Section GetSection(int Id)
        {
            Section output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QuerySingle<Section>("dbo.spSection_Get", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
            return output;
        }
        public void UpdateSection(Section section)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", section.Name);
                p.Add("@PageCount", section.PageCount);
                p.Add("@Location", section.Location);
                p.Add("@Date", section.Date);
                p.Add("@Id", section.Id);
                connection.Execute("dbo.spSection_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteSection(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spSection_Delete", new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Lecture> GetLecturesByInstructor(int id)
        {
            List<Lecture> output;
            using(IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLecturesByInstructor_Get", new { instructorid = id },commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Section> GetSectionsByInstructor(int id)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSectionsByInstructor_Get", new { instructorid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetBooksByInstructor(int id)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooksByInstructor_Get", new { instructorid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var book in output)
                {
                    book.Authors = GetAuthors(book.Id);
                }
            }
            return output;
        }
        public List<Course> GetCourseByInstructor(int id)
        {
            List<Course> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Course>("dbo.spCoursesByInstructor_Get", new { instructorid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (Course course in output)
                {
                    course.Material = connection.QuerySingle<Material>("dbo.spCoursesMaterials_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                    course.Material.Lectures = GetMaterialsLectures(course.Material.ID);
                    course.Material.Sections = GetMaterialsSections(course.Material.ID);
                    course.Material.Books = GetMaterialsBooks(course.Material.ID);
                    course.Instructor = connection.QuerySingle<Instructor>("dbo.spCoursesInstructors_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                }
            }
            return output;
        }
        public List<Material> GetMaterialByInstructor(int id)
        {
            List<Material> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Material>("dbo.spMaterialsByInstructor_GET", new { instructorid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var material in output)
                {
                    material.Lectures = GetMaterialsLectures(material.ID);
                    material.Books = GetMaterialsBooks(material.ID);
                    material.Sections = GetMaterialsSections(material.ID);
                }
            }
            return output;
        }
        public List<Lecture> GetLecturesByCourse(int id)
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLecturesByCourse_Get", new { courseid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Section> GetSectionsByCourse(int id)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSectionsByCourse_Get", new { courseid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetBooksByCourse(int id)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooksByCourse_Get", new { courseid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var book in output)
                {
                    book.Authors = GetAuthors(book.Id);
                }
            }
            return output;
        }
        public List<Instructor> GetInstructorsByCourse(int id)
        {
            List<Instructor> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Instructor>("dbo.spInstructorsByCourse_Get", new { courseid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Material> GetMaterialByCourse(int id)
        {
            List<Material> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Material>("dbo.spMaterialsByCourse_GET", new { courseid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var material in output)
                {
                    material.Lectures = GetMaterialsLectures(material.ID);
                    material.Books = GetMaterialsBooks(material.ID);
                    material.Sections = GetMaterialsSections(material.ID);
                }
            }
            return output;
        }
        public List<Lecture> GetLecturesByMaterial(int id)
        {
            List<Lecture> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Lecture>("dbo.spLecturesByMaterial_Get", new { materialid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Section> GetSectionsByMaterial(int id)
        {
            List<Section> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Section>("dbo.spSectionsByMaterial_Get", new { materialid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Book> GetBooksByMaterial(int id)
        {
            List<Book> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Book>("dbo.spBooksByMaterial_Get", new { materialid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (var book in output)
                {
                    book.Authors = GetAuthors(book.Id);
                }
            }
            return output;
        }
        public List<Instructor> GetInstructorsByMaterial(int id)
        {
            List<Instructor> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Instructor>("dbo.spInstructorsByMaterial_Get", new { materialid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
            }
            return output;
        }
        public List<Course> GetCoursesByMaterial(int id)
        {
            List<Course> output;
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                output = connection.QueryAsync<Course>("dbo.spCoursesByMaterial_GET", new { materialid = id }, commandType: CommandType.StoredProcedure).Result.ToList();
                foreach (Course course in output)
                {
                    course.Material = connection.QuerySingle<Material>("dbo.spCoursesMaterials_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                    course.Material.Lectures = GetMaterialsLectures(course.Material.ID);
                    course.Material.Sections = GetMaterialsSections(course.Material.ID);
                    course.Material.Books = GetMaterialsBooks(course.Material.ID);
                    course.Instructor = connection.QuerySingle<Instructor>("dbo.spCoursesInstructors_Get", new { CourseId = course.ID }, commandType: CommandType.StoredProcedure);
                }
            }
            return output;
        }
        public void Wipe()
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spwipe_all_records",commandType: CommandType.StoredProcedure);
            }
        }
        public void Backup()
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                connection.Execute("dbo.spbackup_all_records", commandType: CommandType.StoredProcedure);
            }
        }
        public void Restore(string file)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString("master")))
            {
                connection.Execute($"USE MASTER ALTER DATABASE [{db}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", commandType: CommandType.Text);
                connection.Execute($"use master restore database [{db}] from disk = '"+ file + "' with replace;" ,commandType: CommandType.Text);
                connection.Execute($"USE MASTER ALTER DATABASE [{db}] SET MULTI_USER", commandType: CommandType.Text);
            }
        }
        public bool CheckInstructors(Instructor instructor)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                if (connection.Query<Instructor>("dbo.spInstructors_Check", new { FirstName = instructor.FirstName, LastName = instructor.LastName, Type = instructor.type.ToString(), PhoneNumber = instructor.Phone, EmailAdress = instructor.Email }, commandType: CommandType.StoredProcedure).Count() > 0) return true;
                return false;
            }
        }
        public bool CheckMaterials(Material materials)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", materials.Name);
                p.Add("@NumberOfBooks", materials.NumberOfBooks);
                p.Add("@NumberOfLectures", materials.NumberOfLectures);
                p.Add("@NumberOfSections", materials.NumberOfSections);
                if (Convert.Equal(materials.Books.ToArray(), GetBooksByMaterial(materials.ID).ToArray()))
                {
                    if (Convert.Equal(materials.Lectures.ToArray(), GetMaterialsLectures(materials.ID).ToArray()))
                    {
                        if (Convert.Equal(materials.Sections.ToArray(), GetMaterialsSections(materials.ID).ToArray()))
                        {
                            if (connection.Query<Material>("dbo.spMaterials_Check", p, commandType: CommandType.StoredProcedure).Count() > 0)
                            {
                                return true;
                            }
                        }
                    }
                }
                    return false;
            }
        }
        public bool CheckCourses(Course course)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                if (connection.Query<Course>("dbo.spCourses_Check", new { Name = course.Name,Day = course.Day.ToString(),Period = course.period.ToString(),Time = course.time.ToString(),Place = course.Place,Price = course.Price, InstructorId = course.Instructor.ID, MaterialId = course.Material.ID }, commandType: CommandType.StoredProcedure).Count() > 0) return true;
                return false;
            }
        }
        public bool CheckLectures(Lecture lecture)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", lecture.Name);
                p.Add("@PageCount", lecture.PageCount);
                p.Add("@Location", lecture.Location);
                p.Add("@Date", lecture.Date);
                if (connection.Query<Lecture>("dbo.spLectures_Check",p, commandType: CommandType.StoredProcedure).Count() > 0) return true;
                return false;
            }
        }
        public bool CheckSections(Section section)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", section.Name);
                p.Add("@PageCount", section.PageCount);
                p.Add("@Location", section.Location);
                p.Add("@Date", section.Date);
                if (connection.Query<Section>("dbo.spSections_Check",p, commandType: CommandType.StoredProcedure).Count() > 0) return true;
                return false;
            }
        }
        public bool CheckBooks(Book book)
        {
            using (IDbConnection connection = new SqlConnection(Connector.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", book.Name);
                p.Add("@Publisher", book.Publisher);
                p.Add("@PageCount", book.PageCount);
                p.Add("@Location", book.Location);
                p.Add("@ChapterCount", book.ChapterCount);
                p.Add("@Date", book.Date);
                if (Convert.Equal(book.Authors.ToArray(),GetAuthors(book.Id).ToArray()))
                {
                    if (connection.Query<Book>("dbo.spBooks_Check", p, commandType: CommandType.StoredProcedure).Count() > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
