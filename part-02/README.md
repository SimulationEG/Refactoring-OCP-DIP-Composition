# Part 02 — Reports · Enrollment

Implement the refactors below. Fill `Answers.md`.

## Run

```bash
cd part-02
dotnet run
```

## A) Reports

Code: `Reports/CsvReportExporter.cs`, `JsonReportExporter.cs`, `TextReportExporter.cs`

**Task:** Refactor the duplicated export flow into an abstract base class.

Requirements:

- Public template method is **non-virtual**
- Steps are **abstract**
- Optional hooks are **virtual** (only if you need them)

**Written question:** Why is an abstract class better than an interface here?

---

## B) Enrollment

Code: `Enrollment/Services.cs` + the enrollment calls in `Program.cs`

**Task:** Refactor the enrollment flow so callers do not wire `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService` themselves.

Requirements:

- One entry type that runs the flow in the correct order
- Pass dependencies through the constructor

**Written question:** Which design pattern did you use, and what type/variant is it? (brief)

---

## Hand-in

Fill `Answers.md`.
