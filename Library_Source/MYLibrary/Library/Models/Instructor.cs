namespace Library.Models
{
   public class Instructor
    {
        public Type type { get; set; } = new Type();
        /// <summary>
        /// الاسم الاول
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// الاسم الثانى
        /// </summary>
        public string LastName { get; set; } = "";
        /// <summary>
        /// الايمل
        /// </summary>
        public string Email { get; set; } = "";
        /// <summary>
        /// التليفون
        /// </summary>
        public string Phone { get; set; } = "";
        /// <summary>
        /// الترتيب
        /// </summary>
        public int ID { get;  set; } = 0;
        
        public string FullName
        {
            get { return $"{type}:{FirstName} {LastName}"; }
        }

    } 
}
