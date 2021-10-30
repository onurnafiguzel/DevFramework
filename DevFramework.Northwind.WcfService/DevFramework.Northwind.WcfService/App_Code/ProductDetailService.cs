﻿using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Business.ServiceContracts.Wcf;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary> 
public class ProductDetailService : IProductDetailService
{
    public ProductDetailService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    //Tek bir operasyonu dış dünyaya açacaksak bu şekilde yapıyoruz.

    IProductService _productService = InstanceFactory.GetInstace<IProductService>();

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}