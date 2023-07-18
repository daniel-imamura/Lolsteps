namespace lolsteps_api.Controllers;


[Route("[controller]")]
[ApiController]
public class ChampionsController : Controller
{
    private readonly LolStepsContext _context;

    public ChampionsController(LolStepsContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Champions>> GetAll()
    {
        return _context.Champions.ToList();
    }


}
