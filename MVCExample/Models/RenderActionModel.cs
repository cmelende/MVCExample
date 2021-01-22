namespace MVCExample.Models
{
    public class RenderActionModel
    {
        public string Header => "RenderAction";
        public string Paragraph =>
            "Example of using Html.RenderAction, we use it here because the model backing this view is different from the home page and we need the controller to grab the data for us.";
    }
}