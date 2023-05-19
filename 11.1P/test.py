class Counter:
    def __init__(self, name):
        self._name = name
        self._count = 0
    
    def Increment(self):
        self._count += 1
    
    def Reset(self):
        self._count = 0
    
    @property
    def Name(self):
        return self._name
    
    @Name.setter
    def Name(self, value):
        self._name = value
    
    @property
    def Ticks(self):
        return self._count
# Inherit from Counter
# Import the Counter from Counter


# Inherit from Counter
class Clock:

    def __init__(self):
        self._seconds = Counter(name="seconds")
        self._minutes = Counter(name="minutes")
        self._hours = Counter(name="hours")
    # Function
    def Tick(self):
        self._seconds.Increment()
        if self._seconds.Ticks == 60:
            self._seconds.Reset()
            self._minutes.Increment()

        if self._minutes.Ticks == 60:
            self._minutes.Reset()
            self._hours.Increment()

        if self._hours.Ticks == 24:
            self._hours.Reset()

    def Reset(self):
        self._seconds.Reset()
        self._minutes.Reset()
        self._hours.Reset()

    # Property
    @property
    def Time(self):
        return f"{str(self.hours.Ticks).zfill(2)} : {str(self.minutes.Ticks).zfill(2)} : {str(self.seconds.Ticks).zfill(2)}"

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