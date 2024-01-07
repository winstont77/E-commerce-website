namespace E_commerce_website.Models.DatabaseEntity
{
    public class Product
    {
        //產品編號
        public int Id { get; set; }

        //產品項目
        public string Category { get; set; }

        //產品名稱
        public string Title { get; set; }

        //產品描述
        public string Description { get; set; }

        //產品價格
        public string Price { get; set; }

        //產品質地
        public string Texture { get; set; }

        //產品是否可水洗
        public string Wash { get; set; }

        //產品產地
        public string Place { get; set; }

        //產品顏色
        public string Color { get; set; }

        //產品尺寸
        public string Size { get; set; }

        //產品數量
        public int Variant { get; set; }

        //產品圖片
        public string image { get; set; }
    }
}
