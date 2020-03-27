namespace Library.Models
{
   public class Course
    {
        public Instructor Instructor { get; set; } = new Instructor();
        public Material Material { get; set; } = new Material();
        public Days Day { get; set; } = new Days();
        /// <summary>
        /// الموعد
        /// </summary>
        public Time time { get; set; } = new Time();
        /// <summary>
        /// المدة الزمنبة
        /// </summary>
        public Period period { get; set; } = new Period();
        public int ID { get; set; } = 0;
        public int Price { get; set; } = 0;
        /// <summary>
        /// مكان الكورس
        /// </summary>
        public string Place { get; set; } = "";
        /// <summary>
        /// اسم الكورس
        /// </summary>
        public string Name { get; set; } = "";
    }
}
