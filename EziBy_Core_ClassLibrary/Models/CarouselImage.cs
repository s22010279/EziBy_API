﻿namespace EziBy_Core_ClassLibrary.Models
{
    public class CarouselImage
    {
        public int CarouselId { get; set; }
        public string CarouselDetails { get; set; } = string.Empty;
        public string CarouselImageName { get; set; } = string.Empty;
        public string CarouselLink { get; set; } = string.Empty;
        public string CarouselType { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
    }
}
