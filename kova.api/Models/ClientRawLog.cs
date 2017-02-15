using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class ClientRawLog
    {
        public DateTime DateTime { get; set; }
        public int? ActualSolarReading { get; set; }
        public double? ApparentTemperature { get; set; }
        public int? AverageWindDirection { get; set; }
        public double? AverageWindSpeed { get; set; }
        public double? Barometer { get; set; }
        public double? BaroTrend { get; set; }
        public double? CloudHeight { get; set; }
        public double? CurrentHumidexValue { get; set; }
        public double? CurrentWindChill { get; set; }
        public double? DailyRainfall { get; set; }
        public double? DavisVpuv { get; set; }
        public double? DewPointTemperature { get; set; }
        public double? Gust { get; set; }
        public double? HeatIndexValue { get; set; }
        public int? IndoorHumidity { get; set; }
        public double? IndoorTemperature { get; set; }
        public double? MaxApparentTemperature { get; set; }
        public double? MaxAverageWindSpeed { get; set; }
        public double? MaxBarometer { get; set; }
        public double? MaxDewPoint { get; set; }
        public int? MaxGustLastHour { get; set; }
        public int? MaxGustLastMinute { get; set; }
        public double? MaxHeatIndex { get; set; }
        public double? MaximumDailyTemperature { get; set; }
        public double? MaximumGustForTheDay { get; set; }
        public double? MaximumHumidex { get; set; }
        public double? MaximumWindchill { get; set; }
        public double? MaxIndoorTemperature { get; set; }
        public double? MaxRainRate { get; set; }
        public double? MinApparentTemperature { get; set; }
        public double? MinBarometer { get; set; }
        public double? MinDewPoint { get; set; }
        public double? MinHeatIndex { get; set; }
        public double? MinimumDailyTemperature { get; set; }
        public double? MinimumHumidex { get; set; }
        public double? MinimumWindchill { get; set; }
        public double? MinIndoorTemperature { get; set; }
        public double? MonthlyRainfall { get; set; }
        public int? OutdoorHumidity { get; set; }
        public double? RainRate { get; set; }
        public string StationName { get; set; }
        public double? Temperature { get; set; }
        public int? WindDirection { get; set; }
        public double? YearlyRainfall { get; set; }
        public double? YesterdayRainfall { get; set; }
        public string RawData { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
