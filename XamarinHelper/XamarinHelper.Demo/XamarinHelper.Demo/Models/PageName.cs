namespace XamarinHelper.Demo.Models
{
    class PageName
    {
        public string ShortName { get; set; }

        public string FullName { get; set; }

        public PageName(string shortName, string fullName)
        {
            ShortName = shortName;
            FullName = fullName;
        }
    }
}
