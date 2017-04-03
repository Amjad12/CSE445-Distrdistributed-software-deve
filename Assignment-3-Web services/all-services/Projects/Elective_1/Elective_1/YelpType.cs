﻿// The initial file was created by by Xamasoft JSON Class Generator http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Elective_1
{
    public class Span
    {

        [JsonProperty("latitude_delta")]
        public double LatitudeDelta { get; set; }

        [JsonProperty("longitude_delta")]
        public double LongitudeDelta { get; set; }
    }

    public class Center
    {

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class Region
    {

        [JsonProperty("span")]
        public Span Span { get; set; }

        [JsonProperty("center")]
        public Center Center { get; set; }
    }

    public class Coordinate
    {

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class YelpLocation
    {

        [JsonProperty("cross_streets")]
        public string CrossStreets { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("display_address")]
        public string[] DisplayAddress { get; set; }

        [JsonProperty("geo_accuracy")]
        public double GeoAccuracy { get; set; }

        [JsonProperty("neighborhoods")]
        public string[] Neighborhoods { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("address")]
        public string[] Address { get; set; }

        [JsonProperty("coordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }
    }

    public class Business
    {

        //[JsonProperty("is_claimed")]
        //public bool IsClaimed { get; set; }

        //[JsonProperty("rating")]
        //public string Rating { get; set; }

        //[JsonProperty("mobile_url")]
        //public string MobileUrl { get; set; }

        //[JsonProperty("rating_img_url")]
        //public string RatingImgUrl { get; set; }

        //[JsonProperty("review_count")]
        //public string ReviewCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("rating_img_url_small")]
        //public string RatingImgUrlSmall { get; set; }

        //[JsonProperty("url")]
        //public string Url { get; set; }

        //[JsonProperty("categories")]
        //public string[][] Categories { get; set; }

        //[JsonProperty("menu_date_updated")]
        //public string MenuDateUpdated { get; set; }

        //[JsonProperty("phone")]
        //public string Phone { get; set; }

        //[JsonProperty("snippet_text")]
        //public string SnippetText { get; set; }

        //[JsonProperty("image_url")]
        //public string ImageUrl { get; set; }

        //[JsonProperty("snippet_image_url")]
        //public string SnippetImageUrl { get; set; }

        [JsonProperty("display_phone")]
        public string DisplayPhone { get; set; }

        //[JsonProperty("rating_img_url_large")]
        //public string RatingImgUrlLarge { get; set; }

        //[JsonProperty("menu_provider")]
        //public string MenuProvider { get; set; }

        //[JsonProperty("id")]
        //public string Id { get; set; }

        //[JsonProperty("is_closed")]
        //public bool IsClosed { get; set; }

        [JsonProperty("location")]
        public YelpLocation Location { get; set; }
    }

    public class YelpPlaces
    {

        //[JsonProperty("region")]
        //public Region Region { get; set; }

        //[JsonProperty("total")]
        //public int Total { get; set; }

        [JsonProperty("businesses")]
        public Business[] Businesses { get; set; }
    }

}