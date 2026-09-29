# Refactoring — student answers

Fill this after you refactor. Keep each answer short.

---

## 1) `ShippingCostCalculator`

- Violated principle:
- What change would have forced edits before?
- How does your fix prevent that?

---

## 2) `OrderProcessor` (+ `SqlOrderRepository` / `SmtpEmailSender`)

- Violated principle:
- What change would have forced edits before?
- How does your fix prevent that?
- What did you do about `DateTime.Now`?

---

## 3) Notification hierarchy (`EmailNotification`, `Urgent…`, `UrgentScheduled…`)

- Violated principle / design smell:
- What change would have forced edits (or new subclasses) before?
- How does composition fix that?

---

## 4) Proof task

- New carrier name + file(s) added:
- New notification channel name + file(s) added:
- Confirm: you did **not** edit existing classes to add them (yes/no):
