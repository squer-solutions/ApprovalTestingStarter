using Squer.Workshops.ApprovalTesting.Production;
using VerifyXunit;

namespace Squer.Workshops.ApprovalTesting.Tests;

[UsesVerify]
public class PersonFinderApprovalTests
{
    [Fact]
    public Task TestPersonFinder()
    {
        // Act
        var person = PersonFinder.FindPerson();
        
        return Verify(person);
    }
}