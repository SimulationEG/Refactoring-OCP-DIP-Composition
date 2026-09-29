# Part 03 — Performance · Large data

Refactor the starters below. Fill `Answers.md`.

## Run

```bash
cd part-03
dotnet run
```

## A) Blocked users

Code: `BlockedUsers/BlockedUserChecker.cs`

**Task:**

1. Calculate the **time complexity** of `CountBlocked` (before refactor).
2. Refactor to improve it.
3. Measure again and calculate the **time complexity after** refactor.
4. Record before/after times from `dotnet run` (or your own timing).

---

## B) Students — 1,000,000 records

Code: `Students/StudentCatalog.cs` + the loop in `Program.cs`

**Task:** Refactor so generating / walking 1,000,000 students does not force building the full list when the caller stops early.

---

## Hand-in

Fill `Answers.md`.
