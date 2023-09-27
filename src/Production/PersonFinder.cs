using Squer.Workshops.ApprovalTesting.Production.Model;

namespace Squer.Workshops.ApprovalTesting.Production;

public static class PersonFinder
{
    public static Person FindPerson() =>
        new()
        {
            Id = new("ebced679-45d3-4653-8791-3d969c4a986c"),
            Title = Title.Mr,
            GivenNames = "John",
            FamilyName = "Smith",
            Spouse = "Jill",
            Children = new()
            {
                "Sam",
                "Mary"
            },
            Address = new()
            {
                Street = "4 Puddle Lane",
                Country = "USA"
            }
        };
}