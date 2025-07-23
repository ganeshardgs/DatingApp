using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    
    public class MembersController(AppDbContext context) : BaseApiController // localhost:5001/api/members
    {
        // GET: api/members
        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetMembers()
        {
            var members = await context.Users.ToListAsync();
            if (members == null) return NotFound();
            return members;
        }

        // GET: api/members/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetMember(string id)
        {
            var member = await context.Users.FindAsync(id);
            if (member == null) return NotFound();
            return member;
        }

        // // POST: api/members
        // [HttpPost]
        // public ActionResult CreateMember([FromBody] string member)
        // {
        //     // Logic to create a new member would go here
        //     return CreatedAtAction(nameof(GetMember), new { id = 1 }, new { Message = "Member created" });
        // }

        // // PUT: api/members/5
        // [HttpPut("{id}")]
        // public ActionResult UpdateMember(int id, [FromBody] string member)
        // {
        //     var member1 = context.Users.Find(id);
        //     if (member1 == null) return NotFound();
        //     context.Users.Update(member);
        //     return NoContent();
        // }

        // DELETE: api/members/5
        [HttpDelete("{id}")]
        public ActionResult DeleteMember(string id)
        {
            var member = context.Users.Find(id);
            if (member == null) return NotFound();
            context.Users.Remove(member);
            return NoContent();
        }
    }
}
