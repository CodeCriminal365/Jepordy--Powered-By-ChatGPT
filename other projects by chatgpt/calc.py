import sys

# Take input from the user
num1 = float(input("Enter the first number: "))
num2 = float(input("Enter the second number: "))
operator = input("Enter the operator (+, -, *, /): ")

# Perform the calculation based on the operator
if operator == "+":
    result = num1 + num2
elif operator == "-":
    result = num1 - num2
elif operator == "*":
    result = num1 * num2
elif operator == "/":
    if num2 == 0:
        print("Error: division by zero")
        sys.exit()
    result = num1 / num2
else:
    print("Invalid operator")
    sys.exit()

# Print the result
print("Result: ", result)
