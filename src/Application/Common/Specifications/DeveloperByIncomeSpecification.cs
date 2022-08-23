using Domain.Entities;

namespace Application.Common.Specifications
{
    public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperByIncomeSpecification()
        {
            AddOrderByDescending(x => x.EstimatedIncome);
        }
    }
}
