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
