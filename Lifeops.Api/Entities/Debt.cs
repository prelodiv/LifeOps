namespace Lifeops.Api.Entities
{
    public class Debt
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Creditor { get; set; } = string.Empty;

        public decimal InitialAmount { get; set; }

        public decimal CurrentBalance { get; set; }

        public decimal MonthlyPayment { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? TargetDate { get; set; }

        public string Status { get; set; } = "Active";

        public string? Notes { get; set; }
    }
}
