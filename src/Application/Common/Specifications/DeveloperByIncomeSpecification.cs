using Domain.Entities;

namespace Application.Common.Specifications
{
    public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperByIncomeSpecification()
        {
            //OrderByDescending(x => x.EstimatedIncome);
        }
    }
}
