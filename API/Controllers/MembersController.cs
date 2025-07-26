using API.Data;
using API.Entities;
using API.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class MembersController(IMemberRepository memberRepository) : BaseApiController // localhost:5001/api/members
    {
        // GET: api/members
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Member>>> GetMembers()
        {
            return Ok(await memberRepository.GetMembersAsync());
        }

        // GET: api/members/5

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(string id)
        {
            var member = await memberRepository.GetMemberByIdAsync(id);
            if (member == null) return NotFound();
            return member;
        }

        [HttpGet("{id}/photos")]
        public async Task <ActionResult<IReadOnlyList<Photo>>> GetMemberPhotos(string id)
        {
            return Ok(await memberRepository.GetPhotoForMembersAsync(id));
        }

        // // POST: api/members
        // [HttpPost]
        // public ActionResult CreateMember([FromBody] string member)
        // {
        //     // Logic to create a new member would go here
        //     return CreatedAtAction(nameof(GetMember), new { id = 1 }, new { Message = "Member created" });
        // }

        // PUT: api/members/5


    }
}
