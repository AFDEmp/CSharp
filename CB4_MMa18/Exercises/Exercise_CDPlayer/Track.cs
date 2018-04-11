using System;

namespace Exercise_CDPlayer
{
    class Track
    {
        public string Title { get; set; }
        
        private int _durationInSeconds;
        public int DurationInSeconds
        {
            get { return _durationInSeconds; }
            set 
            {
                if (value <= 0) {
                    throw new Exception("Duration cannot be zero or negative");
                }
                _durationInSeconds = value;
            } 
        }

        public Track(int duration) {
            Title = "Untitled";
            DurationInSeconds = duration;
        }

        public Track(string title, int duration) 
        {
            Title = title;
            DurationInSeconds = duration;
        }
        
        public string DurationInMinutes() {
            int minutes = DurationInSeconds / 60;
            int seconds = DurationInSeconds % 60;
            return $"{minutes}:{seconds}";
        }

        public override string ToString() {
            return $"{Title} - {DurationInMinutes()}";
        }
    }
}