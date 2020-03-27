using System.Collections.Generic;
namespace Library.Models
{
   public class Material
    {
        public string Name { get; set; }
        public int NumberOfBooks { get { return Books.Count; }}
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
        public List<Section> Sections { get; set; } = new List<Section>();
        public int NumberOfLectures { get { return Lectures.Count; }}
        public int NumberOfSections { get { return Sections.Count; }}
        public int ID { get; set; } = 0;
    }
}
