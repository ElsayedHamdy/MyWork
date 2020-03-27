using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public interface ISaveSections
    {
        void SaveSections(Section section);
    }
    public interface ISaveBooks
    {
        void SaveBooks(Book book);
    }
    public interface ISaveLectures
    {
        void SaveLectures(Lecture lecture);
    }
    public interface IExitAddNewCourse
    {
        void ExitAddNewCourse(Course course);
    }
    public interface IExitAddNewMaterial
    {
        void ExitAddNewMaterial(Material material);
    }
    public interface IExitAddNewInstructor
    {
        void ExitAddNewInstructor(Instructor instructor);
    }
    public enum Days
    {
        None = 0,
        Friday = 1,
        Saturday = 2,
        Sunday = 3,
        Monday = 4,
        Tuesday = 5,
        Wednesday = 6,
        Thursday = 7,
    }
    public enum TimeFormat
    {
        None,PM, AM
    }
    public struct Time
    {
        public Time(int hour, int minute, int second, TimeFormat timeFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeFormat = timeFormat;
        }
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }
        public TimeFormat TimeFormat { get; private set; }
        public override string ToString()
        {
            return $"{Hour}:{Minute}:{Second} {TimeFormat.ToString()}";
        }
        public static implicit operator Time(string _time)
        {
            _time.Trim();
            TimeFormat timeFormat= Convert.ToTimeFormat(_time.Substring(_time.Length - 2));
            _time=_time.Remove(_time.Length - 2);
            string [] arr=_time.Split(':');
            Time time = new Time(int.Parse(arr[0]),int.Parse(arr[1]),int.Parse(arr[2]),timeFormat);
            return time;
        }
    }
    public struct Period
    {
        public Period(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public static implicit operator Period(string _period)
        {
            _period.Trim(' ');
            string[] arr = _period.Split(':');
            Period period = new Period(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
            return period;
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
    public enum Type
    {
        None, DR, ENG, PROF
    }     
    public static class Convert
    {
        public static Type ToType(string value)
        {
            value = value.ToLower();
            switch (value)
            {
                case "dr":
                    return Type.DR;
                case "eng":
                    return Type.ENG;
                case "prof":
                    return Type.PROF;
                default:
                    return Type.None;
            }
        }
        public static bool Equal(object[]list1,object[]list2)
        {
            if(list1.Length == list2.Length)
            {
                Array.Sort(list1);
                Array.Sort(list2);
                for (int i = 0; i < list1.Length; i++)
                {
                    if (list1[i].Equals(list2[i])) ;
                    else return false;
                }
                return true;
            }
            return false;
        }
        public static TimeFormat ToTimeFormat(string value)
        {
            value = value.ToLower();
            switch (value)
            {
                case "pm":
                    return TimeFormat.PM;
                case "am":
                    return TimeFormat.AM;
                default:
                    return TimeFormat.None;
            }
        }
        public static Days ToDays(string value)
        {
            value = value.ToLower();
            switch (value)
            {
                case "friday":
                    return Days.Friday;
                case "saturday":
                    return Days.Saturday;
                case "sunday":
                    return Days.Sunday;
                case "monday":
                    return Days.Monday;
                case "tuesday":
                    return Days.Tuesday;
                case "wednesday":
                    return Days.Wednesday;
                case "thursday":
                    return Days.Thursday;
                default:
                    return Days.None;
            }
        }
    }
}


