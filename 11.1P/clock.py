from counter import Counter


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
        self.hours.Reset()
        self.minutes.Reset()
        self.seconds.Reset()

    @property
    def Time(self):
        return str(self.hours.Tick).zfill(2) + ":" + str(self.minutes.Tick).zfill(2) + ":" + str(
            self.seconds.Tick).zfill(2)