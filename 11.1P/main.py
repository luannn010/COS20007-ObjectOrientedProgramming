from Clock import Clock
# Main
if __name__ == "__main__":
    # Create new Clock
    myClock = Clock()
    i = 0
    #Loop for a Day
    while i < 86400:
        myClock.Tick()
        print(myClock.Time)
        i +=1