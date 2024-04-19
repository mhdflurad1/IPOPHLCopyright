using Microsoft.JSInterop;
using Syncfusion.Blazor.Inputs;

namespace CopyrightSchedPage.Client.Models
{
    class ScheduleofFeeModel
    {
        //[Required(ErrorMessage = "This field is required.")]
        public bool CoNCR { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool CoRegion { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool CoBulkNLP { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool CoCertRequest { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool CoCertTrue { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool CoCertPrint { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmNCR { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmRegion { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmBulkNLP { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmDisReso { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmAdditio { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool AmRecons { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool UploadID { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        public bool UploadSign { get; set; }

    }
    
}

