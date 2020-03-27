namespace Library.Models
{
    public class Section
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public int PageCount { get; set; }
        public int Id { get; set; }
        public override bool Equals(object section)
        {
            Section s = (Section)section;
            if (this.Name == s.Name)
            {
                if (this.Date == s.Date)
                {
                    if (this.Location == s.Location)
                    {
                        if (this.PageCount == s.PageCount)
                        {
                            if (this.Id == s.Id)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
