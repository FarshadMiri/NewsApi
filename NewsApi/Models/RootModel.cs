namespace NewsApi.Models
{
    public class RootModel
    {
        
       public string status { get; set; }
       public int totalResults { get; set; }
       public List<ArticleModel> articles { get; set; }
        
    }
}
