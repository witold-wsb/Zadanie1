print("Średnia ocen ucznia")
n = int(input("Ile uczeń ma ocen? "))
total = 0

for i in range(n):
    temp = int(input("Podaj ocenę: "))
    total += temp

avg = total / n
print(f"Średnia: {avg}")

if avg >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał")