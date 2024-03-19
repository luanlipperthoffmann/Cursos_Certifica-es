using Microsoft.AspNetCore.Mvc;

namespace Cloud_Storage.API.Properties;

public class StorageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}