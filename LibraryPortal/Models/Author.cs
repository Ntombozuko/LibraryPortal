namespace LibraryPortal.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname
        {
            get { return Name + " " + Surname; }
        }
    }
}
