using Microsoft.AspNetCore.Mvc;

namespace GiftingApi.Controllers
{
    public class PeopleController : ControllerBase
    {

        //GET /people
        [HttpGet("/people")]
        public async Task<ActionResult> GetAllPeople()
        {
            var people = new List<PersonItemResponse>()
            {
                new PersonItemResponse("1", "Bill", "Hulley"),
                new PersonItemResponse("2", "Mark", "Beebe")
            };
            var response = new PersonResponse(people);
            return Ok(response);
        }
    }
}
