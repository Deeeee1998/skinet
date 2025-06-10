using System;
using Core.Entities;
using Infrastructure.Specifications;

namespace Core.Specifications;

public class BrandListSpecification: BaseSpecifications<Product, string>
{
    public BrandListSpecification()
    {
        AddSelect(x => x.Brand);
        ApplyDistinct();
}
}
