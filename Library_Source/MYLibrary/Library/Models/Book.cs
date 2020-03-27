using System.Collections.Generic;
using System.Linq;

namespace Library.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public List<string> Authors { get; set; }
        public string Publisher { get; set; }
        public string Location { get; set; }
        public int    ChapterCount { get; set; }
        public int Id { get; set; }
        public int    PageCount { get; set; }
        public override bool Equals(object book)
        {
            Book b = (Book)book;
            if (this.Name == ((Book)book).Name)
            {
                if (this.Date == ((Book)book).Date)
                {
                    if (this.Publisher == ((Book)book).Publisher)
                    {
                        if (this.Location == ((Book)book).Location)
                        {
                            if (this.PageCount == ((Book)book).PageCount)
                            {
                                if (this.ChapterCount == ((Book)book).ChapterCount)
                                {
                                    this.Authors.Sort();
                                    b.Authors.Sort();
                                    if (this.Authors.SequenceEqual(b.Authors))
                                    {
                                        if (this.Id == ((Book)book).Id)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
