namespace BE_Clothing.Models
{
    public class Clothing
    {
        public string? Product_Code { get; set; }
        public string? Name { get; set; }
        public Int32? Price { get; set; }
        public List<string>? Tags { get; set; }
        public string? Path_Image { get; set; }

    }
}
