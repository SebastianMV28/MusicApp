﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Track
    {
        private int _id;
        private string _title;
        private TimeOnly _duration;
        private Artist _artist;
        private Album _album;
        
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public TimeOnly Duration { get => _duration; set => _duration = value; }
        public Artist Artist { get => _artist; set => _artist = value; }
        public Album Album { get => _album; set => _album = value; }
        
        public Track (JObject valueObject)
        {
            var track = valueObject["Track"].ToObject<JObject>();
            var jObjectAlbum = valueObject["Album"].ToObject<JObject>();
            var jObjectArtist = valueObject["Artist"].ToObject<JObject>();
            var artistObject = new Artist(jObjectArtist);
            var albumObject= new Album(jObjectAlbum);
            Id = (int)valueObject["id"];
            Title = (string)valueObject["Title"];
            Artist= artistObject;
            Album= albumObject;
            //Duration = (TimeOnly)(int)valueObject["Duration"];

        }

        public Track(string title, TimeOnly duration ) 
        {
            _title = title;
            _duration = duration;
        }
        public Track(string title, Artist artist, Album album) 
        {
            _title = title;
            _artist = artist;
            _album = album;
        }
    }
}
