def is_armstrong_number(number):
    #Convert the number to a string to access iterate thru its digits
    digits = [int(digit) for digit in str(number)]
    # Armstrong check
    return number == sum(digit ** len(digits) for digit in digits)

