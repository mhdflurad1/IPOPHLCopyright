using System;

namespace CopyrightIndex.Models
{
    public class CopyrightModel
    {
        public string ApplicantLName { get; set; }
        public string ApplicantFName { get; set; }
        public string ApplicantMName { get; set; }
        public string ApplicantGender { get; set; }
        public string ApplicantMaritalStatus { get; set; }
        public string ApplicantPosition { get; set; }
        public string NameCompanyCorpGovASch { get; set; }
        public bool IsSmallType { get; set; }
        public bool IsBigType { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantCountry { get; set; }
        public string ApplicantCity { get; set; }
        public string ApplicantZipCode { get; set; }
        public string ApplicantMobNum { get; set; }
        public string ApplicantEmailAdd { get; set; }
        public string ApplicantNationality { get; set; }
        public DateTime? DateValue { get; set; }
        public string PlaceCreation { get; set; }
        public string ClassificationWork { get; set; }
        public string IPSO { get; set; }
        public string NPL0ffice { get; set; }
        public string ACPMaritalStatus { get; set; }
        public string ACPGender { get; set; }
    }

    public class SubmitDocumentTypeModel
    {
        public string DocumentTypeID { get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
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

    public class PlaceCreationModel
    {
        public string PlaceCreationID { get; set; }
        public string PlaceCreationName { get; set; }
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

    public class ClassificationWorkModel
    {
        public string ClassificationWorkID { get; set; }
        public string ClassificationWorkName { get; set; }
    }

    public class IPSOModel
    {
        public string IPSOID { get; set; }
        public string IPSOName { get; set; }
    }

    public class NPLOfficeModel
    {
        public string NPLOfficeID { get; set; }
        public string NPLOfficeName { get; set; }
    }
}