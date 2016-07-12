﻿using System;
using System.Collections.Generic;

namespace Quandl.Shared.Models
{
    public class OldDataset
    {
        public int Id { get; set; }
        public string DatasetCode { get; set; }
        public string DatabaseCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RefreshedAt { get; set; }
        public string NewestAvailableDate { get; set; }
        public string OldestAvailableDate { get; set; }
        public List<string> ColumnNames { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
        public bool Premium { get; set; }
        public int DatabaseId { get; set; }
    }
}