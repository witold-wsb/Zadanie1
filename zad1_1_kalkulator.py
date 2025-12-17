print("Simple calculator")
x = int(input("Enter the 1st number: "))
y = int(input("Enter the 2nd number: "))
op  = input("Enter the operand: ")
if op == "+":
    print(x + y)
elif op == "-":
    print(x - y)
elif op == "*":
    print(x * y)
elif op == "/":
    #if y = 0:
    #    print("Cannot divide by zero!")
    print(x / y)
else:
    print("Unknown operand")
