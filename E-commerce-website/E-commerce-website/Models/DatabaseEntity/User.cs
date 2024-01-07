namespace E_commerce_website.Models.DatabaseEntity
{
    public class User
    {
        //使用者編號
        public int Id { get; set; }

        //使用者名稱
        public string Name { get; set; }

        //使用者信箱
        public string Email { get; set; }

        //使用者密碼
        public string Password { get; set; }
    }
}
