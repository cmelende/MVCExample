namespace MVCExample.Models
{
    public class HomePageModel
    {
        public string Header => "MVC Example";
        public string MainParagraph =>
            "MVC Example showing off RenderAction, RenderPartial, Partial, & Action";
        
        public string PartialViewHeader => "Partial View";
        public string PartialViewParagraph => "This uses the same model as the parent view, we can either write it directly into the http response or we can render the view, save it to a variable and use it later";
    }
}