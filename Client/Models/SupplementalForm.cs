using System;
using System.ComponentModel.DataAnnotations;

namespace CoauthorPage.Models
{
    public class SupplementalformModels
    {
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorLName { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorLNamee { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorFName { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorFNamee { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorMName { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorMNamee { get; set; }
        ////[Required]
        public string CoGender { get; set; } = null;
        ////[Required]
        public string CoGenderr { get; set; } = null;
        ////[Required]
        public string CoMartialStatus { get; set; } = null;
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoMartialStatuss { get; set; } = null;
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorPosition { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorPositionn { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorAddress { get; set; }
        public string CoAuthorCountry { get; set; }
        public string CoAuthorState { get; set; }
        public string CoAuthorCity { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorAddresss { get; set; }
        public string CoAuthorCountryy { get; set; }
        public string CoAuthorStatee { get; set; }
        public string CoAuthorCityy { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorZipCode { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorZipCodee { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorMobNum { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorMobNumm { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorEmailAdd { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorEmailAddd { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorNationality { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public string CoAuthorNationalityy { get; set; }

        ////[Required(ErrorMessage = "This field is required.")]
        public DateTime? DateValue { get; set; }
        ////[Required(ErrorMessage = "This field is required.")]
        public DateTime? DateValuee { get; set; }
    }

    public class GenderDataModel
    {
        public string GenderID { get; set; }
        public string GenderName { get; set; }
    }

    public class MaritalStatusDataModel
    {
        public string MaritalStatusID { get; set; }
        public string MaritalStatusName { get; set; }
    }

    public class NationalityDataModel
    {
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
    }

    public class CountryDataModel
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }

    public class CityDataModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
    }
}