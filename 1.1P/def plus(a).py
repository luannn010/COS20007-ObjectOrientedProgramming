def main():
    ar = input('Input the array of numbers that you want to count the average (separate the numbers by spaces): ')
    ar = Convert(ar)
    ar = Average(ar)
    print('The result is:', ar)

# Convert to list of floats
def Convert(i):
    i = list(map(float, i.split()))
    return i

# Average function
def Average(x):
    if len(x) == 0:
        return 0
    else:
        total = sum(x)
        return total / len(x)

main()
