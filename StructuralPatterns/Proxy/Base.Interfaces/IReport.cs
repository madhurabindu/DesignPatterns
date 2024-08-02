using System;

namespace Base.Interfaces
{
    public interface IReport
    {
        string ProductName { get;  }
        string AverageWeeklySalesRevenue { get;  }
        string ProfitYTD { get; }
        string PercentageOppToSales { get;  }
    }
}
