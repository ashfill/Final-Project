using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarProject
{


    [MetadataType(typeof(TotalAmountMetaData))]
    public partial class TotalAmount
    {

    }
    public partial class TotalAmountMetaData
    {
        [DisplayName("Make")]
        public int MakeID { get; set; }
        [DisplayName("Model")]
        public int CarModelID { get; set; }
        [DisplayName("Engine")]
        public int EngineID { get; set; }
        [DisplayName("Transmission")]
        public int TransmissionID { get; set; }
        [DisplayName("Turbo")]
        public int TurboID { get; set; }
        [DisplayName("Total Cost")]
        public decimal TotalCost { get; set; }
    }
    [MetadataType(typeof(CarModelMetaData))]
    public partial class CarModel
    {

    }
    public partial class CarModelMetaData
    {
        [DisplayName("Model")]
        public string CarModelName { get; set; }
    }
    [MetadataType(typeof(Engine1MetaData))]
    public partial class Engine1
    {

    }
    public partial class Engine1MetaData
    {
        [DisplayName("Engine")]
        public string EngineName { get; set; }
    }
    [MetadataType(typeof(MakeMetaData))]
    public partial class Make
    {

    }
    public partial class MakeMetaData
    {
        [DisplayName("Make")]
        public string MakeName { get; set; }
    }
    [MetadataType(typeof(transmissionMetaData))]
    public partial class transmission
    {

    }
    public partial class transmissionMetaData
    {
        [DisplayName("Transmission")]
        public string TransmissionName { get; set; }
    }
    [MetadataType(typeof(turboMetaData))]
    public partial class turbo
    {

    }
    public partial class turboMetaData
    {
        [DisplayName("Turbo")]
        public string TurboName { get; set; }
    }
}
