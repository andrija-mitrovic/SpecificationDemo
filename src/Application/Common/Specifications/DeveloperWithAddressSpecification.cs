using Domain.Entities;

namespace Application.Common.Specifications
{
    public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithAddressSpecification(int years, int salary) : 
            base(x => x.EstimatedIncome > salary && x.YearsOfExperience >= years)
        {
            AddInclude(x => x.Address);
            AddInclude(x => x.Technologies);
            AddInclude($"{nameof(Developer.Technologies)}.{nameof(Technology.Producer)}"); //.ThenInclude()
            //AddInclude("Technologies.Producer");
        }
    }
}
