namespace E_commerce_website.Models.DatabaseEntity
{
    public class Order
    {
        //訂單編號
        public int Id { get; set; }

        //買家名稱
        public string UserName { get; set; }

        //總金額
        public int TotalPrice { get; set; }
    }
}
