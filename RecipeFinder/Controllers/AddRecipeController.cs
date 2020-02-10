using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeFinder.Controllers
{
    public class AddRecipeController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index()
        {
           
            string html = "<form method='post'>" +
                "<h1> Add Recipe</h1><br>" + 
                "Name:<input type = 'text' name='Name of Recipe:'/><br>" +
                "Ingredient 1:<input type = 'text' name='Ingredient' /><br>" +
                "Ingredient 2:<input type = 'text' name='Ingredient' /><br>" +
                "Ingredient 3:<input type = 'text' name='Ingredient' /><br>" +
                "Add Recipe: <input type = 'text' name='Recipe' /><br>" +
                "<input type = 'submit' value='Add Recipe' />" +
                "</form>";
                
            
            return Content( html, "text/html");
        }
    }
}
