using System;
using Core.Entities;
using Infrastructure.Specifications;

namespace Core.Specifications;

public class TypeListSpecification: BaseSpecifications<Product,string>
{
    public TypeListSpecification()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }

}
