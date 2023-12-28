using System;


class Program
{
    class Comment
    {
        public int commentId { get; set; }
        public string Text { get; set; } = string.Empty;
    }
    class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
        public Boolean IsApproved { get; set; }

        public Product()
        {
            this.comments = new Comment[3];
            var rnd = (new Random()).Next(11111);
        }
        public Product(int İd) : this()
        {
            ProductId = İd;
        }

        public Product(int Id, string name, double price, bool IsApprove):this(Id)
        {
            /* ProductId = Id; */
            ProductName = name;
            ProductPrice = price;
            IsApproved = IsApprove;
        }

        public Comment[] comments { get; set; }
    }
    static void Main(string[] args)
    {


        Comment yorum = new Comment();
        {
            yorum.commentId = 1;
            yorum.Text = "Güzel Telefon";
        }

        var p1 = new Product();
        p1.comments[0] = yorum;
        Console.WriteLine(p1.comments[0].Text);

        var p2 = new Product(123123);
        p2.comments[0] = yorum;
        Console.WriteLine(p2.comments[0].Text);


        var p3 = new Product(12312, "ali", 500, true);
        p3.comments[0] = yorum;
        Console.WriteLine(p3.ProductId);
        Console.WriteLine(p3.comments[0].Text);
    }
}