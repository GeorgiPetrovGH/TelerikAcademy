namespace TradeCompany
{
    using System;    

    public class Article : IComparable<Article>
    {
        public Article(string title, decimal price, string vendor, string barcode)
        {
            this.Title = title;
            this.Price = price;
            this.Vendor = vendor;
            this.Barcode = barcode;
        }

        public decimal Price { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
