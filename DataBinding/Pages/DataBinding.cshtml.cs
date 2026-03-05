using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataBinding.Pages.Shared
{
    public class DataBindingModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }
        public static List<Person> People { get; set; } = new List<Person>();
        public string Result { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Person != null)
            {
                People.Add(Person);
                Result = $"Added {Person.Name}, Age: {Person.Age}, Address: {Person.Address}";
            }
        }
    }
}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}
