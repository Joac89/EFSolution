//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFWCF.ORMS
{
    using System;
    
    public partial class USP_CUSTOMER_READ_Result
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string DocumentId { get; set; }
        public int DocumentType { get; set; }
        public string DocumentTypeName { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
    }
}