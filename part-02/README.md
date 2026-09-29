# Part 02 — Template Method · Facade

Implement the refactors below. Fill `Answers.md`.

## Run

```bash
cd part-02
dotnet run
```

## A) Template Method

Code: `TemplateMethod/CsvReportExporter.cs`, `JsonReportExporter.cs`, `TextReportExporter.cs`

**Task:** Refactor the duplicated export flow into an abstract base class.

Requirements:

- Public template method is **non-virtual**
- Steps are **abstract**
- Optional hooks are **virtual** (only if you need them)

**Written question:** Why is an abstract class better than an interface here?

---

## B) Facade

Code: `Facade/Services.cs` + the enrollment calls in `Program.cs`

**Task:** Refactor the enrollment flow to use the **Facade** design pattern (`EnrollmentFacade`).

Requirements:

- Hide `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService` behind the facade
- Call them in the correct order from one place
- Pass dependencies through the facade **constructor** (DIP)

**Written question:** What type of Facade did you implement? (brief)

---

## Hand-in

Fill `Answers.md`.
