# Part 03 — List search · Yield

Refactor the starters below. Fill `Answers.md`.

## Run

```bash
cd part-03
dotnet run
```

## A) List search

Code: `ListSearch/BlockedUserChecker.cs`

**Task:**

1. Calculate the **time complexity** of `CountBlocked` (before refactor).
2. Refactor to improve it.
3. Measure again and calculate the **time complexity after** refactor.
4. Record before/after times from `dotnet run` (or your own timing).

---

## B) Yield — 1,000,000 students

Code: `Yield/StudentCatalog.cs` + the loop in `Program.cs`

**Task:** Refactor so generating / walking 1,000,000 students does not force building the full list when the caller stops early. Use **yield**.

---

## Hand-in

Fill `Answers.md`.
