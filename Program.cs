using RefactoringLab;

Console.WriteLine("=== Broken starter (refactor this) ===");
Console.WriteLine();

// OCP
var shipping = new ShippingCostCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
Console.WriteLine();

// DIP
var processor = new OrderProcessor();
processor.Process(1001, "customer@example.com");
Console.WriteLine();

// Composition / inheritance explosion
new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
    .Send("customer@example.com", "Your order ships tomorrow");
new UrgentSmsNotification()
    .Send("+201000000000", "OTP 4821");
