namespace LibraryManagementSystem
{
    public sealed class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
    }
}