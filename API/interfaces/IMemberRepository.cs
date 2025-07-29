using System;
using API.Entities;

namespace API.interfaces;

public interface IMemberRepository
{
    void Update(Member member);
    Task<bool> saveAllChanges();
    Task<IReadOnlyList<Member>> GetMembersAsync();
    Task<Member?> GetMemberByIdAsync(string id);
    Task<IReadOnlyList<Photo>> GetPhotoForMembersAsync(string memberId);
    Task<Member?> GetMemberForUpdate(string id);

}
