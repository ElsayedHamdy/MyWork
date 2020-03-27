using Library.UserControls.Books;
using Library.UserControls.Courses;
using Library.UserControls.Instructors;
using Library.UserControls.Lectures;
using Library.UserControls.Materials;
using Library.UserControls.Sections;

namespace Library.UserControls
{
    public interface IEditInstructor:IOpen
    {
        void EditInstructor(InstructorDataPanel panel );
    }
    public interface IEditMaterial:IOpen
    {
        void EditMaterial(MaterialDataPanel panel);
    }
    public interface IEditCourse:IOpen
    {
        void EditCourse(CourseDataPanel panel);
    }
    public interface IEditLecture:IOpen
    {
        void EditLecture(LecturesDataPanel panel);
    }
    public interface IEditBook:IOpen
    {
        void EditBook(BooksDataPanel panel);
    }
    public interface IEditSection:IOpen
    {
        void EditSection(SectionsDataPanel panel);
    }
    public interface IOpen
    {
        void Open(object go,string who);
    }
    public interface IUpdate
    {
        void Update();
    }
}
