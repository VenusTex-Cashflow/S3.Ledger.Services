using AutoMapper;
using T3.S3Ledger.Api.Data.Entities;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Organization, OrganizationModel>()
                .ReverseMap();


            CreateMap<Customer, CustomerModel>()
                .ForMember(d => d.Addresses, o => o.MapFrom(s => s.Addresses))
                .ReverseMap();

            CreateMap<Cheque, ChequeModel>()
                .ReverseMap();

            CreateMap<Address, AddressModel>()
                .ReverseMap();

            CreateMap<User, UserModel>()
                .ReverseMap();

            CreateMap<Salesman, SalesmanModel>()
                .ReverseMap();

            CreateMap<Invoice, InvoiceModel>()
                .ForMember(d => d.Salesman, o => o.MapFrom(s => s.Salesman))
                .ForMember(d => d.Customer, o => o.MapFrom(s => s.Customer))
                .ForMember(d => d.CustomerId, o => o.MapFrom(s => s.CustomerId))
                .ForMember(d => d.SalesmanId, o => o.MapFrom(s => s.SalesmanId))
                .ReverseMap();

            CreateMap<PaymentReceipt, PaymentReceiptModel>()
                .ReverseMap();

        }
    }
}
