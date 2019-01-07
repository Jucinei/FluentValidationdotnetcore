using FluentValidatordotnetCore.Model;
using System;
using System.Linq;

namespace FluentValidatordotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();


            AddCustomerSimple(customer);


            AddCustomerWithFluentValidation(customer);

            Console.ReadKey();

        }

        /// <summary>
        /// Validação utilizando FluentValidation
        /// </summary>
        /// <param name="customer"></param>
        static void AddCustomerWithFluentValidation(Customer customer)
        {
            var validator = new CustomerDtoValidator();
            var answerValidation = validator.Validate(customer);
            if (!answerValidation.IsValid)
            {
                Console.WriteLine(answerValidation.Errors.FirstOrDefault());
            }
        }

        /// <summary>
        /// Simple way to Validate Fields
        /// Forma simples para validação de campos
        /// </summary>
        /// <param name="customer"></param>
        static void AddCustomerSimple(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.Name))
            {
                Console.WriteLine("O nome campo é obrigatório");
                return;
            }

            if (!string.IsNullOrEmpty(customer.Email))
            {
                Console.WriteLine("O nome email é obrigatório");
                return;
            }
        }
    }
}
