print("Prosty kalkulator")
x = int(input("Wprowadź pierwszą liczbę: "))
y = int(input("Wprowadź drugą liczbę: "))
op  = input("Wprowadź operator: ")
if op == "+":
    print(f"Wynik: {x + y}")
elif op == "-":
    print(f"Wynik: {x - y}")
elif op == "*":
    print(f"Wynik: {x * y}")
elif op == "/":
    if y == 0:
        print("Nie można dzielić przez zero!")
    else:
        print(f"Wynik: {x / y}")
else:
    print("Nieznany operator.")
