﻿using Ardalis.Specification;
using ExpertEase.Domain.Entities;

namespace ExpertEase.Domain.Specifications;

public class SpecialistSpec: Specification<Specialist>
{
    public SpecialistSpec(Guid id)
    {
        Query.Where(e => e.UserId == id);
        Query.Include(e=> e.Categories);
    }
}