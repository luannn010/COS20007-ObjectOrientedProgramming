# Import the Counter from Counter
from Counter import Counter

# Inherit from Counter
class Clock:

    def __init__(self):
        self.seconds = Counter(name="seconds")
        self.minutes = Counter(name="minutes")
        self.hours = Counter(name="hours")
    # Function
    def Tick(self):
        self.seconds.Increment()
        if self.seconds.Ticks == 60:
            self.seconds.Reset()
            self.minutes.Increment()

        if self.minutes.Ticks == 60:
            self.minutes.Reset()
            self.hours.Ticks

        if self.hours.Ticks == 24:
            self.hours.Reset()
    def Reset(self):
        self.seconds.Reset()
        self.minutes.Reset()
        self.hours.Reset()
    # Property
    @property
    def Time(self):
        return f"{str(self.hours.Ticks).zfill(2)} : {str(self.minutes.Ticks).zfill(2)} : {str(self.seconds.Ticks).zfill(2)}"
