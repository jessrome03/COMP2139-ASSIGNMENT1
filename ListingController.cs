public class ListingsController : Controller
{
    private readonly IListingService _listingService;

    public ListingsController(IListingService listingService)
    {
        _listingService = listingService;
    }

    public IActionResult Index()
    {
        // Implement logic to display available listings
        var allListings = _listingService.GetAllListings();
        return View(allListings);
    }

    public IActionResult Details(int listingId)
    {
        // Fetch listing details from the database based on listingId
        var listing = _listingService.GetListingById(listingId);
        return View(listing);
    }

    [HttpGet]
    public IActionResult Manage()
    {
        // Fetch listings for the logged-in user
        var clientListings = _listingService.GetClientListings(User.Identity.Name);
        return View(clientListings);
    }

    [HttpGet]
    public IActionResult Create()
    {
        // Display the form for creating a new listing
        return View();
    }

    [HttpPost]
    public IActionResult Create(Listing model)
    {
        // Process the form submission, validate data, and store in the database
        _listingService.CreateListing(model, User.Identity.Name);
        return RedirectToAction("Manage");
    }

    [HttpGet]
    public IActionResult Edit(int listingId)
    {
        // Fetch listing details for editing
        var listing = _listingService.GetListingById(listingId);
        return View(listing);
    }

    [HttpPost]
    public IActionResult Edit(Listing model)
    {
        // Process the form submission, validate data, and update in the database
        _listingService.UpdateListing(model);
        return RedirectToAction("Manage");
    }

    [HttpPost]
    public IActionResult Delete(int listingId)
    {
        // Delete the listing based on listingId
        _listingService.DeleteListing(listingId);
        return RedirectToAction("Manage");
    }
}