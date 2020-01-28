using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PolygonMap.Domain.ApiModels
{
    public class PolygonApiModel
    {

       
        public int PolygonID { get; set; }
        [Required]
        public int ShapeID { get; set; }
        public string Name { get; set; }
        // point where user click on the map; will be as center point. 
        [Required]
        public float RealLongitude { get; set; }
        [Required]
        public float RealLatitude { get; set; }
        public string Points { get; set; }

     //   public ShapeApiModel Shape { get; set; }
    }
}
