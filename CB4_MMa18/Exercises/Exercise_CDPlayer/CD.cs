using System;
using System.Collections.Generic;

namespace Exercise_CDPlayer
{
    class CD
    {
        public string Title { get; set; }
        
        public List<Track> Tracks { get; private set; }

        public CD(string title, params Track[] tracks) {
            Title = title;
            Tracks = new List<Track>(tracks);

            // manual way of adding tracks to list Tracks
            // for (int i = 0; i < tracks.Length; i++){
            //     Tracks.Add(tracks[i]);
            // }
        }

        public override string ToString()
        {
            string result = "";
            result += $"{Title}\n";
            for (int i = 0; i < Tracks.Count; i++) {
                result += $"{i+1}. {Tracks[i].ToString()}\n";
            }
            return result;
        }
    }
}