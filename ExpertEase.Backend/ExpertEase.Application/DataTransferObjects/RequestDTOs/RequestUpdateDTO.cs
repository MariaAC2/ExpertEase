﻿using ExpertEase.Domain.Enums;

namespace ExpertEase.Application.DataTransferObjects.RequestDTOs;

public class RequestUpdateDTO
{
    public Guid Id { get; set; }
    public DateTime? RequestedStartDate { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }
    public StatusEnum? Status { get; set; } = StatusEnum.Pending;
}