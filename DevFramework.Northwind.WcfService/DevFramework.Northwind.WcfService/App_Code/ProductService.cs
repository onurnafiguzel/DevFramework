﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Entities.Concrete;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService : IProductService //Servis'in soyutu
{
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // Normalde parametreli constructor pratik olarak mümkün. Ancak SOA'da parametreli contructor kullanılmaz.

    //Manager'ın soyutu
    private IProductService _productService = InstanceFactory.GetInstace<IProductService>();

    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1, product2);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}