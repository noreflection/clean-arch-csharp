﻿using clean_arch.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace clean_arch.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
        => _logger = logger;

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("clean_arch Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}