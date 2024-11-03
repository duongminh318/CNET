namespace DemoApp.Domain.Models.Commons
{
    public class SearchQuery
    {
        private int pageIndex;

        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                if (value <= 0)
                {
                    pageIndex = 1;
                }
                else
                {
                    pageIndex = value;
                }

            }
        }
        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set
            {
                if (value <= 0)
                {
                    pageSize = 9;
                }
                else
                {
                    pageSize = value;
                }



            }
        }

        public string Keyword { get; set; }

        public int SkipNo => (PageIndex - 1) * PageSize;
        public int TakeNo => PageSize;
        public bool DisplayActiveItem { get; set; }
    }
}
