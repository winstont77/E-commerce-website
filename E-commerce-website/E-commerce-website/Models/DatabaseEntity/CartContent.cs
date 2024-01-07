namespace E_commerce_website.Models.DatabaseEntity
{
    public class CartContent
    {
        public int Id { get; set; }
        //對應購物車Id
        public int CartId { get; set; }

        //購買商品名稱
        public string ProductTitle { get; set; }

        //購買數量
        public int Variant { get; set; }
    }
}
