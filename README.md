# Refactoring Lab — OCP · DIP · Composition over Inheritance

Starter with **3 broken areas**. Refactor the code. Do not expand this README into notes.

## Run

```bash
dotnet run
```

## Broken code

| File | Smell |
|------|--------|
| `src/ShippingCostCalculator.cs` | `switch` on carrier |
| `src/OrderProcessor.cs` | `new` concrete deps + `DateTime.Now` |
| `src/Notifications.cs` | inheritance explosion (`UrgentScheduled…`) |

## Proof task (required)

After your refactor, you must be able to:

1. Add **one new carrier** without editing any existing class.
2. Add **one new notification channel** without editing any existing class.

Keep those additions in small new files and show them running from `Program.cs`.

## Hand-in

Fill `Refactoring.md` (short answers only).
