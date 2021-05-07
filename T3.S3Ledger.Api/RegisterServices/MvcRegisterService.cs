using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using T3.S3Ledger.Api.Commands.Cheque;
using T3.S3Ledger.Api.Commands.Customer;
using T3.S3Ledger.Api.Commands.Invoice;
using T3.S3Ledger.Api.Commands.Organization;
using T3.S3Ledger.Api.Commands.PaymentReceipt;
using T3.S3Ledger.Api.Commands.Salesman;
using T3.S3Ledger.Api.Commands.User;
using T3.S3Ledger.Api.Mapper;
using T3.S3Ledger.Api.Models;
using T3.S3Ledger.Api.Queries.Cheque;
using T3.S3Ledger.Api.Queries.Customer;
using T3.S3Ledger.Api.Queries.Invoice;
using T3.S3Ledger.Api.Queries.Organization;
using T3.S3Ledger.Api.Queries.Salesman;
using T3.S3Ledger.Api.Queries.User;

namespace T3.S3Ledger.Api.RegisterServices
{
    public class MvcRegisterService : IRegisterService
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddMediatR(typeof(GetCustomerByIdQueryHandler));
            //services.AddMediatR(typeof(GetCustomersQueryHandler));
            //services.AddMediatR(typeof(GetOrganizationByIdQueryHandler));
            services.AddControllers();
            services.AddAutoMapper(typeof(AutoMapping));

            // organization
            services.AddTransient<IRequestHandler<GetOrganizationByIdQuery, OrganizationModel>, GetOrganizationByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetAllOrganizationQuery, IEnumerable<OrganizationModel>>, GetAllOrganizationQueryHandler>();
            services.AddTransient<IRequestHandler<CreateOrganizationCommand, OrganizationModel>, CreateOrganizationCommandHandler>();

            // customer
            services.AddTransient<IRequestHandler<GetCustomerByIdQuery, CustomerModel>, GetCustomerByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetCustomersQuery, IEnumerable<CustomerModel>>, GetCustomersQueryHandler>();
            services.AddTransient<IRequestHandler<CreateCustomerCommand, CustomerModel>, CreateCustomerCommandHandler>();

            // cheque
            services.AddTransient<IRequestHandler<GetChequeByIdQuery, ChequeModel>, GetChequeByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetChequesQuery, IEnumerable<ChequeModel>>, GetChequesQueryHandler>();
            services.AddTransient<IRequestHandler<CreateChequeCommand, ChequeModel>, CreateChequeCommandHandler>();

            // invoide
            services.AddTransient<IRequestHandler<GetInvoiceByIdQuery, InvoiceModel>, GetInvoiceByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetInvoicesQuery, IEnumerable<InvoiceModel>>, GetInvoicesQueryHandler>();
            services.AddTransient<IRequestHandler<CreateInvoiceCommand, InvoiceModel>, CreateInvoiceCommandHandler>();

            // payment receipt
            services.AddTransient<IRequestHandler<GetPaymentReceiptByIdQuery, PaymentReceiptModel>, GetPaymentReceiptByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetPaymentReceiptsQuery, IEnumerable<PaymentReceiptModel>>, GetPaymentReceiptsQueryHandler>();
            services.AddTransient<IRequestHandler<CreatePaymentReceiptCommand, PaymentReceiptModel>, CreatePaymentReceiptCommandHandler>();

            // salesman
            services.AddTransient<IRequestHandler<GetSalesmanByIdQuery, SalesmanModel>, GetSalesmanByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetSalesmenQuery, IEnumerable<SalesmanModel>>, GetSalesmenQueryHandler>();
            services.AddTransient<IRequestHandler<CreateSalesmanCommand, SalesmanModel>, CreateSalesmanCommandHandler>();

            // user
            services.AddTransient<IRequestHandler<GetUserByIdQuery, UserModel>, GetUserByIdQueryHandler>();
            services.AddTransient<IRequestHandler<GetUsersQuery, IEnumerable<UserModel>>, GetUsersQueryHandler>();
            services.AddTransient<IRequestHandler<CreateUserCommand, UserModel>, CreateUserCommandHandler>();
        }
    }
}
