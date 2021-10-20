using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotNull().WithMessage("Category ID can not be null");
            RuleFor(p => p.ProductName).NotNull().WithMessage("Product name can not be null");
            RuleFor(p => p.ProductName).Length(2, 20).WithMessage("Product name must be between 2-20");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Unit price can not be null");
            RuleFor(p => p.UnitPrice).GreaterThan(1).WithMessage("Unit price must be bigger than 1");
            RuleFor(p => p.QuantityPerUnit).NotNull().WithMessage("Quantity per unit can not be null");
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryId == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Product name must start with A");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
