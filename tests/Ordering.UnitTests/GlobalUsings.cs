global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using ShreyShop.Ordering.API.Application.Commands;
global using ShreyShop.Ordering.API.Application.Models;
global using ShreyShop.Ordering.API.Infrastructure.Services;
global using ShreyShop.Ordering.Domain.AggregatesModel.BuyerAggregate;
global using ShreyShop.Ordering.Domain.Events;
global using ShreyShop.Ordering.Domain.Exceptions;
global using ShreyShop.Ordering.Domain.SeedWork;
global using ShreyShop.Ordering.Infrastructure.Idempotency;
global using Microsoft.Extensions.Logging;
global using NSubstitute;
global using ShreyShop.Ordering.UnitTests;
global using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
