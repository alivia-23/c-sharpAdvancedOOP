// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

using System.Diagnostics.CodeAnalysis;
public class Employee {
    public Employee() {}

    public required int ID { get; init; }
    public required string Department { get; set; }

    public required string FullName { get; set; }
    public virtual void AdjustPay(decimal percent) {} 

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

// DEFINE OTHER CLASSES HERE
public class HourlyEmployee : Employee {
    public decimal PayRate { get; set; }

    public HourlyEmployee() {}
    public override void AdjustPay(decimal percent) {
        PayRate += (PayRate * percent);
    }
}

public class SalariedEmployee : Employee {
    public decimal Salary { get; set; }
    public SalariedEmployee() {}

    public override void AdjustPay(decimal percent) {
        Salary += (Salary * percent);
    }
    
}
