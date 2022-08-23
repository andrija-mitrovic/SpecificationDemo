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
        }
    }
}
