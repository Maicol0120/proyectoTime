using System;

public class Time
{
    private int hour;
    private int minute;
    private int second;
    private int millisecond;

    // 1) Sin parámetros
    public Time() : this(0, 0, 0, 0) { }

    // 2) Solo horas
    public Time(int hour) : this(hour, 0, 0, 0) { }

    // 3) Horas y minutos
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }

    // 4) Horas, minutos y segundos
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }

    // 5) Horas, minutos, segundos y milisegundos
    public Time(int hour, int minute, int second, int millisecond)
    {
        if (hour < 0 || hour > 23)
            throw new ArgumentException($"The hour: {hour}, is not valid.");

        if (minute < 0 || minute > 59)
            throw new ArgumentException($"The minute: {minute}, is not valid.");

        if (second < 0 || second > 59)
            throw new ArgumentException($"The second: {second}, is not valid.");

        if (millisecond < 0 || millisecond > 999)
            throw new ArgumentException($"The millisecond: {millisecond}, is not valid.");

        this.hour = hour;
        this.minute = minute;
        this.second = second;
        this.millisecond = millisecond;
    }

    public override string ToString()
    {
        return $"{hour:D2}:{minute:D2}:{second:D2}.{millisecond:D3}";
    }
}
