namespace pahsolutionsportfolio.Controllers;

using Microsoft.AspNetCore.Mvc;
using pahsolutionsportfolio.Models;
using DatabaseAccess;

public class ContactController(ILogger<ContactController> logger) : Controller
{
    private readonly DatabaseAccess _dbAccess =  new();
    private readonly ILogger<ContactController> _logger = logger;


    [HttpGet]
    public IActionResult Index()
    {
        _logger.LogDebug("Entering '/contact' GET route...");
        ContactViewModel user_input = new();
        return View(user_input);
    }

    [HttpPost]
    public IActionResult Index(ContactViewModel user_input)
    {
        _logger.LogDebug("Entering '/contact' POST route...");

        _logger.LogDebug("Validating model...");
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Error", "Home");
        }
        _logger.LogDebug("Model is valid...");

        _logger.LogDebug("Saving form data to the database with data: {data}", user_input.ToString());
        try {
            _dbAccess.SaveContactFormSubmission(user_input);
        } catch(Exception e) {
            _logger.LogDebug("Error when saving form data to the database with the error: {error}", e.Message);
            return RedirectToAction("Error", "Home");
        }
        _logger.LogDebug("Saved form data to the database with submission...");
        TempData["SuccessMessage"] = "Your submission has been sent successfully!";
        return View(user_input);
    }

    [HttpGet]
    public IActionResult Admin()
    {
        _logger.LogDebug("Entering '/admin_contact' GET route...");
        return View(new ContactAdminViewModel());
    }

    [HttpPost]
    public IActionResult Admin(ContactAdminViewModel user_input, int? id)
    {
        ContactAdminViewModel rtrn = new();
        _logger.LogDebug("Entering '/admin_contact' POST route...");

        if (id.HasValue)
        {

            _logger.LogDebug("Processing delete for ID: {Id}", id.Value);
            _dbAccess.DeleteContactFormSubmission(id.Value);
            return View(rtrn);
        }

        
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Error", "Home");
        }
        _logger.LogDebug("Model is valid...");

        if (user_input.Password != Environment.GetEnvironmentVariable("MASTER_PASSWORD")) {
            _logger.LogDebug("Incorrect password...");
            return RedirectToAction("Error", "Home");
        } else {
            _logger.LogDebug("Correct password...");
            rtrn.Authenticated = true;
        }
        
        _logger.LogDebug("Fetching all form submissions...");
        rtrn.ListData  = _dbAccess.GetContactFormSubmission();
        _logger.LogDebug("Fetched all form submissions...");

        return View(rtrn);
    }
}
