﻿using System;
using System.Collections.Generic;
using System.Text;

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using GopherTrip.API;
//
//    var routes = Routes.FromJson(jsonString);

namespace GopherTrip.API
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Routes
    {
        [JsonProperty("route")]
        public List<Route> Route { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Route
    {
        [JsonProperty("LastETACalc")]
        public long LastEtaCalc { get; set; }

        [JsonProperty("agencyID")]
        public long AgencyId { get; set; }

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("calcETA")]
        public long CalcEta { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deleted")]
        public object Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("disabled")]
        public long Disabled { get; set; }

        [JsonProperty("hidden")]
        public long Hidden { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("onDemand")]
        public long OnDemand { get; set; }

        [JsonProperty("routeCode")]
        public string RouteCode { get; set; }

        [JsonProperty("routeID")]
        public long RouteId { get; set; }

        [JsonProperty("routeType")]
        public long RouteType { get; set; }

        [JsonProperty("schedAdh")]
        public long SchedAdh { get; set; }

        [JsonProperty("scheduleURL")]
        public string ScheduleUrl { get; set; }

        [JsonProperty("scheduleURLType")]
        public string ScheduleUrlType { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("shapeID")]
        public long ShapeId { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("special_service")]
        public long SpecialService { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("updated")]
        public DateTimeOffset Updated { get; set; }
    }

    public partial class Routes
    {
        public static Routes FromJson(string json) => JsonConvert.DeserializeObject<Routes>(json, GopherTrip.API.Converter.Settings);
    }
}

