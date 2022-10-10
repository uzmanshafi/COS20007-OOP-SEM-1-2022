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
    def Tick(self):
        return self._count


class Clock:
    def __init__(self):
        self.hours = Counter("hours")
        self.minutes = Counter("minutes")
        self.seconds = Counter("seconds")

    def Tick(self):
        self.seconds.Increment()
        if self.seconds.Tick > 59:
            self.minutes.Increment()
            self.seconds.Reset()
            if self.minutes.Tick > 59:
                self.hours.Increment()
                self.minutes.Reset()
                if self.hours.Tick > 23:
                    self.Reset()

    def Reset(self):
        self.seconds.Reset()
        self.minutes.Reset()
        self.hours.Reset()

    @property
    def Time(self):
        return str(self.hours.Tick).zfill(2) + ":" + str(self.minutes.Tick).zfill(2) + ":" + str(
            self.seconds.Tick).zfill(2)

clock = Clock()
for x in range(10000):
    clock.Tick()

print('Displays Time as : ', clock.Time)

