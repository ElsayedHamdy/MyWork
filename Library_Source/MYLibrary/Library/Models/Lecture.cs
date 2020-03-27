namespace Library.Models
{
    public class Lecture
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public int PageCount { get; set; }
        public int Id { get; set; }
        public override bool Equals(object lecture)
        {
            Lecture l = (Lecture)lecture;
            if (this.Name == l.Name)
            {
                if (this.Date == l.Date)
                {
                    if (this.Location == l.Location)
                    {
                        if (this.PageCount == l.PageCount)
                        {
                            if (this.Id == l.Id)
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
